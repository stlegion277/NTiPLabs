using System;
using System.Drawing;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
    /// <summary>
    /// Форма для добавления фигуры
    /// </summary>
    public partial class CreateFigureWindowForm : Form
    {
        /// <summary>
        /// Коструктор для формы добавления фигуры
        /// </summary>
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
                        SelectFigureBox.SelectedIndex = 0;
                        pyramidControl.Pyramid = pyramid;
                        break;
                    case Parallelepiped parallelepiped:
                        SelectFigureBox.SelectedIndex = 1;
                        parallelepipedControl.Parallelepiped = parallelepiped;
                        break;
                    case Sphere sphere:
                        SelectFigureBox.SelectedIndex = 2;
                        sphereControl.Sphere = sphere;
                        break;
                }
            }
        }

        /// <summary>
        /// Метод для блокирования полей
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                parallelepipedControl.ReadOnly = value;
                pyramidControl.ReadOnly = value;
                sphereControl.ReadOnly = value;
            }
        }

        /// <summary>
        /// Метод(событие) для отображения UserControl-ов в зависимости от выбранной фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обработчик события для кнопки OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Обработчик события для кнопки Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
