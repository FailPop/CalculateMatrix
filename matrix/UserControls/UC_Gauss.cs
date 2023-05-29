using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace matrix.UserControls
{
    public partial class UC_Gauss : UserControl
    {

        private const double MaxValue = 999;

        public UC_Gauss()
        {
            InitializeComponent();
        }
        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            // Очистка поля ответа
            labelotvet_Gauss.Text = null;

            textBox_GsInfo.Visible = false;
            double[,] matrix = new double[3, 4];
            // Считывание данных из полей ввода и проверка на валидность
            if (!TryParseDouble(textBox1.Text, out matrix[0, 0]) ||
                !TryParseDouble(textBox2.Text, out matrix[0, 1]) ||
                !TryParseDouble(textBox3.Text, out matrix[0, 2]) ||
                !TryParseDouble(textBox4.Text, out matrix[0, 3]) ||
                !TryParseDouble(textBox5.Text, out matrix[1, 0]) ||
                !TryParseDouble(textBox6.Text, out matrix[1, 1]) ||
                !TryParseDouble(textBox7.Text, out matrix[1, 2]) ||
                !TryParseDouble(textBox8.Text, out matrix[1, 3]) ||
                !TryParseDouble(textBox9.Text, out matrix[2, 0]) ||
                !TryParseDouble(textBox10.Text, out matrix[2, 1]) ||
                !TryParseDouble(textBox11.Text, out matrix[2, 2]) ||
                !TryParseDouble(textBox12.Text, out matrix[2, 3]))
            {
                MessageBox.Show("Ошибка ввода! Введите корректные числа.");
                textBox_GsInfo.Visible = true;
                return;
            }

            // Проверка на возможность правильного решения
            if (!IsSolvable(matrix))
            {
                MessageBox.Show("Матрица не имеет решения или имеет бесконечное количество решений!");
                return;
            }

            // Проверка на максимальное значение переменных
            if (!IsValidMatrix(matrix))
            {
                MessageBox.Show("Одно или несколько чисел превышает максимальное значение!");
                return;
            }

            // Вывод исходной матрицы
            labelotvet_Gauss.Text = "Исходная матрица:\r\n";
            PrintMatrix(matrix);

            // Прямой ход метода Гаусса
            for (int k = 0; k < 3; k++)
            {
                for (int i = k + 1; i < 3; i++)
                {
                    double coeff = matrix[i, k] / matrix[k, k];
                    labelotvet_Gauss.AppendText($"Вычитаем {coeff:F2} * строку {k + 1} из строки {i + 1}\r\n");
                    for (int j = k; j < 4; j++)
                    {
                        matrix[i, j] = matrix[i, j] - coeff * matrix[k, j];
                    }
                }
                labelotvet_Gauss.AppendText("====================\r\n");
                PrintMatrix(matrix);
            }

            // Обратный ход метода Гаусса
            for (int k = 2; k >= 0; k--)
            {
                double value = matrix[k, 3];
                for (int j = k + 1; j < 3; j++)
                {
                    value = value - matrix[k, j] * matrix[j, 3];
                }
                matrix[k, 3] = value / matrix[k, k];
            }

            // Вывод решения
            labelotvet_Gauss.AppendText("Решение:\r\n");
            labelotvet_Gauss.AppendText($"x = {matrix[0, 3]:F2}\r\n");
            labelotvet_Gauss.AppendText($"y = {matrix[1, 3]:F2}\r\n");
            labelotvet_Gauss.AppendText($"z = {matrix[2, 3]:F2}");
        }

        private bool TryParseDouble(string text, out double value)
        {
            if (double.TryParse(text, out value))
            {
                // Проверка на максимальное значение переменной
                if (value > MaxValue)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private bool IsSolvable(double[,] matrix)
        {
            double detA = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                          matrix[1, 0] * matrix[2, 1] * matrix[0, 2] +
                          matrix[2, 0] * matrix[0, 1] * matrix[1, 2] -
                          matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                          matrix[1, 2] * matrix[2, 1] * matrix[0, 0] -
                          matrix[2, 2] * matrix[0, 1] * matrix[1, 0];
            return Math.Abs(detA) > double.Epsilon;
        }

        private bool IsValidMatrix(double[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] > MaxValue)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    labelotvet_Gauss.AppendText(matrix[i, j].ToString("F3") + "\t");
                }
                labelotvet_Gauss.AppendText("\r\n");
            }
        }

        private void button_SaveT_Gauss_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Otvet_Gauss.txt", labelotvet_Gauss.Text);
                MessageBox.Show("Файл сохранен на рабочем столе!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

    }
}
