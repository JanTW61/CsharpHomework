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
    public partial class Student_Structform : Form
    {
        public Student_Structform()
        {
            InitializeComponent();
        }
        public string name;
        public int EngGrades;
        public int MathGrades;
        public int ChiGrades;
        public int highest;
        public string highestsub;
        public int lowest;
        public string lowestsub;
        public bool boolIsNum = false;
        public int passCount = 0;

        Dictionary<string, int> grades = new Dictionary<string, int>();
        private void btnShowSave_Click(object sender, EventArgs e)
        {
            boolIsNum = false;
            isNum();
            if (boolIsNum)
            {
                labShowAll.Text = "";
                labShowAll.Text += ("姓名 : " + name + "\n國文 : " + ChiGrades + "分\n英文 : " + EngGrades + "分\n數學 : "
                    + MathGrades + "分");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            boolIsNum = false;
            isNum();
            if(boolIsNum)
            {
                name = txtName.Text;
                grades.Clear();
                EngGrades = Convert.ToUInt16(txtEng.Text);
                ChiGrades = Convert.ToUInt16(txtChi.Text);
                MathGrades = Convert.ToUInt16(txtMath.Text);
                grades["英文成績"] = EngGrades;
                grades["國文成績"] = ChiGrades;
                grades["數學成績"] = MathGrades;
            }
        }

     
        private void btnShowHL_Click(object sender, EventArgs e)
        {
            lowest = 999;
            highest = -1;
            labShowHL.Text = "";
            foreach (var grade in grades)
            {
                if (Convert.ToUInt16(grade.Value) > highest)
                {
                    highest = Convert.ToUInt16(grade.Value);
                    highestsub = grade.Key.ToString();
                }
                else if (Convert.ToUInt16(grade.Value) == highest)
                {
                    highestsub += "," + grade.Key.ToString();
                }
                if (Convert.ToUInt16(grade.Value) < lowest)
                {
                    lowest = Convert.ToUInt16(grade.Value);
                    lowestsub = grade.Key.ToString();
                }
                else if (Convert.ToUInt16(grade.Value) == lowest)
                {
                    lowestsub += ","+grade.Key.ToString();
                }
                
            }
            labShowHL.Text += "最高分科目成績為 : " + highestsub + highest +
                    "分\n最低科目成績為 : " + lowestsub + lowest + "分";
        }

        private void isNum()
        {
            int num1;
            TextBox[] checkList = { txtChi, txtEng, txtMath };
            passCount = 0;
            foreach (TextBox i in checkList)
            {
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
                    if (passCount == 3)
                    {
                        boolIsNum = true;
                    }
                }
            }
        }
    }

}
