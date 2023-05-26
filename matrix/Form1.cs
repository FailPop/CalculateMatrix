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

        private void icon_Click(object sender, EventArgs e)
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
            UC_about uc = new UC_about();
            addUserControl(uc);
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}