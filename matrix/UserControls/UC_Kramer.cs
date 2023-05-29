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
    public partial class UC_Kramer : UserControl
    {
        public UC_Kramer()
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            // Очистка поля ответа
            labelotvet_Kramer.Text = null;

            textBox_KrInfo.Visible = false;
            double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3;
            double detA, detA1, detA2, detA3, x1, x2, x3;

            try
            {
                a11 = double.Parse(textBox1.Text);
                a12 = double.Parse(textBox2.Text);
                a13 = double.Parse(textBox3.Text);
                a21 = double.Parse(textBox4.Text);
                a22 = double.Parse(textBox5.Text);
                a23 = double.Parse(textBox6.Text);
                a31 = double.Parse(textBox7.Text);
                a32 = double.Parse(textBox8.Text);
                a33 = double.Parse(textBox9.Text);
                b1 = double.Parse(textBox10.Text);
                b2 = double.Parse(textBox11.Text);
                b3 = double.Parse(textBox12.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода! Введите корректные числа или допишите все числа.");
                textBox_KrInfo.Visible = true;
                return;
            }

            // Вычисление определителя матрицы
            detA = a11 * a22 * a33 + a21 * a32 * a13 + a31 * a12 * a23
                 - a13 * a22 * a31 - a23 * a32 * a11 - a33 * a12 * a21;

            if (detA == 0)
            {
                labelotvet_Kramer.Text = "Определитель матрицы равен 0, система уравнений не имеет единственного решения.";
                return;
            }

            // Вычисление определителей матрицы, где i-ый столбец заменен на столбец свободных членов
            detA1 = b1 * a22 * a33 + b2 * a32 * a13 + b3 * a12 * a23
                  - a13 * a22 * b3 - a23 * b2 * a11 - a33 * a12 * b1;

            detA2 = a11 * b2 * a33 + a21 * b3 * a13 + a31 * b1 * a23
                  - a13 * b2 * a31 - b3 * a32 * a11 - a33 * b1 * a21;

            detA3 = a11 * a22 * b3 + a21 * b2 * a13 + b1 * a12 * a23
                  - a13 * a22 * b1 - b2 * a32 * a11 - a33 * a12 * b3;

            // Вывод определителей матрицы
            labelotvet_Kramer.AppendText("Определители матрицы, где i-ый столбец заменен на столбец свободных членов:\r\n");
            labelotvet_Kramer.AppendText($"det(1) = {detA1:F2}\r\n");
            labelotvet_Kramer.AppendText($"det(2) = {detA2:F2}\r\n");
            labelotvet_Kramer.AppendText($"det(3) = {detA3:F2}\r\n");

            // Вычисление решений системы
            x1 = detA1 / detA;
            x2 = detA2 / detA;
            x3 = detA3 / detA;

            // Вывод решения
            labelotvet_Kramer.AppendText("Решение:\r\n");
            labelotvet_Kramer.AppendText($"x1 = {x1:F2}\r\n");
            labelotvet_Kramer.AppendText($"x2 = {x2:F2}\r\n");
            labelotvet_Kramer.AppendText($"x3 = {x3:F2}\r\n");
        }

        private void labelotvet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_SaveT_Kramer_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Получение пути к рабочему столу
            string otvetFilePath = Path.Combine(desktopPath, "Otvet_Kramer.txt"); // Путь к файлу "Otvet_Kramer.txt" на рабочем столе

            // Проверка, содержит ли labelotvet_Kramer текст
            if (!string.IsNullOrEmpty(labelotvet_Kramer.Text))
            {
                // Запись текста из labelotvet_Kramer в файл "Otvet_Kramer.txt" на рабочем столе
                File.WriteAllText(otvetFilePath, labelotvet_Kramer.Text);

                MessageBox.Show("Текст успешно сохранен в файле Otvet_Kramer.txt на рабочем столе");
            }
            else
            {
                MessageBox.Show("Нет текста для сохранения");
            }
        }

    }
}
