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
    public partial class masterfrm : Form
    {
        public masterfrm()
        {
            InitializeComponent();
        }

        private void btnCul_Click(object sender, EventArgs e)
        {
            frmCulculate frmCul = new frmCulculate();
            openfrm(frmCul);
        }

        private void btnHellHi_Click(object sender, EventArgs e)
        {
            sayhihello frmHelloHi = new sayhihello();
            openfrm(frmHelloHi);
        }

        

        private void btnMycul_Click(object sender, EventArgs e)
        {
            MyCul myCul = new MyCul();
            openfrm(myCul);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            pos pos = new pos();
            openfrm(pos);
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            Student_Structform frmStruct = new Student_Structform();
            openfrm(frmStruct );
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            XOGame xOGame = new XOGame();
            openfrm(xOGame);
        }

        private void btnStuGrade_Click(object sender, EventArgs e)
        {
            StudentGrades studentGrades = new StudentGrades();
            openfrm(studentGrades);
        }
        private void openfrm(Form frmName)
        {
            while (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls[0].Dispose();

            //frmCulculate frmCul = new frmCulculate();

            //非最上層
            frmName.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frmName.Visible = true;

            //設定From位置
            frmName.Top = 0;
            frmName.Left = 0;
            splitContainer1.Panel2.Controls.Add(frmName);
        }

        private void btnDrawer_Click(object sender, EventArgs e)
        {
            drawer drawer = new drawer();
            openfrm(drawer);

        }

        private void masterfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
