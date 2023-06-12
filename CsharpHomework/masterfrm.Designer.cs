namespace CsharpHomework
{
    partial class masterfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masterfrm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDrawer = new System.Windows.Forms.Button();
            this.btnStuGrade = new System.Windows.Forms.Button();
            this.btnXOGame = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnMycul = new System.Windows.Forms.Button();
            this.btnHellHi = new System.Windows.Forms.Button();
            this.btnCul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScrSav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackgroundImage = global::CsharpHomework.Properties.Resources.Aprilia_RSV4_by_LandinDesign_on_DeviantArt;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(12, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Turquoise;
            this.splitContainer1.Panel1.Controls.Add(this.btnScrSav);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDrawer);
            this.splitContainer1.Panel1.Controls.Add(this.btnStuGrade);
            this.splitContainer1.Panel1.Controls.Add(this.btnXOGame);
            this.splitContainer1.Panel1.Controls.Add(this.btnStruct);
            this.splitContainer1.Panel1.Controls.Add(this.btnPOS);
            this.splitContainer1.Panel1.Controls.Add(this.btnMycul);
            this.splitContainer1.Panel1.Controls.Add(this.btnHellHi);
            this.splitContainer1.Panel1.Controls.Add(this.btnCul);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Turquoise;
            this.splitContainer1.Panel2.BackgroundImage = global::CsharpHomework.Properties.Resources.Slide11;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 643);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(15, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "猜數字";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDrawer
            // 
            this.btnDrawer.AutoSize = true;
            this.btnDrawer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrawer.BackgroundImage")));
            this.btnDrawer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawer.ForeColor = System.Drawing.Color.Navy;
            this.btnDrawer.Location = new System.Drawing.Point(15, 482);
            this.btnDrawer.Name = "btnDrawer";
            this.btnDrawer.Size = new System.Drawing.Size(110, 32);
            this.btnDrawer.TabIndex = 7;
            this.btnDrawer.Text = "小畫家";
            this.btnDrawer.UseVisualStyleBackColor = true;
            this.btnDrawer.Click += new System.EventHandler(this.btnDrawer_Click);
            // 
            // btnStuGrade
            // 
            this.btnStuGrade.AutoSize = true;
            this.btnStuGrade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStuGrade.BackgroundImage")));
            this.btnStuGrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStuGrade.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuGrade.ForeColor = System.Drawing.Color.Navy;
            this.btnStuGrade.Location = new System.Drawing.Point(15, 418);
            this.btnStuGrade.Name = "btnStuGrade";
            this.btnStuGrade.Size = new System.Drawing.Size(110, 32);
            this.btnStuGrade.TabIndex = 6;
            this.btnStuGrade.Text = "學生成績";
            this.btnStuGrade.UseVisualStyleBackColor = true;
            this.btnStuGrade.Click += new System.EventHandler(this.btnStuGrade_Click);
            // 
            // btnXOGame
            // 
            this.btnXOGame.AutoSize = true;
            this.btnXOGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXOGame.BackgroundImage")));
            this.btnXOGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXOGame.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOGame.ForeColor = System.Drawing.Color.Navy;
            this.btnXOGame.Location = new System.Drawing.Point(15, 358);
            this.btnXOGame.Name = "btnXOGame";
            this.btnXOGame.Size = new System.Drawing.Size(110, 32);
            this.btnXOGame.TabIndex = 5;
            this.btnXOGame.Text = "XO Game";
            this.btnXOGame.UseVisualStyleBackColor = true;
            this.btnXOGame.Click += new System.EventHandler(this.btnXOGame_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.AutoSize = true;
            this.btnStruct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStruct.BackgroundImage")));
            this.btnStruct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStruct.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStruct.ForeColor = System.Drawing.Color.Navy;
            this.btnStruct.Location = new System.Drawing.Point(15, 286);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(110, 32);
            this.btnStruct.TabIndex = 4;
            this.btnStruct.Text = "學生建構";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.AutoSize = true;
            this.btnPOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPOS.BackgroundImage")));
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPOS.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Navy;
            this.btnPOS.Location = new System.Drawing.Point(15, 216);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(110, 32);
            this.btnPOS.TabIndex = 3;
            this.btnPOS.Text = "POS機";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnMycul
            // 
            this.btnMycul.AutoSize = true;
            this.btnMycul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMycul.BackgroundImage")));
            this.btnMycul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMycul.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMycul.ForeColor = System.Drawing.Color.Navy;
            this.btnMycul.Location = new System.Drawing.Point(15, 150);
            this.btnMycul.Name = "btnMycul";
            this.btnMycul.Size = new System.Drawing.Size(110, 32);
            this.btnMycul.TabIndex = 2;
            this.btnMycul.Text = "計算機";
            this.btnMycul.UseVisualStyleBackColor = true;
            this.btnMycul.Click += new System.EventHandler(this.btnMycul_Click);
            // 
            // btnHellHi
            // 
            this.btnHellHi.AutoSize = true;
            this.btnHellHi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHellHi.BackgroundImage")));
            this.btnHellHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHellHi.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHellHi.ForeColor = System.Drawing.Color.Navy;
            this.btnHellHi.Location = new System.Drawing.Point(15, 82);
            this.btnHellHi.Name = "btnHellHi";
            this.btnHellHi.Size = new System.Drawing.Size(110, 32);
            this.btnHellHi.TabIndex = 1;
            this.btnHellHi.Text = "HelloHi";
            this.btnHellHi.UseVisualStyleBackColor = true;
            this.btnHellHi.Click += new System.EventHandler(this.btnHellHi_Click);
            // 
            // btnCul
            // 
            this.btnCul.AutoSize = true;
            this.btnCul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCul.BackgroundImage")));
            this.btnCul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCul.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCul.ForeColor = System.Drawing.Color.Navy;
            this.btnCul.Location = new System.Drawing.Point(15, 18);
            this.btnCul.Name = "btnCul";
            this.btnCul.Size = new System.Drawing.Size(110, 32);
            this.btnCul.TabIndex = 0;
            this.btnCul.Text = "貸款試算";
            this.btnCul.UseVisualStyleBackColor = true;
            this.btnCul.Click += new System.EventHandler(this.btnCul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(280, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "C#作業";
            // 
            // btnScrSav
            // 
            this.btnScrSav.AutoSize = true;
            this.btnScrSav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScrSav.BackgroundImage")));
            this.btnScrSav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScrSav.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrSav.ForeColor = System.Drawing.Color.Navy;
            this.btnScrSav.Location = new System.Drawing.Point(15, 593);
            this.btnScrSav.Name = "btnScrSav";
            this.btnScrSav.Size = new System.Drawing.Size(133, 32);
            this.btnScrSav.TabIndex = 9;
            this.btnScrSav.Text = "螢幕保護程式";
            this.btnScrSav.UseVisualStyleBackColor = true;
            this.btnScrSav.Click += new System.EventHandler(this.btnScrSav_Click);
            // 
            // masterfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = global::CsharpHomework.Properties.Resources.Slide21;
            this.ClientSize = new System.Drawing.Size(1102, 727);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "masterfrm";
            this.Text = "masterfrm";
            this.Load += new System.EventHandler(this.masterfrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCul;
        private System.Windows.Forms.Button btnXOGame;
        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnMycul;
        private System.Windows.Forms.Button btnHellHi;
        private System.Windows.Forms.Button btnStuGrade;
        private System.Windows.Forms.Button btnDrawer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnScrSav;
    }
}