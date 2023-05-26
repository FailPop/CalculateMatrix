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
    public partial class UC_stepen : UserControl
    {
        public UC_stepen()
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

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void degreematrix_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            textBox_StInfo.Visible = false;
            // Получаем числа матрицы из текстовых полей
            double a11 = double.Parse(textBox12.Text);
            double a12 = double.Parse(textBox10.Text);
            double a13 = double.Parse(textBox3.Text);
            double a21 = double.Parse(textBox4.Text);
            double a22 = double.Parse(textBox5.Text);
            double a23 = double.Parse(textBox6.Text);
            double a31 = double.Parse(textBox7.Text);
            double a32 = double.Parse(textBox8.Text);
            double a33 = double.Parse(textBox9.Text);

            // Получаем степень в которую нужно возвести матрицу
            int n = int.Parse(degreematrix.Text);

            // Создаем массив из чисел матрицы
            double[,] matrix = new double[3, 3] { { a11, a12, a13 }, { a21, a22, a23 }, { a31, a32, a33 } };

            // Выводим исходную матрицу
            labelotvet_Stepen.Text = "Исходная матрица:\r\n";
            PrintMatrix(matrix);

            // Возводим матрицу в степень
            double[,] result = matrix;
            for (int i = 2; i <= n; i++)
            {
                result = MatrixMultiplication(result, matrix);
                labelotvet_Stepen.AppendText($"Матрица в степени {i}:\r\n");
                PrintMatrix(result);
            }

            // Выводим результат
            labelotvet_Stepen.AppendText($"Результат возведения матрицы в степень {n}:\r\n");
            PrintMatrix(result);
        }

        // Функция для перемножения двух матриц
        private double[,] MatrixMultiplication(double[,] a, double[,] b)
        {
            double[,] result = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        // Функция для вывода матрицы
        private void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                string row = "";
                for (int j = 0; j < 3; j++)
                {
                    row += $"{matrix[i, j]:F0}\t";
                }
                labelotvet_Stepen.AppendText(row + "\r\n");
            }
            labelotvet_Stepen.AppendText("\r\n");
        }

        private void button_SaveT_Stepen_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Получение пути к рабочему столу
            string otvetFilePath = Path.Combine(desktopPath, "Otvet_Stepen.txt"); // Путь к файлу "Otvet_Stepen.txt" на рабочем столе

            // Проверка, содержит ли labelotvet_Stepen текст
            if (!string.IsNullOrEmpty(labelotvet_Stepen.Text))
            {
                // Запись текста из labelotvet_Stepen в файл "Otvet_Stepen.txt" на рабочем столе
                File.WriteAllText(otvetFilePath, labelotvet_Stepen.Text);

                MessageBox.Show("Текст успешно сохранен в файле Otvet_Stepen.txt на рабочем столе");
            }
            else
            {
                MessageBox.Show("Нет текста для сохранения");
            }
        }

    }
}

