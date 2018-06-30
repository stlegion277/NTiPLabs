using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using FigureLibrary;

namespace FigureView
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        private List<FigureBase> _figures;
        private DataContractJsonSerializer _serializer;
       

     
        /// <summary>
        /// Конструктор формы <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _figures = new List<FigureBase>();
            bindingSource.DataSource = _figures;
            dataGridView.DataSource = bindingSource;
            List<Type> knownTypes = new List<Type>
            {
                typeof(Pyramid),
                typeof(Parallelepiped),
                typeof(Sphere),
            };
           
            _serializer = new DataContractJsonSerializer(typeof(List<FigureBase>), knownTypes);
        }

        /// <summary>
        /// Метод для сокрытия UserControl-ов
        /// </summary>
        private void HideControls()
        {
            ParallelepipedControlLabel.Visible = false;
            PyramidControlLabel.Visible = false;
            SphereControlLabel.Visible = false;
            parallelepipedInfoControl.Visible = false;
            pyramidInfoControl.Visible = false;
            sphereInfoControl.Visible = false;
        }

        /// <summary>
        /// метод для поиска в двух TextBox-ах
        /// </summary>
        /// <param name="e"></param>
        private void ChangeVolumeBox(EventArgs e)
        {
            for (int index = 0; index < dataGridView.RowCount; index++)
            {
                dataGridView.Rows[index].Visible = true;
            }

            if (FromVolume.Text != String.Empty && ToVolume.Text != String.Empty)
            {
                List<int> indexes = new List<int>();
                for (int counter = 0; counter < dataGridView.RowCount; counter++)
                {
                    double volume = Convert.ToDouble(dataGridView.Rows[counter].Cells["Amount"].Value);
                    if ((volume < Convert.ToDouble(FromVolume.Text))
                        || (volume > Convert.ToDouble(ToVolume.Text)))
                    {
                        indexes.Add(counter);
                    }
                }
                dataGridView.CurrentCell = null;
                foreach (int index in indexes)
                {
                    dataGridView.Rows[index].Visible = false;
                }

            }
        }

        /// <summary>
        /// метод для ввода в TextBox
        /// </summary>
        /// <param name="e"></param>
        private void PressDigit(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Метод прописаннный для кнопки добавления фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateFigureWindowForm addFigure = new CreateFigureWindowForm()
            {
                ReadOnly = false
            };

            addFigure.ShowDialog();
            if (addFigure.DialogResult == DialogResult.OK && addFigure.Figure != null)
            {
                bindingSource.Add(addFigure.Figure);
            }

            if (addFigure.DialogResult != DialogResult.OK)
            {
                return;
            }
        }

        /// <summary>
        /// Метод прописанный для удаления фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int index = dataGridView.SelectedCells[0].RowIndex;
                dataGridView.Rows.RemoveAt(index);
                HideControls();
            }
        }   

        /// <summary>
        /// TextBox поиска значение от (событие)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromVolume_TextChanged(object sender, EventArgs e)
        {
            ChangeVolumeBox(e);
        }

        /// <summary>
        /// Сохранение файлов(событие)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// открытие сохраненных файлов(событие)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// TextBox поиска значение до (событие)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToVolume_TextChanged(object sender, EventArgs e)
        {
            ChangeVolumeBox(e);
        }

        /// <summary>
        /// Событие ввода(нажатия) в TextBox Значение от
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        /// <summary>
        /// Событие ввода(нажатия) в TextBox Значение до
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }


        /// <summary>
        /// Случайное добавление для отладки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Событие для просмотра введенных значений(меняет UserControl-ы на форме)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            var figure = _figures[dataGridView.CurrentRow.Index];
            ChangeControl(figure);
        }

        /// <summary>
        /// Метод для отображения или сокрытия UserControl-ов
        /// </summary>
        /// <param name="figure"></param>
        private void ChangeControl(FigureBase figure)
        {
            switch (figure)
            {
                case Pyramid pyramid:
                    ParallelepipedControlLabel.Visible = false;
                    SphereControlLabel.Visible = false;
                    PyramidControlLabel.Visible = true;
                    pyramidInfoControl.Visible = true;
                    parallelepipedInfoControl.Visible = false;
                    sphereInfoControl.Visible = false;
                    pyramidInfoControl.ReadOnly = true;
                    pyramidInfoControl.Pyramid = pyramid;
                    break;
                case Parallelepiped parallelepiped:
                    ParallelepipedControlLabel.Visible = true;
                    parallelepipedInfoControl.Visible = true;
                    pyramidInfoControl.Visible = false;
                    sphereInfoControl.Visible = false;
                    parallelepipedInfoControl.ReadOnly = true;
                    PyramidControlLabel.Visible = false;
                    SphereControlLabel.Visible = false;
                    parallelepipedInfoControl.Parallelepiped = parallelepiped;
                    break;
                case Sphere sphere:
                    ParallelepipedControlLabel.Visible = false;
                    PyramidControlLabel.Visible = false;
                    SphereControlLabel.Visible = true;
                    sphereInfoControl.Visible = true;
                    parallelepipedInfoControl.Visible = false;
                    pyramidInfoControl.Visible = false;
                    sphereInfoControl.ReadOnly = true;
                    sphereInfoControl.Sphere = sphere;
                    break;
            }
        }

        /// <summary>
        /// Метод для модификации данных в DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            CreateFigureWindowForm modifyFigureForm = new CreateFigureWindowForm()
            {

                Figure = _figures[dataGridView.CurrentRow.Index],
                ReadOnly = false
            };

            modifyFigureForm.ShowDialog();

            if (modifyFigureForm.DialogResult != DialogResult.OK) return;
            if (modifyFigureForm.Figure == null) return;

            _figures[dataGridView.CurrentRow.Index] = modifyFigureForm.Figure;
            bindingSource.ResetCurrentItem();
            HideControls();
        }
    }
}
