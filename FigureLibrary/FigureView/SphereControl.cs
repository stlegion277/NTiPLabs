using System;
using System.ComponentModel;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
    /// <summary>
    /// UserControl для Sphere
    /// </summary>
    public partial class SphereControl : UserControl
    {
        private double _radius = 0;

        /// <summary>
        /// Конструктор SphereControl
        /// </summary>
        public SphereControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство Sphere
        /// </summary>
        [Browsable(false)]
        public Sphere Sphere
        {
            get => new Sphere(_radius);
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    RadiusTextBox.Text = Convert.ToString((value as Sphere).Radius);
                }
            }
        }

        /// <summary>
        /// Метод для установки значения по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        private void LeaveTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == string.Empty)
            {
                textBox.Text = "0";
            }
        }

        /// <summary>
        /// Свойство для блокирования полей
        /// </summary>
        public bool ReadOnly
        {
            get => RadiusTextBox.ReadOnly;
            set => RadiusTextBox.ReadOnly = value;
        }

        /// <summary>
        /// Метод для обнуления строки
        /// </summary>
        /// <param name="sender"></param>
        private void EnterTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Метод для ввода в TextBox
        /// </summary>
        /// <param name="e"></param>
        private void PressDigit(KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        ///Обработчик события для изменения текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            _radius = RadiusTextBox.Text != string.Empty ? Convert.ToDouble(RadiusTextBox.Text) : 0;
        }


        /// <summary>
        /// Обработчик события отпуска и нажима клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        /// <summary>
        /// Обработчик события установки значения по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadiusTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        /// <summary>
        /// Обработчик события обнуляющий строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadiusTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }
    }
}
