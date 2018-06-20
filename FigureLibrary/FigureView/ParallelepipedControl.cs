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
using FigureView.Properties;

namespace FigureView
{
    public partial class ParallelepipedControl : UserControl
    {
        private int _length = 0;
        private int _width = 0;
        private int _height = 0;

        public Parallelepiped Parallelepiped
        {
            get
            {
                if ((_length <= 10000) && (_width <= 10000) && (_height <= 10000)
                    && (_length > 0) && (_width > 0) && (_height > 0)) 
                {
                    return new Parallelepiped(_length, _width, _height);
                }
                else
                {
                    MessageBox.Show("Введите целое положительное число в диапазоне от 0 до 10000!", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    LengthTextBox.Text = Convert.ToString((value as Parallelepiped).Length);
                    WidthTextBox.Text = Convert.ToString((value as Parallelepiped).Width);
                    HeightTextBox.Text = Convert.ToString((value as Parallelepiped).Height);
                }
            }
        }

        public bool ReadOnly { get; set; } = true;

        private void LeaveTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == string.Empty)
            {
                textBox.Text = "0";
            }
        }

        private void PressDigit(KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void EnterTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            _length = LengthTextBox.Text != string.Empty ? Convert.ToInt32(LengthTextBox.Text) : 0;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            _width = WidthTextBox.Text != string.Empty ? Convert.ToInt32(WidthTextBox.Text) : 0;
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            _height = HeightTextBox.Text != string.Empty ? Convert.ToInt32(HeightTextBox.Text) : 0;
        }

        private void LengthTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void WidthTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void HeightTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void LengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void LengthTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void WidthTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void HeightTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }
    }
}
