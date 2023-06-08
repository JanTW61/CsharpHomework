using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//Player A -> use X , Player B -> use O
namespace CsharpHomework
{
    public partial class XOGame : Form
    {
        public List<string> playerAChoice = new List<string>();
        public List<string> playerBChoice = new List<string>();
        public string Xsign = "X";
        public string Osign = "O";
        public bool click = true;
        public string labNum;
        public int nowNum;
        public bool playerAwin;
        public bool playerBwin;
        public int gameCount = 0;
        public XOGame()
        {
            InitializeComponent();
        }

        public void funClick(Label lab)
        {
            lab.Text = click ? Xsign : Osign;
            if (click)
            {
                playerAChoice.Add(nowNum.ToString());

            }
            else
            {
                playerBChoice.Add(nowNum.ToString());

            }
            click = !click;
            gameCount++;
            Module();
        }
        private void lab11_Click(object sender, EventArgs e)
        {
            nowNum = 1;
            funClick(lab11);
            lab11.Enabled = false;
        }
        private void lab12_Click(object sender, EventArgs e)
        {
            nowNum = 2;
            funClick(lab12);
            lab12.Enabled = false;
        }

        private void lab13_Click(object sender, EventArgs e)
        {
            nowNum = 3;
            funClick(lab13);
            lab13.Enabled = false;
        }

        private void lab21_Click(object sender, EventArgs e)
        {
            nowNum = 4;
            funClick(lab21);
            lab21.Enabled = false;
        }

        private void lab22_Click(object sender, EventArgs e)
        {
            nowNum = 5;
            funClick(lab22);
            lab22.Enabled = false;
        }

        private void lab23_Click(object sender, EventArgs e)
        {
            nowNum = 6;
            funClick(lab23);
            lab23.Enabled = false;
        }

        private void lab31_Click(object sender, EventArgs e)
        {
            nowNum = 7;
            funClick(lab31);
            lab31.Enabled = false;
        }

        private void lab32_Click(object sender, EventArgs e)
        {
            nowNum = 8;
            funClick(lab32);
            lab32.Enabled = false;
        }

        private void lab33_Click(object sender, EventArgs e)
        {
            nowNum = 9;
            funClick(lab33);
            lab33.Enabled = false;
        }

        public void Module()
        {
            List<int> parsedPlayerAChoice = playerAChoice.Select(int.Parse).ToList();
            List<int> parsedPlayerBChoice = playerBChoice.Select(int.Parse).ToList();

            List<List<int>> winways = new List<List<int>>
            {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 },
            new List<int> { 1, 4, 7 },
            new List<int> { 2, 5, 8 },
            new List<int> { 3, 6, 9 },
            new List<int> { 1, 5, 9 },
            new List<int> { 3, 5, 7 }
            };

            bool playerAwin = winways.Any(winway => winway.All(choice => parsedPlayerAChoice.Contains(choice)));
            bool playerBwin = winways.Any(winway => winway.All(choice => parsedPlayerBChoice.Contains(choice)));
            if (playerAwin)
            {
                MessageBox.Show("playerA win");
                resetgame();
            }
            if (playerBwin) 
            {
                MessageBox.Show("playerB Win");
                resetgame();
            }
            if(gameCount==9)
            {
                MessageBox.Show("平手");
                resetgame();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetgame();
        }

        private void resetgame()
        {
            lab11.Text = "";
            lab12.Text = "";
            lab13.Text = "";
            lab21.Text = "";
            lab22.Text = "";
            lab23.Text = "";
            lab31.Text = "";
            lab32.Text = "";
            lab33.Text = "";
            lab11.Enabled = true;
            lab12.Enabled = true;
            lab13.Enabled = true;
            lab21.Enabled = true;
            lab22.Enabled = true;
            lab23.Enabled = true;
            lab31.Enabled = true;
            lab32.Enabled = true;
            lab33.Enabled = true;
            gameCount = 0;


            playerAChoice.Clear();
            playerBChoice.Clear();
        }
        private void btnESC_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
