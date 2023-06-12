using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CsharpHomework
{
    public partial class guessingFrm : Form
    {
        Guessfrm gsFrm = new Guessfrm();
        public static int guessnum;
        public guessingFrm()
        {
            InitializeComponent();
            gsFrm = Application.OpenForms.OfType<Guessfrm>().FirstOrDefault();

        }

        public void btnEnter_Click(object sender, EventArgs e)
        {
            bool isnum=int.TryParse(textBox1.Text.ToString(), out guessnum);
            
            if (isnum && guessnum<100)
            {
                if (guessnum > Guessfrm.rndNum)
                {
                    gsFrm.txttips.Text = $"太大了, 在 {guessnum}跟{Guessfrm.tmplow}之間";
                    Guessfrm.tmphigh = guessnum;
                }
                if (guessnum < Guessfrm.rndNum)
                {
                    gsFrm.txttips.Text = $"太小了, 在 {Guessfrm.tmphigh}跟{guessnum}之間";
                    Guessfrm.tmplow = guessnum;
                }
                if (guessnum == Guessfrm.rndNum)
                {
                    MessageBox.Show("有囉 答對囉 ");
                }
            }
            else 
            {
                textBox1.Focus();
                textBox1.Clear();
                MessageBox.Show("kar拎拿 你再給我亂玩試試看ㄏㄚˋ 😊");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
