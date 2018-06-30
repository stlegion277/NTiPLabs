using System;
using System.ComponentModel;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{

    public partial class PyramidControl : UserControl
    {
        private double _area = 0;
        private double _height = 0;

        /// <summary>
        /// Конструктор PyramidControl
        /// </summary>
        public PyramidControl()
        {
            InitializeComponent();
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
        /// 
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

        [Browsable(false)]
        public Pyramid Pyramid
        {
            get => new Pyramid(_area, _height);
            set
            {
                if (value == null) return;
                AreaTextBox.Text = Convert.ToString((value as Pyramid).Area);
                HeightTextBox.Text = Convert.ToString((value as Pyramid).Height);
            }
        }

        /// <summary>
        /// Метод для блокирования полей
        /// </summary>
        public bool ReadOnly
        {
            get => HeightTextBox.ReadOnly;
            set
            {
                HeightTextBox.ReadOnly = value;
                AreaTextBox.ReadOnly = value;
            }
        }

        /// <summary>
        /// Событие для изменения текста 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            _height = HeightTextBox.Text != string.Empty ? Convert.ToDouble(HeightTextBox.Text) : 0;
        }

        /// <summary>
        /// Событие для изменения текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {
            _area = AreaTextBox.Text != string.Empty ? Convert.ToDouble(AreaTextBox.Text) : 0;
        }


        private void AreaTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void HeightTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void AreaTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void HeightTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void AreaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }
    }
}
