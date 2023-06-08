namespace CsharpHomework
{
    partial class sayhihello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.cName = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gold;
            this.txtName.ForeColor = System.Drawing.Color.Indigo;
            this.txtName.Location = new System.Drawing.Point(411, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(246, 352);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(129, 48);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.BackColor = System.Drawing.Color.Gold;
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.ForeColor = System.Drawing.Color.Indigo;
            this.cName.Location = new System.Drawing.Point(222, 102);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(83, 38);
            this.cName.TabIndex = 2;
            this.cName.Text = "姓名";
            // 
            // txtEname
            // 
            this.txtEname.BackColor = System.Drawing.Color.Gold;
            this.txtEname.ForeColor = System.Drawing.Color.Indigo;
            this.txtEname.Location = new System.Drawing.Point(411, 172);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(100, 22);
            this.txtEname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(222, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "英文名字";
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.Gold;
            this.sign.ForeColor = System.Drawing.Color.Indigo;
            this.sign.Location = new System.Drawing.Point(411, 221);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(100, 22);
            this.sign.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(222, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "星座";
            // 
            // sex
            // 
            this.sex.BackColor = System.Drawing.Color.Gold;
            this.sex.ForeColor = System.Drawing.Color.Indigo;
            this.sex.Location = new System.Drawing.Point(411, 276);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 22);
            this.sex.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(222, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "性別";
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(402, 352);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(129, 48);
            this.btnHi.TabIndex = 1;
            this.btnHi.Text = "say Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // sayhihello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CsharpHomework.Properties.Resources.hello;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtName);
            this.Name = "sayhihello";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sayhihello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHi;
    }
}

