using System.Reflection;

namespace matrix.UserControls
{
    partial class UC_about
    {
        string versiontextbox = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);

        public string versionshow;



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
            label1 = new Label();
            button_Ru = new Button();
            button_En = new Button();
            textBox_Version_In = new TextBox();
            button_Update_Version = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(3, 0);
            label1.MinimumSize = new Size(300, 330);
            label1.Name = "label1";
            label1.Size = new Size(300, 330);
            label1.TabIndex = 0;
            label1.Text = "Разработчики:\r\nБондаренко Екатерина\r\nКовалев Сергей\r\nМешков Василий\r\nМешков Григорий\r\nЕремченко Кирилл\r\n\r\nBeta тестер:\r\nvk.com/torwerka";
            // 
            // button_Ru
            // 
            button_Ru.Location = new Point(309, 19);
            button_Ru.Name = "button_Ru";
            button_Ru.Size = new Size(33, 23);
            button_Ru.TabIndex = 1;
            button_Ru.Text = "Ru";
            button_Ru.UseVisualStyleBackColor = true;
            button_Ru.Click += button_Ru_Click;
            // 
            // button_En
            // 
            button_En.Location = new Point(348, 19);
            button_En.Name = "button_En";
            button_En.Size = new Size(33, 23);
            button_En.TabIndex = 2;
            button_En.Text = "En";
            button_En.UseVisualStyleBackColor = true;
            button_En.Click += button_En_Click;
            // 
            // textBox_Version_In
            // 
            textBox_Version_In.Location = new Point(429, 56);
            textBox_Version_In.Name = "textBox_Version_In";
            textBox_Version_In.ReadOnly = true;
            textBox_Version_In.Size = new Size(86, 23);
            textBox_Version_In.TabIndex = 3;
            textBox_Version_In.TextChanged += textBox_Version_In_TextChanged;
            // 
            // button_Update_Version
            // 
            button_Update_Version.BackColor = Color.FromArgb(128, 255, 128);
            button_Update_Version.ForeColor = SystemColors.ControlText;
            button_Update_Version.Location = new Point(309, 56);
            button_Update_Version.Name = "button_Update_Version";
            button_Update_Version.Size = new Size(113, 23);
            button_Update_Version.TabIndex = 4;
            button_Update_Version.Text = "Обновление";
            button_Update_Version.UseVisualStyleBackColor = false;
            button_Update_Version.Click += button_Update_Version_Click;
            // 
            // UC_about
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Update_Version);
            Controls.Add(textBox_Version_In);
            Controls.Add(button_En);
            Controls.Add(button_Ru);
            Controls.Add(label1);
            Name = "UC_about";
            Size = new Size(800, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Ru;
        private Button button_En;
        private TextBox textBox_Version_In;
        private Button button_Update_Version;
    }
}
