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

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;//（PlayerMax = 1）+（ PlayerIndex = 0）＝１
        const int ItemIndex = EnemyIndex + EnemyMax;//（EnemyIndex =（PlayerMax = 1）+（ PlayerIndex = 0）＝１）+（EnemyMax = 10）＝11

        const int PlayerText = "(・ω・)";


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

        public Form1()
        {
            InitializeComponent();
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
        }


        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

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
    }
}
