using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictitoe
{
    public partial class Form1 : Form
    {
        Button[,] dokmeha;
       
            int Player;
        int ply;
        public Form1()
        {

            {
                InitializeComponent();
                dokmeha = new Button[3, 3];
                createBTN();
                newgame();

            }
        }
            private void createBTN()
            {

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                    dokmeha[i, j] = new Button();
                        dokmeha[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dokmeha[i, j].Click += new EventHandler(button9_Click);
                        tableLayoutPanel1.Controls.Add(dokmeha[i, j], i, j);

                    }
                }
            }

            private void button9_Click(object sender, EventArgs e)
        {
            Button this_butten = (sender as Button);
            if(ply==1)
            {
                this_butten.Text = "X";
                this_butten.ForeColor = Color.DarkGreen;
                this_butten.BackColor = Color.Green;
                ply = 2;

            }
            else if(ply ==2)
            {
                this_butten.Text = "O";
                this_butten.ForeColor = Color.Pink;
                this_butten.BackColor = Color.Red;
                ply = 1;
            }
            checkgame();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newgame();

        }
        private void newgame()
        {
            ply = 1;
            for(int i=0;i<3;i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    dokmeha[i, j].BackColor = Color.Yellow;
                    dokmeha[i, j].Text = "";
                }
            }
        }
        private void checkgame()
        {
            if(dokmeha[0,0].Text=="X"&& dokmeha[0,1].Text == "X" && dokmeha[0, 2].Text == "X" )
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }
            if (dokmeha[1, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[1, 2].Text == "X")
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }
            if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 0].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }
            if (dokmeha[0, 1].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 1].Text == "X")
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }
            if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("HAMED WIN");
                newgame();

            }



            if(dokmeha[0,0].Text=="O"&& dokmeha[0,1].Text == "O" && dokmeha[0, 2].Text == "O")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }
            if (dokmeha[1, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[1, 2].Text == "O")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }
            if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 0].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }
            if (dokmeha[0, 1].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 1].Text == "O")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }
            if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("BOT WIN");
                newgame();

            }

            if (dokmeha[0, 0].Text != "" && dokmeha[0, 1].Text != "" && dokmeha[0, 2].Text != ""
               && dokmeha[1, 0].Text != "" && dokmeha[1, 1].Text != "" && dokmeha[1, 2].Text != ""
               && dokmeha[2, 0].Text != "" && dokmeha[2, 1].Text != "" && dokmeha[2, 2].Text != "")
            {
                MessageBox.Show("Hamed = BOT");
                newgame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
