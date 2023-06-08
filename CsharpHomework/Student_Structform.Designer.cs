namespace CsharpHomework
{
    partial class Student_Structform
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
            this.btnShowSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labShowHL = new System.Windows.Forms.Label();
            this.labShowAll = new System.Windows.Forms.Label();
            this.btnShowHL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowSave
            // 
            this.btnShowSave.Location = new System.Drawing.Point(214, 327);
            this.btnShowSave.Name = "btnShowSave";
            this.btnShowSave.Size = new System.Drawing.Size(138, 47);
            this.btnShowSave.TabIndex = 0;
            this.btnShowSave.Text = "顯示儲存內容";
            this.btnShowSave.UseVisualStyleBackColor = true;
            this.btnShowSave.Click += new System.EventHandler(this.btnShowSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 45);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labShowHL);
            this.groupBox1.Controls.Add(this.labShowAll);
            this.groupBox1.Location = new System.Drawing.Point(467, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // labShowHL
            // 
            this.labShowHL.Location = new System.Drawing.Point(6, 200);
            this.labShowHL.Name = "labShowHL";
            this.labShowHL.Size = new System.Drawing.Size(293, 93);
            this.labShowHL.TabIndex = 0;
            this.labShowHL.Text = " ";
            // 
            // labShowAll
            // 
            this.labShowAll.Location = new System.Drawing.Point(6, 18);
            this.labShowAll.Name = "labShowAll";
            this.labShowAll.Size = new System.Drawing.Size(293, 161);
            this.labShowAll.TabIndex = 0;
            this.labShowAll.Text = " ";
            // 
            // btnShowHL
            // 
            this.btnShowHL.Location = new System.Drawing.Point(568, 365);
            this.btnShowHL.Name = "btnShowHL";
            this.btnShowHL.Size = new System.Drawing.Size(158, 48);
            this.btnShowHL.TabIndex = 0;
            this.btnShowHL.Text = "最高分/最低分科目";
            this.btnShowHL.UseVisualStyleBackColor = true;
            this.btnShowHL.Click += new System.EventHandler(this.btnShowHL_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名 :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(201, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 45);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "國文 :";
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChi.Location = new System.Drawing.Point(201, 112);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(203, 45);
            this.txtChi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "英文 :";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEng.Location = new System.Drawing.Point(201, 176);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(203, 45);
            this.txtEng.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "數學 :";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMath.Location = new System.Drawing.Point(201, 242);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(203, 45);
            this.txtMath.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Student_Structform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShowHL);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowSave);
            this.Name = "Student_Structform";
            this.Text = "Student_Structform";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowHL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labShowHL;
        private System.Windows.Forms.Label labShowAll;
    }
}