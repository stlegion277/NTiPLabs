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
    public partial class SphereControl : UserControl
    {
        private int _radius = 0;
        public SphereControl()
        {
            InitializeComponent();
        }

        public Sphere Sphere
        {
            get
            {
                if (_radius < 10000 && _radius > 0)
                {
                    return new Sphere(_radius);
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
                    RadiusTextBox.Text = Convert.ToString((value as Sphere).Radius);
                }
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

        public bool ReadOnly { get; set; } = true;

        private void EnterTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
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

        private void RadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            _radius = RadiusTextBox.Text != string.Empty ? Convert.ToInt32(RadiusTextBox.Text) : 0;
        }

        private void RadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void RadiusTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void RadiusTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }
    }
}
