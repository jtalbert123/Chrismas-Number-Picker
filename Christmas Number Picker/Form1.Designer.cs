namespace Christmas_Number_Picker
{
    partial class Form1
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
            this.DisplayValue = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayValue
            // 
            this.DisplayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayValue.Location = new System.Drawing.Point(12, 137);
            this.DisplayValue.Name = "DisplayValue";
            this.DisplayValue.Size = new System.Drawing.Size(890, 38);
            this.DisplayValue.TabIndex = 8;
            this.DisplayValue.Text = "?";
            this.DisplayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(418, 212);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 272);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            this.Controls.Add(DisplayValue);
            this.Controls.Add(ResetButton);
        }

        #endregion
        private System.Windows.Forms.Label DisplayValue;
        private System.Windows.Forms.Button ResetButton;
    }
}

