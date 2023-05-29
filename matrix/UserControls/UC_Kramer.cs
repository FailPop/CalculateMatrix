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

        private const double MaxValue = 999;

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
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!double.TryParse(textBox.Text, out double value) || value > 999)
            {
                MessageBox.Show("Ошибка ввода! Введите корректные числа или дополните все числа (не более 999).");
                textBox_KrInfo.Visible = true;
            }
            else
            {
                textBox.Text = value.ToString("F2");
                textBox_KrInfo.Visible = false;
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            labelotvet_Kramer.Text = null;
            textBox_KrInfo.Visible = false;

            double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3;
            double detA, detA1, detA2, detA3, x1, x2, x3;

            if (!double.TryParse(textBox1.Text, out a11) || a11 > 999 ||
                !double.TryParse(textBox2.Text, out a12) || a12 > 999 ||
                !double.TryParse(textBox3.Text, out a13) || a13 > 999 ||
                !double.TryParse(textBox4.Text, out a21) || a21 > 999 ||
                !double.TryParse(textBox5.Text, out a22) || a22 > 999 ||
                !double.TryParse(textBox6.Text, out a23) || a23 > 999 ||
                !double.TryParse(textBox7.Text, out a31) || a31 > 999 ||
                !double.TryParse(textBox8.Text, out a32) || a32 > 999 ||
                !double.TryParse(textBox9.Text, out a33) || a33 > 999 ||
                !double.TryParse(textBox10.Text, out b1) || b1 > 999 ||
                !double.TryParse(textBox11.Text, out b2) || b2 > 999 ||
                !double.TryParse(textBox12.Text, out b3) || b3 > 999)
            {
                MessageBox.Show("Одно или несколько чисел превышает максимальное значение!");
                textBox_KrInfo.Visible = true;
                return;
            }

            detA = a11 * a22 * a33 + a21 * a32 * a13 + a31 * a12 * a23
                   - a13 * a22 * a31 - a23 * a32 * a11 - a33 * a12 * a21;

            if (detA == 0)
            {
                labelotvet_Kramer.Text = "Определитель матрицы равен 0, система уравнений не имеет единственного решения.";
                return;
            }

            detA1 = b1 * a22 * a33 + b2 * a32 * a13 + b3 * a12 * a23
                    - a13 * a22 * b3 - a23 * b2 * a11 - a33 * a12 * b1;

            detA2 = a11 * b2 * a33 + a21 * b3 * a13 + a31 * b1 * a23
                    - a13 * b2 * a31 - b3 * a32 * a11 - a33 * b1 * a21;

            detA3 = a11 * a22 * b3 + a21 * b2 * a13 + b1 * a12 * a23
                    - a13 * a22 * b1 - b2 * a32 * a11 - a33 * a12 * b3;

            string determinants = $"Определители матрицы, где i-ый столбец заменен на столбец свободных членов:\r\n" +
                                  $"det(1) = {detA1:F2}\r\n" +
                                  $"det(2) = {detA2:F2}\r\n" +
                                  $"det(3) = {detA3:F2}\r\n";

            labelotvet_Kramer.AppendText(determinants);

            x1 = detA1 / detA;
            x2 = detA2 / detA;
            x3 = detA3 / detA;

            labelotvet_Kramer.AppendText("Решение:\r\n");
            labelotvet_Kramer.AppendText($"x1 = {x1:F2}\r\n");
            labelotvet_Kramer.AppendText($"x2 = {x2:F2}\r\n");
            labelotvet_Kramer.AppendText($"x3 = {x3:F2}\r\n");
        }

        private void button_SaveT_Kramer_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string otvetFilePath = Path.Combine(desktopPath, "Otvet_Kramer.txt");

            if (!string.IsNullOrEmpty(labelotvet_Kramer.Text))
            {
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
