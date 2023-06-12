namespace CsharpHomework
{
    partial class Guessfrm
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.txttips = new System.Windows.Forms.TextBox();
            this.btnShowAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(174, 274);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(169, 57);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txttips
            // 
            this.txttips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttips.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttips.Location = new System.Drawing.Point(93, 154);
            this.txttips.Name = "txttips";
            this.txttips.ReadOnly = true;
            this.txttips.Size = new System.Drawing.Size(533, 31);
            this.txttips.TabIndex = 1;
            this.txttips.Text = "Please select a number between 1 to 100";
            // 
            // btnShowAns
            // 
            this.btnShowAns.Location = new System.Drawing.Point(369, 274);
            this.btnShowAns.Name = "btnShowAns";
            this.btnShowAns.Size = new System.Drawing.Size(169, 57);
            this.btnShowAns.TabIndex = 2;
            this.btnShowAns.Text = "Show Answer";
            this.btnShowAns.UseVisualStyleBackColor = true;
            this.btnShowAns.Click += new System.EventHandler(this.btnShowAns_Click);
            // 
            // Guessfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnShowAns);
            this.Controls.Add(this.txttips);
            this.Controls.Add(this.btnGuess);
            this.Name = "Guessfrm";
            this.Text = "GuessGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        public System.Windows.Forms.TextBox txttips;
        private System.Windows.Forms.Button btnShowAns;
    }
}