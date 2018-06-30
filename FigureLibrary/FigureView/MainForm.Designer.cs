namespace FigureView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.FromVolume = new System.Windows.Forms.TextBox();
            this.ToVolume = new System.Windows.Forms.TextBox();
            this.HyphenLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.FigureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SphereControlLabel = new System.Windows.Forms.Label();
            this.PyramidControlLabel = new System.Windows.Forms.Label();
            this.ParallelepipedControlLabel = new System.Windows.Forms.Label();
            this.parallelepipedInfoControl = new FigureView.ParallelepipedControl();
            this.sphereInfoControl = new FigureView.SphereControl();
            this.pyramidInfoControl = new FigureView.PyramidControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(103, 187);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Figure";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(268, 187);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove Figure";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(184, 187);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "Modify Figure";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // FromVolume
            // 
            this.FromVolume.Location = new System.Drawing.Point(392, 37);
            this.FromVolume.Name = "FromVolume";
            this.FromVolume.Size = new System.Drawing.Size(100, 20);
            this.FromVolume.TabIndex = 5;
            this.FromVolume.TextChanged += new System.EventHandler(this.FromVolume_TextChanged);
            this.FromVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FromVolume_KeyPress);
            // 
            // ToVolume
            // 
            this.ToVolume.Location = new System.Drawing.Point(523, 37);
            this.ToVolume.Name = "ToVolume";
            this.ToVolume.Size = new System.Drawing.Size(100, 20);
            this.ToVolume.TabIndex = 6;
            this.ToVolume.TextChanged += new System.EventHandler(this.ToVolume_TextChanged);
            this.ToVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToVolume_KeyPress);
            // 
            // HyphenLabel
            // 
            this.HyphenLabel.AutoSize = true;
            this.HyphenLabel.Location = new System.Drawing.Point(498, 36);
            this.HyphenLabel.Name = "HyphenLabel";
            this.HyphenLabel.Size = new System.Drawing.Size(19, 13);
            this.HyphenLabel.TabIndex = 7;
            this.HyphenLabel.Text = "__";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(488, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Search";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FigureType,
            this.Amount});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Location = new System.Drawing.Point(103, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // FigureType
            // 
            this.FigureType.DataPropertyName = "FigureType";
            this.FigureType.HeaderText = "Figure";
            this.FigureType.Name = "FigureType";
            this.FigureType.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(FigureLibrary.FigureBase);
            // 
            // SphereControlLabel
            // 
            this.SphereControlLabel.AutoSize = true;
            this.SphereControlLabel.Location = new System.Drawing.Point(427, 81);
            this.SphereControlLabel.Name = "SphereControlLabel";
            this.SphereControlLabel.Size = new System.Drawing.Size(41, 13);
            this.SphereControlLabel.TabIndex = 13;
            this.SphereControlLabel.Text = "Sphere";
            // 
            // PyramidControlLabel
            // 
            this.PyramidControlLabel.AutoSize = true;
            this.PyramidControlLabel.Location = new System.Drawing.Point(427, 171);
            this.PyramidControlLabel.Name = "PyramidControlLabel";
            this.PyramidControlLabel.Size = new System.Drawing.Size(44, 13);
            this.PyramidControlLabel.TabIndex = 14;
            this.PyramidControlLabel.Text = "Pyramid";
            // 
            // ParallelepipedControlLabel
            // 
            this.ParallelepipedControlLabel.AutoSize = true;
            this.ParallelepipedControlLabel.Location = new System.Drawing.Point(563, 81);
            this.ParallelepipedControlLabel.Name = "ParallelepipedControlLabel";
            this.ParallelepipedControlLabel.Size = new System.Drawing.Size(73, 13);
            this.ParallelepipedControlLabel.TabIndex = 15;
            this.ParallelepipedControlLabel.Text = "Parallelepiped";
            // 
            // parallelepipedInfoControl
            // 
            this.parallelepipedInfoControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.parallelepipedInfoControl.Location = new System.Drawing.Point(516, 97);
            this.parallelepipedInfoControl.Name = "parallelepipedInfoControl";
            this.parallelepipedInfoControl.ReadOnly = true;
            this.parallelepipedInfoControl.Size = new System.Drawing.Size(150, 146);
            this.parallelepipedInfoControl.TabIndex = 12;
            // 
            // sphereInfoControl
            // 
            this.sphereInfoControl.Location = new System.Drawing.Point(382, 81);
            this.sphereInfoControl.Name = "sphereInfoControl";
            this.sphereInfoControl.ReadOnly = false;
            this.sphereInfoControl.Size = new System.Drawing.Size(128, 65);
            this.sphereInfoControl.TabIndex = 11;
            // 
            // pyramidInfoControl
            // 
            this.pyramidInfoControl.Location = new System.Drawing.Point(392, 187);
            this.pyramidInfoControl.Name = "pyramidInfoControl";
            this.pyramidInfoControl.ReadOnly = true;
            this.pyramidInfoControl.Size = new System.Drawing.Size(147, 126);
            this.pyramidInfoControl.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 371);
            this.Controls.Add(this.ParallelepipedControlLabel);
            this.Controls.Add(this.PyramidControlLabel);
            this.Controls.Add(this.SphereControlLabel);
            this.Controls.Add(this.parallelepipedInfoControl);
            this.Controls.Add(this.sphereInfoControl);
            this.Controls.Add(this.pyramidInfoControl);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.HyphenLabel);
            this.Controls.Add(this.ToVolume);
            this.Controls.Add(this.FromVolume);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
  
        private System.Windows.Forms.BindingSource bindingSource;
        
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        
    
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.TextBox FromVolume;
        private System.Windows.Forms.TextBox ToVolume;
        private System.Windows.Forms.Label HyphenLabel;
        private System.Windows.Forms.Label SearchLabel;
        private PyramidControl pyramidInfoControl;
        private SphereControl sphereInfoControl;
        private ParallelepipedControl parallelepipedInfoControl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label SphereControlLabel;
        private System.Windows.Forms.Label PyramidControlLabel;
        private System.Windows.Forms.Label ParallelepipedControlLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FigureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

