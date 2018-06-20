using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
    public partial class CreateFigureWindowForm : Form
    {
        public CreateFigureWindowForm()
        {
            this.Size = new Size(320, 300);
            ParallelepipedControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            PyramidControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            SphereControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            InitializeComponent();
        }

        public FigureBase Figure
        {
            get
            {
                switch (SelectFigureBox.SelectedIndex)
                {
                    case 0:
                        return ParallelepipedControl.Parallelepiped;
                    case 1:
                        return PyramidControl.Pyramid;
                    case 2:
                        return SphereControl.Sphere;
                    default:
                        return null;
                }
            }
            set
            {
                switch (value)
                {
                    case Parallelepiped _parallelepiped:
                      ParallelepipedControl.Parallelepiped = _parallelepiped;
                        break;
                    case Pyramid _pyramid:
                        PyramidControl.Pyramid = _pyramid;
                        break;
                    case Sphere _sphere:
                        SphereControl.Sphere = _sphere;
                        break;
                }
            }
        }

        private void BackToMain()
        {
            SphereControl.Visible = false;
            ParallelepipedControl.Visible = false;
            ParallelepipedControl.Visible = false;

            SelectFigureBox.SelectedIndex = -1;

            this.Hide();
        }

        public bool ReadOnly
        {
            set
            {
                ParallelepipedControl.ReadOnly = value;
                PyramidControl.ReadOnly = value;
                SphereControl.ReadOnly = value;
            }
        }

        private void CreateFIgureWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectFigureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectFigureBox.SelectedIndex == 0)
            {
                SphereControl.Visible = false;
                PyramidControl.Visible = false;
                ParallelepipedControl.Visible = true;
                ParallelepipedControl.Location = new Point(9, 75);


            }
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                SphereControl.Visible = false;
                PyramidControl.Visible = true;
                ParallelepipedControl.Visible = false;
                PyramidControl.Location = new Point(9, 75);
            }
            else if (SelectFigureBox.SelectedIndex == 2)
            {
                SphereControl.Visible = true;
                PyramidControl.Visible = false;
                ParallelepipedControl.Visible = false;
                SphereControl.Location = new Point(9, 75);

            }
        }
    }
}
