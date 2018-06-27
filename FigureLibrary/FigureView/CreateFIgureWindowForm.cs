using System;
using System.Drawing;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
    public partial class CreateFigureWindowForm : Form
    {
        public CreateFigureWindowForm()
        {
            InitializeComponent();
            Size = new Size(320, 300);
            pyramidControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            parallelepipedControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            sphereControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
           
        }   

        public FigureBase Figure
        {
            get
            {
                switch (SelectFigureBox.SelectedIndex)
                {
                    case 0:
                        return pyramidControl.Pyramid;
                    case 1:
                        return parallelepipedControl.Parallelepiped;
                    case 2:
                        return sphereControl.Sphere;
                    default:
                        return null;
                }
            }
            set
            {
                switch (value)
                {
                    case Pyramid pyramid:
                        pyramidControl.Pyramid = pyramid;
                        break;
                    case Parallelepiped parallelepiped:
                        parallelepipedControl.Parallelepiped = parallelepiped;
                        break;
                    case Sphere sphere:
                        sphereControl.Sphere = sphere;
                        break;
                }
            }
        }

        public bool ReadOnly
        {
            set
            {
                parallelepipedControl.ReadOnly = value;
                pyramidControl.ReadOnly = value;
                sphereControl.ReadOnly = value;
            }
        }

        private void SelectFigureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectFigureBox.SelectedIndex == 0)
            {
                sphereControl.Visible = false;
                pyramidControl.Visible = true;
                parallelepipedControl.Visible = false;
                pyramidControl.Location = new Point(9, 75);

            }
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                sphereControl.Visible = false;
                pyramidControl.Visible = false;
                parallelepipedControl.Visible = true;
                parallelepipedControl.Location = new Point(9, 75);
            }
            else if (SelectFigureBox.SelectedIndex == 2)
            {
                sphereControl.Visible = true;
                pyramidControl.Visible = false;
                parallelepipedControl.Visible = false;
                sphereControl.Location = new Point(9, 75);

            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
