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
        int flame = PlayerIndex;
        int time = 100;
        int score = 100;
        int itemCount = ItemMax;
        int hiscore = 0;
        const bool isDebug = true;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(´・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();

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

        const int SpeedMax = 20;

        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for(int i=0; i < ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                Controls.Add(chrs[i]);
                chrs[i].Font = tempLabel.Font;
            }
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

            if(currentState == State.Game)
            {
                UpdataGame();
            }
            Itemlabel.Text = ("★:" + itemCount.ToString());
        }

        void UpdataGame()
        {
            flame++;
            if(flame >= 10)
            {
                score--;
                time--;      
                Timelabel.Text = ("Time:" + time.ToString());
                //scorelabel.Text = ("score:" + score.ToString());
                flame = PlayerIndex;
            }
            if(time <= 0)
            {
                nextState = State.Gameover;
            }
            
            
            //Hilabel.Text = ("HighScore" + hiscore.ToString());
            
            Point mp = PointToClient(MousePosition);
            //プレイヤーが中心になるように設定
            chrs[PlayerIndex].Left = mp.X - (chrs[PlayerIndex].Width / 2);
            chrs[PlayerIndex].Top = mp.Y - (chrs[PlayerIndex].Height / 2);

            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                //ラベル反射
                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                if ((mp.X >= chrs[i].Left)
                && (mp.X < chrs[i].Right)
                && (mp.Y >= chrs[i].Top)
                && (mp.Y < chrs[i].Bottom))
                {
                    if (i < ItemIndex)
                    {
                        //ゲームオーバー                       
                        nextState = State.Gameover; 
                    }
                    else
                    {
                        //アイテム入手                   
                        if(chrs[i].Visible == true)
                        {
                            itemCount--;
                            if (itemCount <= 0)
                            {
                                nextState = State.Clear;
                            }
                        }
                        chrs[i].Visible = false;
                    }
                    
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
                    for(int i = PlayerIndex; i < ChrMax; i++)
                    {
                        chrs[i].Visible = false;
                    }
                    
                    itemCount = ItemMax;
                    time = 100;
                    score = 100;
                    Timelabel.Text = ("Time:100");
                    //scorelabel.Text = ("score:100");
                    Itemlabel.Text = ("★:"+ItemMax.ToString());
                     
                    break;


                case State.Game:
                    Titlelabel.Visible = false;
                    Startbutton.Visible = false;
                    Hilabel.Visible = false;
                    Copyright.Visible = false;

                    for(int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }
                    for(int i = PlayerIndex; i < ChrMax; i++)
                    {
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        chrs[i].Visible = true;
                    }
                    break;



                case State.Gameover:
                    Gameoverlabel.Visible = true;
                    Titlebutton.Visible = true;
                    Hilabel.Visible = false;
                    for (int i = PlayerIndex; i < ChrMax; i++)
                    {
                        chrs[i].Visible = false;
                    }
                    
                    break;

                case State.Clear:
                    Clearlabel.Visible = true;
                    Titlebutton.Visible = true;
                    Hilabel.Visible = true;
                    for (int i = PlayerIndex; i < ChrMax; i++)
                    {
                        chrs[i].Visible = false;
                    }
                    if (hiscore <= time)
                    {
                        hiscore = time;
                    }
                    Hilabel.Text = ("HighScore" + hiscore.ToString());
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
