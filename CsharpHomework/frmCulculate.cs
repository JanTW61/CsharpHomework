using System;
using System.Collections;
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
    public partial class frmCulculate : Form
    {
        public frmCulculate()
        {
            InitializeComponent();
        }
        public double Principal;
        public int loanYears;
        public double yearInterestRate;
        public double firstpay;
        public double monthlyPayment;
        public int numberOfMonths;
        public bool boolIsNum=false;
        public int passCount = 0;
        private void culcu()
        {
            isNum();
            if (boolIsNum)
            {
                Principal = double.Parse(txtloanMoney.Text);
                loanYears = int.Parse(txtlimityear.Text);
                yearInterestRate = double.Parse(txtpersent.Text);
                firstpay = double.Parse(txtfirstpay.Text);
                Principal -= firstpay;
                double monthlyInterestRate = yearInterestRate / 12 / 100; // 月利率
                numberOfMonths = loanYears * 12; // 月数

                double numerator = Math.Pow(1 + monthlyInterestRate, numberOfMonths) * monthlyInterestRate;
                double denominator = Math.Pow(1 + monthlyInterestRate, numberOfMonths) - 1;

                double prate = numerator / denominator;

                monthlyPayment = prate * Principal;
            }
        }
        public void btnPMT_Click(object sender, EventArgs e)
        {
            boolIsNum = false;
            culcu();
            if (boolIsNum)
            {
                MessageBox.Show("每月還款金額: " + Math.Round(monthlyPayment, 0));
            }
        }

        public void btnsum_Click(object sender, EventArgs e)
        {
            boolIsNum = false;
            culcu();
            if (boolIsNum)
            {
                
                MessageBox.Show("總付款: " + Math.Round(monthlyPayment * numberOfMonths, 0) + "元");
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            boolIsNum = false;
            culcu();
            if (boolIsNum)
            {
                
                frmloanReport loanfrm = new frmloanReport(Principal, loanYears, monthlyPayment, yearInterestRate, firstpay);
                loanfrm.Show();
            }
        }
        private void txtloanMoney_TextChanged(object sender, EventArgs e)
        {

        }
        private void isNum()
        {
            int num1;
            TextBox[] checkList = { txtloanMoney, txtlimityear, txtpersent, txtfirstpay };
            passCount = 0;
            foreach (TextBox i in checkList) {
                if (i.Text.Length == 0)
                {
                    MessageBox.Show("數字不能為空");
                    i.Focus();
                    i.Text = "";

                }
                else if (!int.TryParse(i.Text, out num1))
                {
                    MessageBox.Show("請勿輸入非數值");
                    i.Focus();
                    i.Text = "";
                }
                else
                {
                    passCount++;
                    if (passCount == 4)
                    {
                     boolIsNum = true;
                    }
                }
            }
        }
    }
}
/*本息金額之平均攤還率(Prate)＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)*/