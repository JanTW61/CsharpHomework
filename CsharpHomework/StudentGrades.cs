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

namespace CsharpHomework
{
    public partial class StudentGrades : Form
    {
        public StudentGrades()
        {
            InitializeComponent();
        }
        public int EngGrades;
        public int MathGrades;
        public int ChiGrades;
        public int highest;
        public string highestsub;
        public int lowest;
        public string lowestsub;
        public int stuCount=0;
        public int sumOfEng;
        public int sumOfMath;
        public int sumOfChi;
        public int highestEng=0;
        public int highestChi=0;
        public int highestMath=0;
        public int lowestEng=101;
        public int lowestMath=101;
        public int lowestChi = 101;
        Dictionary<string, int> grades = new Dictionary<string, int>();
        ListViewItem newitem = new ListViewItem();
        private void btnAddData_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 0)
            {
                Name = txtName.Text;
            }
            else 
            {
                MessageBox.Show("請輸入姓名");
                txtName.Focus();
                txtName.Clear();
            }


            bool isNum = int.TryParse(txtEng.Text,out EngGrades );
            if(isNum)
            {

            }
            else
            {
                MessageBox.Show("請輸入英文成績");
                txtEng.Focus();
                txtEng.Clear();
            }

            bool isNumm = int.TryParse(txtChi.Text, out ChiGrades);
            if (isNumm)
            {
                
            }
            else
            {
                MessageBox.Show("請輸入國文成績");
                txtChi.Focus();
                txtChi.Clear();
                
            }

            bool isNummm = int.TryParse(txtMath.Text, out MathGrades);
            if (isNummm)
            {
                
            }
            else
            {
                MessageBox.Show("請輸入數學成績");
                txtMath.Focus();
                txtMath.Clear();
            }

            if((txtName.Text.Length > 0)&&isNum &&isNumm&&isNummm)
            {
                ChiGrades = Convert.ToUInt16(txtChi.Text);
                MathGrades = Convert.ToUInt16(txtMath.Text);
                EngGrades = Convert.ToUInt16(txtEng.Text);
                grades["英文"] = EngGrades;
                grades["國文"] = ChiGrades;
                grades["數學"] = MathGrades;
                addData();
            }

            

        }

        public void addData()
        {
            int sum = ChiGrades + EngGrades + MathGrades;
            int avg = sum / 3;
            lowest = 999; highest = -1;
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
                    lowestsub += "," + grade.Key.ToString();
                }

            }
            sumOfChi += ChiGrades;
            sumOfEng += EngGrades;
            sumOfMath += MathGrades;
            if (ChiGrades >highestChi)
            {
                highestChi = ChiGrades;
            }
            if (MathGrades > highestMath)
            {
                highestMath = MathGrades;
            }
            if (EngGrades > highestEng)
            {
                highestEng = EngGrades;
            }

            if (ChiGrades < lowestChi)
            {
                lowestChi = ChiGrades;
            }
            if (MathGrades < lowestMath)
            {
                lowestMath = MathGrades;
            }
            if (EngGrades < lowestEng)
            {
                lowestEng = EngGrades;
            }
            /*txtAllData.Text += Name + "               " + ChiGrades + "               " + EngGrades +
           "              " + MathGrades + "              " + sum + "            " + avg + "           " +
           lowest + lowestsub + "          " + highest + highestsub + Environment.NewLine;*/
            ListViewItem newitem = new ListViewItem();
            newitem.SubItems.Add(Name);
            newitem.SubItems.Add(ChiGrades.ToString());
            newitem.SubItems.Add(EngGrades.ToString());
            newitem.SubItems.Add(MathGrades.ToString());            
            newitem.SubItems.Add(sum.ToString());
            newitem.SubItems.Add(avg.ToString());
            newitem.SubItems.Add(lowest.ToString() +lowestsub) ;
            newitem.SubItems.Add(highest.ToString()+highestsub);
            listView1.Items.Add(newitem);

        }

        private void btnAddrandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            EngGrades=rnd.Next(0, 101);
            ChiGrades=rnd.Next(0, 101);
            MathGrades=rnd.Next(0, 101);
            grades["英文"] = EngGrades;
            grades["國文"] = ChiGrades;
            grades["數學"] = MathGrades;
            stuCount += 1;
            Name =stuCount.ToString();
            

            addData();
        }

        private void btnRandomAdd20time(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i=0; i < 21; i++)
            {
                
                EngGrades = rnd.Next(0, 101);
                ChiGrades = rnd.Next(0, 101);
                MathGrades = rnd.Next(0, 101);
                grades["英文"] = EngGrades;
                grades["國文"] = ChiGrades;
                grades["數學"] = MathGrades;
                stuCount += 1;
                Name = stuCount.ToString();
                addData();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stuCount = 0;
            //txtAllData.Text = "";
            //newitem.SubItems.Clear();
            listView1.Items.Clear();
            txtName.Text = "";
            txtEng.Text="";
            txtChi.Text = "";
            txtMath.Text = "";
            labAna.Text = "";
            lowestChi = 0;
            lowestEng = 0;
            lowestMath= 0;
            highestChi = 0;
            highestEng = 0;
            highestMath = 0;
            btnAddData.Enabled = true;
            btnAddrandom.Enabled = true;
            btnAddrandom20.Enabled = true;
            btnAnalysis.Enabled = true;


        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            btnAddData.Enabled = false;
            btnAddrandom.Enabled = false;
            btnAddrandom20.Enabled = false;
            btnAnalysis.Enabled = false;
            labAna.Text += $"總分  {sumOfChi}  {sumOfEng}  {sumOfMath}\n平均   {sumOfChi/stuCount}  " +
                $" {sumOfEng/stuCount}   {sumOfMath/stuCount}\n最高分    {highestChi}   {highestEng}  " +
                $" {highestMath}\n最低分   {lowestChi}   {lowestEng}   {lowestMath}";

        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("", 0);
            listView1.Columns.Add("姓名", 50);
            listView1.Columns.Add("國文", 50);
            listView1.Columns.Add("英文", 50);
            listView1.Columns.Add("數學", 50);
            listView1.Columns.Add("總分", 50);
            listView1.Columns.Add("平均", 50);
            listView1.Columns.Add("最低", 80);
            listView1.Columns.Add("最高", 80);
        }
    }
}

