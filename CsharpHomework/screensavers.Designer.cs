namespace CsharpHomework
{
    partial class screensavers
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
            this.btn100 = new System.Windows.Forms.Button();
            this.labres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(41, 210);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 0;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // labres
            // 
            this.labres.AutoSize = true;
            this.labres.Location = new System.Drawing.Point(164, 79);
            this.labres.Name = "labres";
            this.labres.Size = new System.Drawing.Size(0, 16);
            this.labres.TabIndex = 1;
            // 
            // screensavers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labres);
            this.Controls.Add(this.btn100);
            this.Name = "screensavers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Label labres;
    }
}