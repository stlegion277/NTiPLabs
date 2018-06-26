using System;
using System.ComponentModel;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
    public partial class PyramidControl : UserControl
    {
        private uint _baseArea = 0;
        private uint _height = 0;

        
        public PyramidControl()
        {
            InitializeComponent();
        }

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

        [Browsable(false)]
        public Pyramid Pyramid
        {
            get
            {
                var _baseArea = AreaTextBox.Text != string.Empty ? Convert.ToDouble(AreaTextBox.Text) : 0;
                var _height= HeightTextBox.Text != string.Empty ? Convert.ToDouble(HeightTextBox.Text) : 0;
                if ((_baseArea <= 100000) && (_height <= 800)
                                          && (_baseArea > 0) && (_height > 0))
                {
                    return new Pyramid(_baseArea, _height);
                }
                else
                {
                    //MessageBox.Show("Площадь основания должна быть больше 0 и не превышать 100000\n" +
                    //                "Высота должна быть больше 0 и не превышать 800", "Error",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            set
            {
                if (value == null) return;
                AreaTextBox.Text = Convert.ToString((value as Pyramid).Area);
                HeightTextBox.Text = Convert.ToString((value as Pyramid).Height);
            }
        }

        public bool ReadOnly { get; set; } = true;

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            _height = HeightTextBox.Text != string.Empty ? Convert.ToUInt32(HeightTextBox.Text) : 0;
        }

        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {
            _baseArea = AreaTextBox.Text != string.Empty ? Convert.ToUInt32(AreaTextBox.Text) : 0;
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
