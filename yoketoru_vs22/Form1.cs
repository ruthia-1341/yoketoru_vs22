using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoru_vs22
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int SpeedMax = 10;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;//（PlayerMax = 1）+（ PlayerIndex = 0）＝１
        const int ItemIndex = EnemyIndex + EnemyMax;//（EnemyIndex =（PlayerMax = 1）+（ PlayerIndex = 0）＝１）+（EnemyMax = 10）＝11

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();

        enum State
        {//何も宣言しない場合は上から0.1...となる。が、わからないので－1をもうける。-1なのは初期化のためにも、自然に入らんものってことかな？

            None = -1, //無効
            Title,     //タイトル
            Game,      //ゲーム
            Gameover,  //ゲームオーバー
            Clear,     //クリア
        }
        //押された情報を保存しておいて、結果が出たら処理をする（遅延処理）　　　ネット環境とかだとよく使うっぽい…？
        
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKye);

        int ItemCount;

        public Form1()
        {
            InitializeComponent();

            for (int i=0;i<ChrMax;i++)
            {
                chrs[i]= new Label();
                chrs[i].AutoSize = true;

                if (i == PlayerIndex)//i=プレイヤーインデックス
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i<ItemIndex)//1～10はエネミーになる
                {
                    chrs[i].Text = EnemyText;
                }
                else//11以上はアイテムになる
                {
                    chrs[i].Text = ItemText;
                }

                chrs[i].Font = templabel1.Font;
                Controls.Add(chrs[i]);
            }
        }

        void UpdateGame()
        {//ゲームを止めておく場所をここに集めるってことかな？
            
            Point mp = PointToClient(MousePosition);
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width/2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height/2;
            //Textではなく、Indexの方！

            // TODO: mpがプレイヤーの中心になるように設定
            for (int i=EnemyIndex;i<ChrMax;i++)
            {
                

                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                if (!chrs[i].Visible)//番人　turuが成立が普通だが、！をつければ反対になる。　…つまりfalseのものは動作しない
                {
                    continue;
                }

                if (chrs[i].Left<0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }else if (chrs[i].Left > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (chrs[i].Top > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                if (mp.X <= chrs[i].Right && mp.Y <= chrs[i].Bottom && mp.X > chrs[i].Left && mp.Y > chrs[i].Top)
                {
                    if (i < ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {//アイテム
                        chrs[i].Visible = false;
                        ItemCount--;
                        
                        if (ItemCount <= 0)
                        {
                             nextState = State.Clear;
                        }
                        countlabel4.Text = $"★:{ItemCount:00}";

                        /*
                        //速度を０にして
                        vx[i] = 0;
                        vy[i] = 0;
                        //座標を飛ばす
                        chrs[i].Left = 10000;
                        */
                    }
                  
                }
               
            } 
            
            
            /*
              ??????????????????????????何とかしてくれ

            PlayerIndex.Left = mp.X - PlayerIndex.Width / 2;
            PlayerIndex.Top = mp.Y - PlayerIndex.Height / 2;*/


            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {//初期化処理
             //状態が切り替わるときに 一回だけ 動作する
               initProc();
            }

            if (isDebug)//bool型なら==とかいらない。()の中を計算。boolで計算され、tureだったら成立、みたいな感じになる。前に！をつけると成立不成立が反転する（tureとかは反転しない）。
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C)<0)
                {
                    nextState = State.Clear;
                }
            }

            if (currentState == State.Game)//がめおべらの時にゲームを止めるっていう処理あるやん、それみたいなやつ
            {
                UpdateGame();
            }

        }


        void initProc()//開始時
        {
            currentState = nextState;
            nextState = State.None;//次のタイマーが実行されたタイミングではもう実行されない

            switch (currentState)
            {
                case State.Title:
                    title_label.Visible = true;
                    start_button.Visible = true;
                    copyroghtlabel.Visible = true;
                    hilabel1.Visible = true;
                    gameover_label5.Visible = false;
                    title_button1.Visible = false;
                    clear_label6.Visible = false;

                    break;

                case State.Game:
                    title_label.Visible = false;
                    start_button.Visible = false;
                    copyroghtlabel.Visible = false;
                    hilabel1.Visible = false;

                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }

                    ItemCount = ItemMax;

                    break;

                case State.Gameover:
                    gameover_label5.Visible = true;
                    title_button1.Visible = true;
                    break;

                case State.Clear:
                    clear_label6.Visible = true;
                    title_button1.Visible = true;
                    hilabel1.Visible = true;
                    break;

            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void title_button1_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void templabel1_Click(object sender, EventArgs e)
        {

        }

        private void countlabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
