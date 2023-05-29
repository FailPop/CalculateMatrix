using Npgsql;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace matrix.UserControls
{
    public partial class UC_about : UserControl
    {

        private const string connectionString = "Server=194.169.163.175;Port=5432;Database=mvas;User Id=mvas;Password=qwe123;";
        public string versiontxtfile;



        public UC_about()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void button_Ru_Click(object sender, EventArgs e)
        {
            string message = "Вы уже используете русский язык в приложении. Будьте внимательнее...";
            MessageBox.Show(message, "Сообщение");
        }

        private void button_En_Click(object sender, EventArgs e)
        {
            string message = "В настоящее время данная функция не работает. Мы ведем разработку данной функции. Мы плохо знаем английский язык, но стараемся его выучить и перевести данное приложение на него. Help pls...";
            MessageBox.Show(message, "Сообщение");
        }

        private void textBox_Version_In_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        // Запуск функции обновления
        private void button_Update_Version_Click(object sender, EventArgs e)
        {
            UpdateVersionFromDatabase();
        }

        private void UpdateVersionFromDatabase()
        {
            try
            {
                // Подключение к базе данных
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Запрос для получения значения из столбца app_version
                    string query = "SELECT app_version FROM version WHERE id = 1;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Получение значения из базы данных
                        string dbVersion = command.ExecuteScalar()?.ToString();

                        if (dbVersion != null)
                        {
                            // Чтение значения из файла version.txt
                            string versionFilePath = Path.Combine(Application.StartupPath, "version.txt");

                            string fileContent = File.ReadAllText(versionFilePath);

                            // Сравнение значения из базы данных и файла
                            if (dbVersion != fileContent)
                            {
                                // Обновление значения в файле
                                File.WriteAllText(versionFilePath, dbVersion);

                                // Присваивание нового значения переменной versionapptxt
                                versiontxtfile = dbVersion;

                                // Вывод сообщения об успешном обновлении
                                MessageBox.Show("Файл версии успешно обновлен.", "Успех");
                                Application.Restart();

                            }
                            else
                            {
                                MessageBox.Show("У вас актуальная версия приложения.", "Информация");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не удалось обновить версию приложения.", "Ошибка");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении версии: " + ex.Message, "Ошибка");
            }
        }
    }
}
