using System.Reflection;

namespace matrix
{

    partial class Form1
    {
        private string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString(2); // Текущая версия из переменной curver

        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;
        // Буферизация от мерцания меню
        protected override CreateParams CreateParams
        {
            get
            {
                if (originalExStyle == -1)
                    originalExStyle = base.CreateParams.ExStyle;

                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }

        public void TurnOffFormLevelDoubleBuffering()
        {
            enableFormLevelDoubleBuffering = false;
            this.MaximizeBox = true;
        }
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            icon = new PictureBox();
            label1 = new Label();
            topBarDragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            topBar = new Panel();
            button1 = new Button();
            button_collapse = new Button();
            button_exit = new Button();
            underTopBar = new Panel();
            stepenBtn = new Guna.UI2.WinForms.Guna2Button();
            opredBtn = new Guna.UI2.WinForms.Guna2Button();
            kramerBtn = new Guna.UI2.WinForms.Guna2Button();
            gaussBtn = new Guna.UI2.WinForms.Guna2Button();
            tabsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            topBar.SuspendLayout();
            underTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // icon
            // 
            icon.Image = Properties.Resources.matrix;
            icon.Location = new Point(8, 9);
            icon.Name = "icon";
            icon.Size = new Size(32, 33);
            icon.TabIndex = 0;
            icon.TabStop = false;
            icon.Click += icon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 13);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 2;
            label1.Text = "matrix";
            // 
            // topBarDragControl
            // 
            topBarDragControl.DockIndicatorTransparencyValue = 0.6D;
            topBarDragControl.TargetControl = topBar;
            topBarDragControl.TransparentWhileDrag = false;
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(41, 106, 227);
            topBar.Controls.Add(button1);
            topBar.Controls.Add(button_collapse);
            topBar.Controls.Add(button_exit);
            topBar.Controls.Add(icon);
            topBar.Controls.Add(label1);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(800, 50);
            topBar.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.information2;
            button1.Location = new Point(657, -1);
            button1.Name = "button1";
            button1.Size = new Size(33, 35);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_collapse
            // 
            button_collapse.Image = Properties.Resources.minus_sign;
            button_collapse.Location = new Point(739, 0);
            button_collapse.Name = "button_collapse";
            button_collapse.Size = new Size(29, 23);
            button_collapse.TabIndex = 7;
            button_collapse.UseVisualStyleBackColor = true;
            button_collapse.Click += button_collapse_Click_1;
            // 
            // button_exit
            // 
            button_exit.Image = Properties.Resources.reject;
            button_exit.Location = new Point(774, 0);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(26, 23);
            button_exit.TabIndex = 6;
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // underTopBar
            // 
            underTopBar.Controls.Add(stepenBtn);
            underTopBar.Controls.Add(opredBtn);
            underTopBar.Controls.Add(kramerBtn);
            underTopBar.Controls.Add(gaussBtn);
            underTopBar.Dock = DockStyle.Top;
            underTopBar.Location = new Point(0, 50);
            underTopBar.Name = "underTopBar";
            underTopBar.Size = new Size(800, 50);
            underTopBar.TabIndex = 4;
            // 
            // stepenBtn
            // 
            stepenBtn.BackColor = Color.Transparent;
            stepenBtn.BorderRadius = 10;
            stepenBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            stepenBtn.CheckedState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            stepenBtn.CheckedState.FillColor = Color.WhiteSmoke;
            stepenBtn.CustomBorderColor = Color.Silver;
            stepenBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            stepenBtn.CustomizableEdges = customizableEdges1;
            stepenBtn.DisabledState.BorderColor = Color.DarkGray;
            stepenBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            stepenBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stepenBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stepenBtn.Dock = DockStyle.Left;
            stepenBtn.FillColor = Color.WhiteSmoke;
            stepenBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            stepenBtn.ForeColor = Color.Black;
            stepenBtn.HoverState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            stepenBtn.Location = new Point(600, 0);
            stepenBtn.Margin = new Padding(0);
            stepenBtn.Name = "stepenBtn";
            stepenBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            stepenBtn.Size = new Size(200, 50);
            stepenBtn.TabIndex = 3;
            stepenBtn.Text = "Степень";
            stepenBtn.Click += stepenBtn_Click;
            // 
            // opredBtn
            // 
            opredBtn.BackColor = Color.Transparent;
            opredBtn.BorderRadius = 10;
            opredBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            opredBtn.CheckedState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            opredBtn.CheckedState.FillColor = Color.WhiteSmoke;
            opredBtn.CustomBorderColor = Color.Silver;
            opredBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            opredBtn.CustomizableEdges = customizableEdges3;
            opredBtn.DisabledState.BorderColor = Color.DarkGray;
            opredBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            opredBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            opredBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            opredBtn.Dock = DockStyle.Left;
            opredBtn.FillColor = Color.WhiteSmoke;
            opredBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            opredBtn.ForeColor = Color.Black;
            opredBtn.HoverState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            opredBtn.Location = new Point(400, 0);
            opredBtn.Margin = new Padding(0);
            opredBtn.Name = "opredBtn";
            opredBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            opredBtn.Size = new Size(200, 50);
            opredBtn.TabIndex = 2;
            opredBtn.Text = "Определитель";
            opredBtn.Click += opredBtn_Click;
            // 
            // kramerBtn
            // 
            kramerBtn.BackColor = Color.Transparent;
            kramerBtn.BorderRadius = 10;
            kramerBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            kramerBtn.CheckedState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            kramerBtn.CheckedState.FillColor = Color.WhiteSmoke;
            kramerBtn.CustomBorderColor = Color.Silver;
            kramerBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            kramerBtn.CustomizableEdges = customizableEdges5;
            kramerBtn.DisabledState.BorderColor = Color.DarkGray;
            kramerBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            kramerBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            kramerBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            kramerBtn.Dock = DockStyle.Left;
            kramerBtn.FillColor = Color.WhiteSmoke;
            kramerBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kramerBtn.ForeColor = Color.Black;
            kramerBtn.HoverState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            kramerBtn.Location = new Point(200, 0);
            kramerBtn.Margin = new Padding(0);
            kramerBtn.Name = "kramerBtn";
            kramerBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            kramerBtn.Size = new Size(200, 50);
            kramerBtn.TabIndex = 1;
            kramerBtn.Text = "Крамер";
            kramerBtn.Click += kramerBtn_Click;
            // 
            // gaussBtn
            // 
            gaussBtn.BackColor = Color.Transparent;
            gaussBtn.BorderRadius = 10;
            gaussBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            gaussBtn.CheckedState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            gaussBtn.CheckedState.FillColor = Color.WhiteSmoke;
            gaussBtn.CustomBorderColor = Color.Silver;
            gaussBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            gaussBtn.CustomizableEdges = customizableEdges7;
            gaussBtn.DisabledState.BorderColor = Color.DarkGray;
            gaussBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            gaussBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gaussBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gaussBtn.Dock = DockStyle.Left;
            gaussBtn.FillColor = Color.WhiteSmoke;
            gaussBtn.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            gaussBtn.ForeColor = Color.Black;
            gaussBtn.HoverState.CustomBorderColor = Color.FromArgb(41, 106, 227);
            gaussBtn.Location = new Point(0, 0);
            gaussBtn.Margin = new Padding(0);
            gaussBtn.Name = "gaussBtn";
            gaussBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gaussBtn.Size = new Size(200, 50);
            gaussBtn.TabIndex = 0;
            gaussBtn.Text = "Гаусс";
            gaussBtn.Click += gaussBtn_Click;
            // 
            // tabsPanel
            // 
            tabsPanel.Dock = DockStyle.Fill;
            tabsPanel.Location = new Point(0, 100);
            tabsPanel.Name = "tabsPanel";
            tabsPanel.Size = new Size(800, 350);
            tabsPanel.TabIndex = 5;
            tabsPanel.Paint += tabsPanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tabsPanel);
            Controls.Add(underTopBar);
            Controls.Add(topBar);
            Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            underTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl topBarDragControl;
        private Label label1;
        private PictureBox icon;
        private Panel topBar;
        private Panel underTopBar;
        private Guna.UI2.WinForms.Guna2Button gaussBtn;
        private Guna.UI2.WinForms.Guna2Button stepenBtn;
        private Guna.UI2.WinForms.Guna2Button opredBtn;
        private Guna.UI2.WinForms.Guna2Button kramerBtn;
        private Panel tabsPanel;
        private Button button_exit;
        private Button button_collapse;
        private Button button1;
    }
}