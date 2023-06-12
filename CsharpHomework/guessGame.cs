using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework
{
    public partial class Guessfrm : Form
    {
        public Guessfrm()
        {
            InitializeComponent();
        }
        public static int rndNum=0;
        public static int tmphigh = 100;
        public static int tmplow = 0;


        private void btnGuess_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rndNum = rnd.Next(1,101);
            guessingFrm gsF= new guessingFrm();
            gsF.ShowDialog();

        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer is {rndNum}");
        }
    }
}
