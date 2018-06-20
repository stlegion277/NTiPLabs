namespace FigureView
{
    partial class PyramidControl
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
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(12, 28);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaTextBox.TabIndex = 0;
            this.AreaTextBox.TextChanged += new System.EventHandler(this.AreaTextBox_TextChanged);
            this.AreaTextBox.Enter += new System.EventHandler(this.AreaTextBox_Enter);
            this.AreaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaTextBox_KeyPress);
            this.AreaTextBox.Leave += new System.EventHandler(this.AreaTextBox_Leave);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(12, 71);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 1;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            this.HeightTextBox.Enter += new System.EventHandler(this.HeightTextBox_Enter);
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            this.HeightTextBox.Leave += new System.EventHandler(this.HeightTextBox_Leave);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(31, 12);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(29, 13);
            this.AreaLabel.TabIndex = 2;
            this.AreaLabel.Text = "Area";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(31, 55);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "Height";
            // 
            // PyramidControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.AreaTextBox);
            this.Name = "PyramidControl";
            this.Size = new System.Drawing.Size(161, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label HeightLabel;
    }
}