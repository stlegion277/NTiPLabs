namespace FigureView
{
    partial class SphereControl
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
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(22, 35);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 0;
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.RadiusTextBox_TextChanged);
            this.RadiusTextBox.Enter += new System.EventHandler(this.RadiusTextBox_Enter);
            this.RadiusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadiusTextBox_KeyPress);
            this.RadiusTextBox.Leave += new System.EventHandler(this.RadiusTextBox_Leave);
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(44, 19);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 1;
            this.RadiusLabel.Text = "Radius";
            // 
            // SphereControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.RadiusTextBox);
            this.Name = "SphereControl";
            this.Size = new System.Drawing.Size(175, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label RadiusLabel;
    }
}