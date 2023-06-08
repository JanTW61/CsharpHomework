namespace CsharpHomework
{
    partial class pos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.菜單Menu = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.菜單Menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // 菜單Menu
            // 
            this.菜單Menu.Controls.Add(this.btnWine);
            this.菜單Menu.Controls.Add(this.btnWhisky);
            this.菜單Menu.Controls.Add(this.btnTequila);
            this.菜單Menu.Controls.Add(this.btnBeer);
            this.菜單Menu.Location = new System.Drawing.Point(28, 63);
            this.菜單Menu.Name = "菜單Menu";
            this.菜單Menu.Size = new System.Drawing.Size(227, 384);
            this.菜單Menu.TabIndex = 0;
            this.菜單Menu.TabStop = false;
            this.菜單Menu.Text = "菜單Menu";
            this.菜單Menu.Enter += new System.EventHandler(this.菜單Menu_Enter);
            // 
            // btnWine
            // 
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWine.Location = new System.Drawing.Point(117, 213);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(104, 156);
            this.btnWine.TabIndex = 0;
            this.btnWine.Text = "紅酒\n320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhisky.Location = new System.Drawing.Point(6, 213);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(104, 156);
            this.btnWhisky.TabIndex = 0;
            this.btnWhisky.Text = "威士忌\n350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTequila.Location = new System.Drawing.Point(117, 39);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(104, 156);
            this.btnTequila.TabIndex = 0;
            this.btnTequila.Text = "龍舌蘭\n180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeer.Location = new System.Drawing.Point(6, 39);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(104, 156);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒\n120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labTotal);
            this.groupBox2.Location = new System.Drawing.Point(286, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額Total Price";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labTotal
            // 
            this.labTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labTotal.Location = new System.Drawing.Point(50, 67);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(171, 57);
            this.labTotal.TabIndex = 1;
            this.labTotal.Text = "NT$ 0";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearAll);
            this.groupBox4.Controls.Add(this.labList);
            this.groupBox4.Location = new System.Drawing.Point(538, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 384);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單 List";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(110, 338);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(111, 40);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "清除清單";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // labList
            // 
            this.labList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labList.Location = new System.Drawing.Point(15, 39);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(255, 283);
            this.labList.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnCard);
            this.groupBox5.Controls.Add(this.btnCash);
            this.groupBox5.Location = new System.Drawing.Point(286, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 159);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "付款方式";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "信用卡享九折";
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(120, 74);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(108, 23);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(5, 74);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(98, 23);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CsharpHomework.Properties.Resources.pub;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.菜單Menu);
            this.Name = "pos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pos_Load);
            this.菜單Menu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 菜單Menu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearAll;
    }
}