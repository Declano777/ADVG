namespace ADVG
{
    partial class rules
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
            this.rulesLable = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulesLable
            // 
            this.rulesLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLable.Location = new System.Drawing.Point(12, 9);
            this.rulesLable.Name = "rulesLable";
            this.rulesLable.Size = new System.Drawing.Size(776, 306);
            this.rulesLable.TabIndex = 0;
            this.rulesLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(273, 344);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(229, 81);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to game";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rulesLable);
            this.Name = "rules";
            this.Text = "rules";
            this.Load += new System.EventHandler(this.rules_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rulesLable;
        private System.Windows.Forms.Button backButton;
    }
}