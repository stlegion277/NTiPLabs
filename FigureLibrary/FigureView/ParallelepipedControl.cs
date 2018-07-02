using System;
using System.ComponentModel;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
    /// <summary>
    /// UserControl для Parallelepiped
    /// </summary>
    public partial class ParallelepipedControl : UserControl
    {
        private int _length = 0;
        private int _width = 0;
        private int _height = 0;

        /// <summary>
        /// Конструктор Parallelepiped
        /// </summary>
        public ParallelepipedControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Свойство Parallelepiped
        /// </summary>
        [Browsable(false)]
        public Parallelepiped Parallelepiped
        {
            get => new Parallelepiped(_length, _width, _height);
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    LengthTextBox.Text = Convert.ToString(value.Length);
                    WidthTextBox.Text = Convert.ToString(value.Width);
                    HeightTextBox.Text = Convert.ToString(value.Height);
                }
            }
        }

        /// <summary>
        /// Свойство для блокирования полей
        /// </summary>
        public bool ReadOnly
        {
            get => LengthTextBox.ReadOnly;

            set
            {
                LengthTextBox.ReadOnly = value;
                WidthTextBox.ReadOnly = value;
                HeightTextBox.ReadOnly = value;
            }
        }


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
        /// Обработчик события для изменения текста 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            _length = LengthTextBox.Text != string.Empty ? Convert.ToInt32(LengthTextBox.Text) : 0;
        }

        /// <summary>
        /// Обработчик события для изменения текста 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            _width = WidthTextBox.Text != string.Empty ? Convert.ToInt32(WidthTextBox.Text) : 0;
        }

        /// <summary>
        /// Обработчик события для изменения текста 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            _height = HeightTextBox.Text != string.Empty ? Convert.ToInt32(HeightTextBox.Text) : 0;
        }

        /// <summary>
        /// Обработчик события установки значения по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        /// <summary>
        /// Обработчик события установки значения по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        /// <summary>
        /// Обработчик события установки значения по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        /// <summary>
        /// Обработчик события отпуска и нажима клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        /// <summary>
        /// Обработчик события обнуляющий строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        /// <summary>
        /// Обработчик события отпуска и нажима клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        /// <summary>
        /// Обработчик события обнуляющий строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        /// <summary>
        /// Обработчик события отпуска и нажима клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        /// <summary>
        /// Обработчик события обнуляющий строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }
    }
}
