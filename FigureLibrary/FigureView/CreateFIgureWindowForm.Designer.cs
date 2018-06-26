namespace FigureView
{
    partial class CreateFigureWindowForm
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
            this.SelectFigureBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.parallelepipedControl = new FigureView.ParallelepipedControl();
            this.pyramidControl = new FigureView.PyramidControl();
            this.sphereControl = new FigureView.SphereControl();
            this.SuspendLayout();
            // 
            // SelectFigureBox
            // 
            this.SelectFigureBox.FormattingEnabled = true;
            this.SelectFigureBox.Items.AddRange(new object[] {
            "Pyramid",
            "Parallelepiped",
            "Sphere"});
            this.SelectFigureBox.Location = new System.Drawing.Point(45, 33);
            this.SelectFigureBox.Name = "SelectFigureBox";
            this.SelectFigureBox.Size = new System.Drawing.Size(121, 21);
            this.SelectFigureBox.TabIndex = 0;
            this.SelectFigureBox.SelectedIndexChanged += new System.EventHandler(this.SelectFigureBox_SelectedIndexChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(120, 247);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(26, 247);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // parallelepipedControl
            // 
            this.parallelepipedControl.Location = new System.Drawing.Point(409, 66);
            this.parallelepipedControl.Name = "parallelepipedControl";
            this.parallelepipedControl.Parallelepiped = null;
            this.parallelepipedControl.ReadOnly = true;
            this.parallelepipedControl.Size = new System.Drawing.Size(150, 150);
            this.parallelepipedControl.TabIndex = 9;
            // 
            // pyramidControl
            // 
            this.pyramidControl.Location = new System.Drawing.Point(409, 70);
            this.pyramidControl.Name = "pyramidControl";
            this.pyramidControl.Pyramid = null;
            this.pyramidControl.ReadOnly = true;
            this.pyramidControl.Size = new System.Drawing.Size(161, 133);
            this.pyramidControl.TabIndex = 10;
            // 
            // sphereControl
            // 
            this.sphereControl.Location = new System.Drawing.Point(407, 66);
            this.sphereControl.Name = "sphereControl";
            this.sphereControl.ReadOnly = false;
            this.sphereControl.Size = new System.Drawing.Size(175, 149);
            this.sphereControl.Sphere = null;
            this.sphereControl.TabIndex = 11;
            // 
            // CreateFigureWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 336);
            this.Controls.Add(this.sphereControl);
            this.Controls.Add(this.pyramidControl);
            this.Controls.Add(this.parallelepipedControl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SelectFigureBox);
            this.Name = "CreateFigureWindowForm";
            this.Text = "CreateFIgureWindowForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectFigureBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private ParallelepipedControl parallelepipedControl;
        private PyramidControl pyramidControl;
        private SphereControl sphereControl;
    }
}