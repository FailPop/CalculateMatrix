namespace matrix.UserControls
{
    partial class UC_Welcome
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            welcome_label = new Label();
            welcome_infolabel1 = new Label();
            welcome_infolabel2 = new Label();
            welcome_infolabel3 = new Label();
            welcome_infolabel4 = new Label();
            welcome_infolabel5 = new Label();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            welcome_label.Location = new Point(12, 317);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new Size(606, 21);
            welcome_label.TabIndex = 0;
            welcome_label.Text = "matrix - универсальное приложение для решения математических матриц";
            // 
            // welcome_infolabel1
            // 
            welcome_infolabel1.AutoSize = true;
            welcome_infolabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            welcome_infolabel1.Location = new Point(12, 15);
            welcome_infolabel1.Name = "welcome_infolabel1";
            welcome_infolabel1.Size = new Size(716, 32);
            welcome_infolabel1.TabIndex = 1;
            welcome_infolabel1.Text = "Приложение поддерживает решение матриц при помощи";
            // 
            // welcome_infolabel2
            // 
            welcome_infolabel2.AutoSize = true;
            welcome_infolabel2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            welcome_infolabel2.Location = new Point(9, 47);
            welcome_infolabel2.Name = "welcome_infolabel2";
            welcome_infolabel2.Size = new Size(482, 47);
            welcome_infolabel2.TabIndex = 2;
            welcome_infolabel2.Text = "Методов Гаусса и Крамера";
            // 
            // welcome_infolabel3
            // 
            welcome_infolabel3.AutoSize = true;
            welcome_infolabel3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            welcome_infolabel3.Location = new Point(10, 94);
            welcome_infolabel3.Name = "welcome_infolabel3";
            welcome_infolabel3.Size = new Size(168, 47);
            welcome_infolabel3.TabIndex = 3;
            welcome_infolabel3.Text = "А так же";
            // 
            // welcome_infolabel4
            // 
            welcome_infolabel4.AutoSize = true;
            welcome_infolabel4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            welcome_infolabel4.Location = new Point(12, 141);
            welcome_infolabel4.Name = "welcome_infolabel4";
            welcome_infolabel4.Size = new Size(358, 47);
            welcome_infolabel4.TabIndex = 4;
            welcome_infolabel4.Text = "Умножение матриц";
            // 
            // welcome_infolabel5
            // 
            welcome_infolabel5.AutoSize = true;
            welcome_infolabel5.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            welcome_infolabel5.Location = new Point(12, 188);
            welcome_infolabel5.Name = "welcome_infolabel5";
            welcome_infolabel5.Size = new Size(486, 47);
            welcome_infolabel5.TabIndex = 5;
            welcome_infolabel5.Text = "Вычисление определителя";
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.FillColor = Color.FromArgb(48, 100, 255);
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(87, 142, 250);
            guna2CustomGradientPanel1.Location = new Point(0, 3);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(800, 5);
            guna2CustomGradientPanel1.TabIndex = 6;
            // 
            // UC_Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(welcome_infolabel5);
            Controls.Add(welcome_infolabel4);
            Controls.Add(welcome_infolabel3);
            Controls.Add(welcome_infolabel2);
            Controls.Add(welcome_infolabel1);
            Controls.Add(welcome_label);
            Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_Welcome";
            Size = new Size(800, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome_label;
        private Label welcome_infolabel1;
        private Label welcome_infolabel2;
        private Label welcome_infolabel3;
        private Label welcome_infolabel4;
        private Label welcome_infolabel5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}
