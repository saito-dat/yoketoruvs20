using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
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
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    Titlelabel.Visible = true;
                    button1.Visible = true;
                    Hilabel.Visible = true;
                    Gameoverlabel.Visible = false;
                    Clearlabel.Visible = false;
                    Titlebutton.Visible = false;
                    break;

                case State.Game:
                    Titlelabel.Visible = false;
                    button1.Visible = false;
                    Hilabel.Visible = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
