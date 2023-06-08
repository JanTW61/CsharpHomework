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
    public partial class MyCul : Form
    {
        bool isNumb = false;
        public MyCul()
        {
            InitializeComponent();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            labAns.Text = "";
            isNum();
            if (isNumb)
            {
                labAns.Text += int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
            }
            isNumb = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labAns.Text = "";
            isNum();
            if (isNumb)
            {
                labAns.Text += int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
            }
            isNumb = false;

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            labAns.Text = "";
            isNum();
            if (isNumb)
            {
                labAns.Text += int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
            }
            isNumb = false;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            labAns.Text = "";
            isNum();
            if (isNumb)
            {
                if (int.Parse(txtNum2.Text) == 0)
                {
                    MessageBox.Show("分母不能為0");
                    txtNum2.Text = "";
                    txtNum2.Focus();
                }
                else
                {
                    double tmpAns= double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text);
                    labAns.Text += Math.Round(tmpAns,1);
                }
            }
            isNumb = false;
            
        }
        private void isNum()
        {
            int num1, num2;
            if (txtNum1.Text.Length == 0 )
            {
                MessageBox.Show("數字不能為空");
                txtNum1.Focus();
                txtNum1.Text = "";
                
            }
            else if (!int.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("請勿輸入非數值");
                txtNum1.Focus();
                txtNum1.Text = "";
            }
            
            if (txtNum2.Text.Length == 0)
            {
                MessageBox.Show("數字不能為空");
                txtNum2.Focus();
            }
            
            else if (!int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("請勿輸入非數值");
                txtNum2.Focus();
                txtNum2.Text = "";
            }
            else
            {
                isNumb = true;
            }
        }
    }
}
