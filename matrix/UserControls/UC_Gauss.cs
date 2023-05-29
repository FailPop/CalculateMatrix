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
            if (!double.TryParse(textBox1.Text, out matrix[0, 0]) ||
                !double.TryParse(textBox2.Text, out matrix[0, 1]) ||
                !double.TryParse(textBox3.Text, out matrix[0, 2]) ||
                !double.TryParse(textBox4.Text, out matrix[0, 3]) ||
                !double.TryParse(textBox5.Text, out matrix[1, 0]) ||
                !double.TryParse(textBox6.Text, out matrix[1, 1]) ||
                !double.TryParse(textBox7.Text, out matrix[1, 2]) ||
                !double.TryParse(textBox8.Text, out matrix[1, 3]) ||
                !double.TryParse(textBox9.Text, out matrix[2, 0]) ||
                !double.TryParse(textBox10.Text, out matrix[2, 1]) ||
                !double.TryParse(textBox11.Text, out matrix[2, 2]) ||
                !double.TryParse(textBox12.Text, out matrix[2, 3]))
            {
                MessageBox.Show("Ошибка ввода! Введите корректные числа.");
                textBox_GsInfo.Visible = true;
                return;
            }

            // Вывод исходной матрицы
            labelotvet_Gauss.Text = "Исходная матрица:\r\n";
            PrintMatrix(matrix);

            if (matrix[0, 0] == 0 || matrix[1, 1] == 0 || matrix[2, 2] == 0)
            {
                MessageBox.Show("Матрица не имеет решения!");
                return;
            }

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
                for (int i = k - 1; i >= 0; i--)
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

            // Нормализация решения
            for (int i = 0; i < 3; i++)
            {
                double coeff = 1 / matrix[i, i];
                labelotvet_Gauss.AppendText($"Делим строку {i + 1} на {matrix[i, i]}\r\n");
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = matrix[i, j] * coeff;
                }
            }
            // Проверка, что матрица уже решена
            if (matrix[0, 0] != 1 || matrix[1, 1] != 1 || matrix[2, 2] != 1)
            {
                MessageBox.Show("Матрица не решена!");
                return;
            }

            labelotvet_Gauss.AppendText("====================\r\n");
            PrintMatrix(matrix);

            // Вывод решения
            labelotvet_Gauss.AppendText("Решение:\r\n");
            for (int i = 0; i < 3; i++)
            {
                labelotvet_Gauss.AppendText($"x{i + 1} = {matrix[i, 3]:F2}\r\n");
            }
        }

        // Вывод измененной матрицы
        private void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                string row = "";
                for (int j = 0; j < 4; j++)
                {
                    // Если число дробное
                    if (matrix[i, j] % 1 != 0)
                    {
                        // Находим НОД числителя и знаменателя
                        double numerator = matrix[i, j] * 1000000;
                        double denominator = 1000000;
                        while (denominator > 1)
                        {
                            double remainder = numerator % denominator;
                            numerator = denominator;
                            denominator = remainder;
                        }
                        int gcd = (int)numerator;

                        // Делим числитель и знаменатель на НОД
                        int newNumerator = (int)(matrix[i, j] * 1000000 / gcd);
                        int newDenominator = 1000000 / gcd;

                        // Форматируем дробь
                        row += $"{newNumerator}/{newDenominator}\t";
                    }
                    // Если число целое
                    else
                    {
                        row += $"{matrix[i, j]:F0}\t";
                    }
                }
                labelotvet_Gauss.AppendText(row + "\r\n");
            }
            labelotvet_Gauss.AppendText("\r\n");
        }


        private void labenotvet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_SaveT_Gauss_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Получение пути к рабочему столу
            string otvetFilePath = Path.Combine(desktopPath, "Otvet_Gauss.txt"); // Путь к файлу "Otvet_Gauss.txt" на рабочем столе

            // Проверка, содержит ли labelotvet_Gauss текст
            if (!string.IsNullOrEmpty(labelotvet_Gauss.Text))
            {
                // Запись текста из labelotvet_Gauss в файл "Otvet_Gauss.txt" на рабочем столе
                File.WriteAllText(otvetFilePath, labelotvet_Gauss.Text);

                MessageBox.Show("Текст успешно сохранен в файле Otvet_Gauss.txt на рабочем столе");
            }
            else
            {
                MessageBox.Show("Нет текста для сохранения");
            }
        }

    }
}
