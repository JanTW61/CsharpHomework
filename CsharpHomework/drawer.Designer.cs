namespace CsharpHomework
{
    partial class drawer
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
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.TBChangeSize = new System.Windows.Forms.TrackBar();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBChangeSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(675, 64);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(87, 39);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "顏色選擇";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // TBChangeSize
            // 
            this.TBChangeSize.Location = new System.Drawing.Point(706, 127);
            this.TBChangeSize.Name = "TBChangeSize";
            this.TBChangeSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TBChangeSize.Size = new System.Drawing.Size(56, 118);
            this.TBChangeSize.TabIndex = 1;
            this.TBChangeSize.Scroll += new System.EventHandler(this.TBChangeSize_Scroll);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(664, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 41);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "重置畫紙";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // drawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.TBChangeSize);
            this.Controls.Add(this.btnChangeColor);
            this.Name = "drawer";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawer_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.TBChangeSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.TrackBar TBChangeSize;
        private System.Windows.Forms.Button btnClear;
    }
}