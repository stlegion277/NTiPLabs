using System;
using System.ComponentModel;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
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

        private void LeaveTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == string.Empty)
            {
                textBox.Text = "0";
            }
        }


        public bool ReadOnly
        {
            get => RadiusTextBox.ReadOnly;
            set => RadiusTextBox.ReadOnly = value;
        }


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
            _radius = RadiusTextBox.Text != string.Empty ? Convert.ToDouble(RadiusTextBox.Text) : 0;
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
