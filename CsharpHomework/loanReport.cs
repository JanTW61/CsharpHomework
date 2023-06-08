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
    public partial class frmloanReport : Form
    {
        public frmloanReport(double tmploanMoney, int loanYears, double monthlyPayment,double yearInterestRate,double firstpay )
        {
            InitializeComponent();
            Pricipal.Text= (tmploanMoney+firstpay).ToString();
            loanYearss.Text=loanYears.ToString();
            mpt.Text= Math.Round(monthlyPayment,0).ToString();
            yir.Text= Math.Round(yearInterestRate,0).ToString();
            sum.Text=Math.Round((monthlyPayment*loanYears*12),0).ToString();
        }


    }
}

