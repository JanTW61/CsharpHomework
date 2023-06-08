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
    public partial class sayhihello : Form
    {
        public sayhihello()
        {
            InitializeComponent();
        }
      
        private void btnHello_Click(object sender, EventArgs e)
        {
            string Cname = txtName.Text;
            string Ename = txtEname.Text;
            string sexname = sex.Text;
            string signname = sign.Text;
            MessageBox.Show("hello! \n你的名字是: " + Cname+"\n你的英文名字是"+Ename+
                "\n你的性別是: " + sexname + "\n你的星座是: " + signname);

        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string Cname = txtName.Text;
            string Ename = txtEname.Text;
            string sexname = sex.Text;
            string signname = sign.Text;
            MessageBox.Show("hi! \n你的名字是: " + Cname + "\n你的英文名字是" + Ename +
                "\n你的性別是: " + sexname + "\n你的星座是: " + signname);
        }

        private void sayhihello_Load(object sender, EventArgs e)
        {

        }
    }
}
