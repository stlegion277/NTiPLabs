using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureLibrary;
using FigureView.Properties;

namespace FigureView
{
    public partial class MainForm : Form
    {
        private List<FigureBase> _figures;
        private DataContractJsonSerializer _serializer;
        static int maxvalue = 10;

        public MainForm()
        {
            InitializeComponent();
            _figures = new List<FigureBase>();
            bindingSource.DataSource = _figures;
            dataGridView.DataSource = bindingSource;
            List<Type> knownTypes = new List<Type>
            {
                typeof(Parallelepiped),
                typeof(Pyramid),
                typeof(Sphere),
            };
            _serializer = new DataContractJsonSerializer(typeof(List<FigureBase>), knownTypes);
        }

         private void ChangeIDBox(EventArgs e)
        {
            for (int index = 0; index < DataGridView.RowCount; index++)
            {
                DataGridView.Rows[index].Visible = true;
            }

            if (MinID.Text != String.Empty && MaxID.Text != String.Empty)
            {
                List<int> indexes = new List<int>();
                for (int counter = 0; counter < DataGridView.RowCount; counter++)
                {
                    double volume = Convert.ToDouble(DataGridView.Rows[counter].Cells["Column2"].Value);
                    if ((volume < Convert.ToDouble(MinID.Text))
                        || (volume > Convert.ToDouble(MaxID.Text)))
                    {
                        indexes.Add(counter);
                    }
                }
                DataGridView.CurrentCell = null;
                foreach (int index in indexes)
                {
                    DataGridView.Rows[index].Visible = false;
                }

            }
        }

        private void PressDigit(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateFigureWindowForm addFigure = new CreateFigureWindowForm();
            {
                ReadOnly = false;
            }
            addFigure.ShowDialog();
            if (addFigure.DialogResult != DialogResult.OK)
            {
                return;
            }

            if (addFigure.Figure != null)
            {
                bindingSource.Add(addFigure.Figure);
            }


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int index = dataGridView.SelectedCells[0].RowIndex;
                dataGridView.Rows.RemoveAt(index);
            }
        }   

        private void MinID_TextChanged(object sender, EventArgs e)
        {
            ChangeIDBox(e);
        }

        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Figures|*.fig";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                _serializer.WriteObject(fileStream, _figures);
                fileStream.Dispose();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "Figures|*.fig";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                List<FigureBase> deserializeFigures = (List<FigureBase>)_serializer.ReadObject(fileStream);
                fileStream.Dispose();

                bindingSource.Clear();

                foreach (FigureBase figure in deserializeFigures)
                {
                    bindingSource.Add(figure);
                }
            }
        }

        private void MaxID_TextChanged(object sender, EventArgs e)
        {
            ChangeIDBox(e);
        }

        private void MinID_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void MaxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6:
#if DEBUG
                    if (e.Control)
                    {
                        Random rand = new Random();
                        int type = rand.Next(0, 3);

                        if (type == 0)
                        {
                            int a = rand.Next(1, 50);
                            int b = rand.Next(1, 50);
                            int c = rand.Next(1, 50);
                            bindingSource.Add(new Parallelepiped((uint)a, (uint)b, (uint)c));
                        }
                        else if (type == 1)
                        {
                            int baseArea = rand.Next(1, 1000);
                            int height = rand.Next(1, 20);
                            bindingSource.Add(new Pyramid((uint)baseArea, (uint)height));
                        }
                        else
                        {
                            int radius = rand.Next(1, 100);
                            bindingSource.Add(new Sphere((uint)radius));
                        }
                    }
#endif
                    break;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            var figure = _figures[dataGridView.CurrentRow.Index];
            ChangeControl(figure);
        }

        private void ChangeControl(FigureBase figure)
        {
            switch (figure)
            {
                case Parallelepiped parallelepiped:
                    parallelepipedInfoControl.Visible = true;
                    pyramidInfoControl.Visible = false;
                    sphereInfoControl.Visible = false;
                    pyramidInfoControl.ReadOnly = true;
                    parallelepipedInfoControl.Parallelepiped = parallelepiped;
                    break;
                case Pyramid pyramid:
                    pyramidInfoControl.Visible = true;
                    parallelepipedInfoControl.Visible = false;
                    sphereInfoControl.Visible = false;
                    pyramidInfoControl.ReadOnly = true;
                    pyramidInfoControl.Pyramid = pyramid;
                    break;
                case Sphere sphere:
                    sphereInfoControl.Visible = true;
                    parallelepipedInfoControl.Visible = false;
                    pyramidInfoControl.Visible = false;
                    sphereInfoControl.ReadOnly = true;
                    sphereInfoControl.Sphere = sphere;
                    break;
            }
        }
    }
}
