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
    public partial class screensavers : Form
    {
        public screensavers()
        {
            InitializeComponent();
        }

        string res = "";
        
        private void btn100_Click(object sender, EventArgs e)
        {
            //01 =2^0 10=2^1 100=2^2 1000=2^3


            //100 50 25 12 6 3 1 0
            // 0   0  1   0 0 1 1 

            for (int i = 2; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    if (i + j >= 10)
                    {
                        labres.Text += $"{j} x  {i} = {i * j}|\t";
                    }
                    else
                    {
                        labres.Text += $"{j} x  {i} =   {i * j}|\t";
                    }

                    
                }
                labres.Text += "\n";
            }


                MessageBox.Show(res);
            
            
        }
    }
}
