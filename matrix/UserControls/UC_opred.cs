using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix.UserControls
{
    public partial class UC_opred : UserControl
    {
        public UC_opred()
        {
            InitializeComponent();
        }
        #region
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelotvet_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            // Очистка поля ответа
            labelotvet_Opred.Text = null;

            textBox_OpInfo.Visible = false;
            double[,] matrix = new double[3, 3];
            try
            {
                matrix[0, 0] = double.Parse(textBox1.Text);
                matrix[0, 1] = double.Parse(textBox2.Text);
                matrix[0, 2] = double.Parse(textBox3.Text);
                matrix[1, 0] = double.Parse(textBox4.Text);
                matrix[1, 1] = double.Parse(textBox5.Text);
                matrix[1, 2] = double.Parse(textBox6.Text);
                matrix[2, 0] = double.Parse(textBox7.Text);
                matrix[2, 1] = double.Parse(textBox8.Text);
                matrix[2, 2] = double.Parse(textBox9.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода! Введите корректные числа или допишите все числа.");
                textBox_OpInfo.Visible = true;
                return;
            }

            labelotvet_Opred.Text = "Исходная матрица:\r\n";
            PrintMatrix(matrix);

            double detA = 0;
            detA += matrix[0, 0] * matrix[1, 1] * matrix[2, 2];
            detA += matrix[0, 1] * matrix[1, 2] * matrix[2, 0];
            detA += matrix[0, 2] * matrix[1, 0] * matrix[2, 1];
            detA -= matrix[0, 2] * matrix[1, 1] * matrix[2, 0];
            detA -= matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
            detA -= matrix[0, 0] * matrix[1, 2] * matrix[2, 1];

            labelotvet_Opred.AppendText($"Вычисляем определитель:\r\n");
            labelotvet_Opred.AppendText($"det(A) = {matrix[0, 0]} * {matrix[1, 1]} * {matrix[2, 2]} + {matrix[0, 1]} * {matrix[1, 2]} * {matrix[2, 0]} + {matrix[0, 2]} * {matrix[1, 0]} * {matrix[2, 1]} - {matrix[0, 2]} * {matrix[1, 1]} * {matrix[2, 0]} - {matrix[0, 1]} * {matrix[1, 0]} * {matrix[2, 2]} - {matrix[0, 0]} * {matrix[1, 2]} * {matrix[2, 1]}\r\n");
            labelotvet_Opred.AppendText($"det(A) = {detA}\r\n");
        }

        private void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                string row = "";
                for (int j = 0; j < 3; j++)
                {
                    row += $"{matrix[i, j]:F0}\t";
                }
                labelotvet_Opred.AppendText(row + "\r\n");
            }
            labelotvet_Opred.AppendText("\r\n");
        }

        private void button_SaveT_Opred_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Получение пути к рабочему столу
            string otvetFilePath = Path.Combine(desktopPath, "Otvet_Opred.txt"); // Путь к файлу "Otvet_Opred.txt" на рабочем столе

            // Проверка, содержит ли labelotvet_Opred текст
            if (!string.IsNullOrEmpty(labelotvet_Opred.Text))
            {
                // Запись текста из labelotvet_Opred в файл "Otvet_Opred.txt" на рабочем столе
                File.WriteAllText(otvetFilePath, labelotvet_Opred.Text);

                MessageBox.Show("Текст успешно сохранен в файле Otvet_Opred.txt на рабочем столе");
            }
            else
            {
                MessageBox.Show("Нет текста для сохранения");
            }
        }

    }
}
