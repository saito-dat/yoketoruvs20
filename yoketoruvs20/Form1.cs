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

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;
        const int playerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;

        enum State
        {
            None = -1,   //無効
            Title,       //タイトル
            Game,        //ゲーム
            Gameover,    //ゲームオーバー
            Clear        //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if(GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    Titlelabel.Visible = true;
                    Startbutton.Visible = true;
                    Hilabel.Visible = true;
                    Copyright.Visible = true;
                    Gameoverlabel.Visible = false;
                    Clearlabel.Visible = false;
                    Titlebutton.Visible = false;
                    break;

                case State.Game:
                    Titlelabel.Visible = false;
                    Startbutton.Visible = false;
                    Hilabel.Visible = false;
                    Copyright.Visible = false;
                    break;

                case State.Gameover:
                    Gameoverlabel.Visible = true;
                    Titlebutton.Visible = true;
                    break;

                case State.Clear:
                    Clearlabel.Visible = true;
                    Titlebutton.Visible = true;
                    Hilabel.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }

        private void Itemlabel_Click(object sender, EventArgs e)
        {

        }

        private void Titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
