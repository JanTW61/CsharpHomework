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
    public partial class pos : Form
    {
        public pos()
        {
            InitializeComponent();
        }
        public int total = 0;
        public int beerNum=0;
        public int tequilaNum = 0;
        public int whiskyNum = 0;
        public int wineNum = 0;


        private void btnCash_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐");
            }
            else
            {
                MessageBox.Show("總金額 : NT$ " + total);
            }


        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐");
            }
            else
            {
                MessageBox.Show("總金額 : NT$ " + total + "\n折扣後金額 : NT$ "+total* 0.9);
            }
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            total += 120;
            if (beerNum==0)
            {
                beerNum++;
                labList.Text += ("啤酒Beer X" + beerNum + ",共NT$ " + (120 * beerNum) + " 元\n");
            }
            else
            {
                beerNum++;
                string labelText = labList.Text;
                int startIndex = labelText.IndexOf("Beer X") + 6; // 找到 "Beer X" 後的索引位置
                int endIndex = labelText.IndexOf(",", startIndex); // 找到逗號後的索引位置
                string oldNumberString = labelText.Substring(startIndex, endIndex - startIndex).Trim(); // 提取原始的 beerNum 字串
                int oldNumber = int.Parse(oldNumberString);
                int newNumber = beerNum;
                string newLabelText = labelText.Replace("Beer X" + oldNumber, "Beer X" + newNumber); // 替換 beerNum 部分為新的數字
                newLabelText = newLabelText.Replace("NT$ " + (120 * oldNumber), "NT$ " + (120 * newNumber)); // 更新金額
                labList.Text = newLabelText;

            }
            UpdateTotalPrice(total);
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            total += 180;
            if (tequilaNum == 0)
            {
                tequilaNum++;
                labList.Text += ("龍舌蘭Tequila X" + tequilaNum + ",共NT$ " + (180 * tequilaNum) + " 元\n");
            }
            else
            {
                tequilaNum++;
                string labelText = labList.Text;
                int startIndex = labelText.IndexOf("龍舌蘭Tequila X") + 12; // 找到 "Tequila X" 後的索引位置
                int endIndex = labelText.IndexOf(",", startIndex); // 找到逗號後的索引位置
                string oldNumberString = labelText.Substring(startIndex, endIndex - startIndex).Trim(); // 提取原始的 tequilaNum 字串
                int oldNumber = int.Parse(oldNumberString);
                int newNumber = tequilaNum;
                string newLabelText = labelText.Replace("龍舌蘭Tequila X" + oldNumber, "龍舌蘭Tequila X" + newNumber); // 替換 tequilaNum 部分為新的數字
                newLabelText = newLabelText.Replace("NT$ " + (180 * oldNumber), "NT$ " + (180 * newNumber)); // 更新金額
                labList.Text = newLabelText;

            }
            UpdateTotalPrice(total);
        }
        private void btnWhisky_Click(object sender, EventArgs e)
        {
            total += 350;
            if (whiskyNum == 0)
            {
                whiskyNum++;
                labList.Text += ("威士忌Whisky X" + whiskyNum + ",共NT$ " + (350 * whiskyNum) + " 元\n");
            }
            else
            {
                whiskyNum++;
                string labelText = labList.Text;
                int startIndex = labelText.IndexOf("威士忌Whisky X") + 11; // 找到 "Tequila X" 後的索引位置
                int endIndex = labelText.IndexOf(",", startIndex); // 找到逗號後的索引位置
                string oldNumberString = labelText.Substring(startIndex, endIndex - startIndex).Trim(); // 提取原始的 tequilaNum 字串
                int oldNumber = int.Parse(oldNumberString);
                int newNumber = whiskyNum;
                string newLabelText = labelText.Replace("威士忌Whisky X" + oldNumber, "威士忌Whisky X" + newNumber); // 替換 tequilaNum 部分為新的數字
                newLabelText = newLabelText.Replace("NT$ " + (350 * oldNumber), "NT$ " + (350 * newNumber)); // 更新金額
                labList.Text = newLabelText;

            }
            UpdateTotalPrice(total);
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            total += 320;
            if (wineNum == 0)
            {
               wineNum++;
                labList.Text += ("紅酒Wine X" +wineNum + ",共NT$ " + (320 * wineNum) + " 元\n");
            }
            else
            {
                wineNum++;
                string labelText = labList.Text;
                int startIndex = labelText.IndexOf("紅酒Wine X") + 8; // 找到 "Tequila X" 後的索引位置
                int endIndex = labelText.IndexOf(",", startIndex); // 找到逗號後的索引位置
                string oldNumberString = labelText.Substring(startIndex, endIndex - startIndex).Trim(); // 提取原始的 tequilaNum 字串
                int oldNumber = int.Parse(oldNumberString);
                int newNumber = wineNum;
                string newLabelText = labelText.Replace("紅酒Wine X" + oldNumber, "紅酒Wine X" + newNumber); // 替換 tequilaNum 部分為新的數字
                newLabelText = newLabelText.Replace("NT$ " + (320 * oldNumber), "NT$ " + (320 * newNumber)); // 更新金額
                labList.Text = newLabelText;

            }
            UpdateTotalPrice(total);

        }
        public void UpdateTotalPrice(int newTotal)
        {
            total = newTotal;
            labTotal.Text= "NT$ "+total.ToString();
        }



        private void btnClearAll_Click(object sender, EventArgs e)
        {
            total = 0;
            beerNum = 0;
            tequilaNum = 0;
            whiskyNum = 0;
            wineNum = 0;
            labTotal.Text = "NT$ 0";
            labList.Text = "";
        }

        private void pos_Load(object sender, EventArgs e)
        {

        }

        private void 菜單Menu_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
