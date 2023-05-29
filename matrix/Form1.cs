using matrix.UserControls;
using Npgsql;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {

        #region
        public Form1()
        {
            InitializeComponent();
            UC_Welcome welcome = new UC_Welcome();
            addUserControl(welcome);
        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            tabsPanel.Controls.Clear();
            tabsPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void gaussBtn_Click(object sender, EventArgs e)
        {
            UC_Gauss uc = new UC_Gauss();
            addUserControl(uc);
        }

        private void kramerBtn_Click(object sender, EventArgs e)
        {
            UC_Kramer uc = new UC_Kramer();
            addUserControl(uc);
        }

        private void opredBtn_Click(object sender, EventArgs e)
        {
            UC_opred uc = new UC_opred();
            addUserControl(uc);
        }

        private void stepenBtn_Click(object sender, EventArgs e)
        {
            UC_stepen uc = new UC_stepen();
            addUserControl(uc);
        }

        private void tabsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_collapse_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string versionFilePath = Path.Combine(Application.StartupPath, "version.txt");

            // Проверка файла на значение в файле версии
            if (File.Exists(versionFilePath) && new FileInfo(versionFilePath).Length < 6 || !File.ReadAllText(versionFilePath).Contains("Version"))
            {
                string appVersion = GetAppVersionFromDatabase();

                if (!string.IsNullOrEmpty(appVersion))
                {
                    // Запись в файл версии с бд
                    WriteVersionToFile(versionFilePath, appVersion);
                }
            }


            UC_about uc = new UC_about();
            addUserControl(uc);
        }
        #endregion
        
        //version fix on application startup
        private string GetAppVersionFromDatabase()
        {
            string connectionString = "Server=194.169.163.175;Port=5432;Database=mvas;User Id=mvas;Password=qwe123;";
            string appVersion = string.Empty;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT app_version FROM version", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appVersion = reader.GetString(0);
                        }
                    }
                }
            }

            return appVersion;
        }
        // Функция записи в файл
        private void WriteVersionToFile(string filePath, string appVersion)
        {
            File.WriteAllText(filePath, appVersion);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}