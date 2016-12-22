namespace Christmas_Number_Picker
{
    partial class ColorPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPanel.BackColor = System.Drawing.Color.Green;
            this.ColorPanel.ForeColor = System.Drawing.Color.Blue;
            this.ColorPanel.Location = new System.Drawing.Point(3, 3);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ColorPanel.Size = new System.Drawing.Size(100, 100);
            this.ColorPanel.TabIndex = 0;
            this.ColorPanel.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorPanel);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(106, 106);
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ColorPanel;
    }
}
