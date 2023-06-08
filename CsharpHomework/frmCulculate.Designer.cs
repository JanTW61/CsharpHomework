namespace CsharpHomework
{
    public partial class frmCulculate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtloanMoney = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlimityear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpersent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfirstpay = new System.Windows.Forms.TextBox();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(271, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // txtloanMoney
            // 
            this.txtloanMoney.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtloanMoney.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloanMoney.ForeColor = System.Drawing.Color.Maroon;
            this.txtloanMoney.Location = new System.Drawing.Point(400, 83);
            this.txtloanMoney.Name = "txtloanMoney";
            this.txtloanMoney.Size = new System.Drawing.Size(100, 38);
            this.txtloanMoney.TabIndex = 1;
            this.txtloanMoney.TextChanged += new System.EventHandler(this.txtloanMoney_TextChanged);
            // 
            // btnPMT
            // 
            this.btnPMT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMT.ForeColor = System.Drawing.Color.Maroon;
            this.btnPMT.Location = new System.Drawing.Point(194, 310);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(157, 42);
            this.btnPMT.TabIndex = 2;
            this.btnPMT.Text = "PMT(月付)";
            this.btnPMT.UseVisualStyleBackColor = false;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(271, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "期限(年)";
            // 
            // txtlimityear
            // 
            this.txtlimityear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtlimityear.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlimityear.ForeColor = System.Drawing.Color.Maroon;
            this.txtlimityear.Location = new System.Drawing.Point(400, 136);
            this.txtlimityear.Name = "txtlimityear";
            this.txtlimityear.Size = new System.Drawing.Size(100, 38);
            this.txtlimityear.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(271, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "利率(%)";
            // 
            // txtpersent
            // 
            this.txtpersent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtpersent.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpersent.ForeColor = System.Drawing.Color.Maroon;
            this.txtpersent.Location = new System.Drawing.Point(400, 183);
            this.txtpersent.Name = "txtpersent";
            this.txtpersent.Size = new System.Drawing.Size(100, 38);
            this.txtpersent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(271, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "頭期款";
            // 
            // txtfirstpay
            // 
            this.txtfirstpay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtfirstpay.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstpay.ForeColor = System.Drawing.Color.Maroon;
            this.txtfirstpay.Location = new System.Drawing.Point(400, 230);
            this.txtfirstpay.Name = "txtfirstpay";
            this.txtfirstpay.Size = new System.Drawing.Size(100, 38);
            this.txtfirstpay.TabIndex = 1;
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsum.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsum.ForeColor = System.Drawing.Color.Maroon;
            this.btnsum.Location = new System.Drawing.Point(380, 310);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(111, 42);
            this.btnsum.TabIndex = 2;
            this.btnsum.Text = "總付款";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnreport.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.Maroon;
            this.btnreport.Location = new System.Drawing.Point(549, 310);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(105, 42);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // frmCulculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CsharpHomework.Properties.Resources.money;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtfirstpay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpersent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlimityear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtloanMoney);
            this.Controls.Add(this.label1);
            this.Name = "frmCulculate";
            this.Text = "frmCulculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloanMoney;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlimityear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpersent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfirstpay;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnreport;
    }
}