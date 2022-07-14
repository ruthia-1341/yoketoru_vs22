using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoru_vs22
{
    public partial class Form1 : Form
    {
        enum State
        {//何も宣言しない場合は上から0.1...となる。が、わからないので－1をもうける

            None = -1, //無効
            Title,     //タイトル
            Game,      //ゲーム
            Gameover,  //ゲームオーバー
            Clear,     //クリア
        }
        //押された情報を保存しておいて、結果が出たら処理をする（遅延処理）　　　ネット環境とかだとよく使うっぽい…？
        
        State currentState = State.None;
        State nextState = State.Title;

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
    }
}
