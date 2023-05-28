namespace matrix.UserControls
{
    partial class UC_opred
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_opred));
            labelotvet_Opred = new TextBox();
            buttonSolve = new Button();
            textBox7 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox8 = new TextBox();
            textBox3 = new TextBox();
            textBox9 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            textBox_OpInfo = new TextBox();
            button_SaveT_Opred = new Button();
            SuspendLayout();
            // 
            // labelotvet_Opred
            // 
            labelotvet_Opred.Dock = DockStyle.Right;
            labelotvet_Opred.Location = new Point(360, 0);
            labelotvet_Opred.MinimumSize = new Size(440, 330);
            labelotvet_Opred.Multiline = true;
            labelotvet_Opred.Name = "labelotvet_Opred";
            labelotvet_Opred.ReadOnly = true;
            labelotvet_Opred.ScrollBars = ScrollBars.Both;
            labelotvet_Opred.Size = new Size(440, 350);
            labelotvet_Opred.TabIndex = 41;
            labelotvet_Opred.TextChanged += labelotvet_TextChanged;
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(39, 198);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(75, 23);
            buttonSolve.TabIndex = 39;
            buttonSolve.Text = "Решить";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(39, 97);
            textBox7.MaxLength = 3;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(27, 23);
            textBox7.TabIndex = 35;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 39);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(27, 23);
            textBox1.TabIndex = 27;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 39);
            textBox2.MaxLength = 3;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(27, 23);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(113, 97);
            textBox8.MaxLength = 3;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(27, 23);
            textBox8.TabIndex = 34;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 39);
            textBox3.MaxLength = 3;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(27, 23);
            textBox3.TabIndex = 29;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(188, 97);
            textBox9.MaxLength = 3;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(27, 23);
            textBox9.TabIndex = 33;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(188, 68);
            textBox6.MaxLength = 3;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(27, 23);
            textBox6.TabIndex = 30;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(39, 68);
            textBox4.MaxLength = 3;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(27, 23);
            textBox4.TabIndex = 32;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 68);
            textBox5.MaxLength = 3;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(27, 23);
            textBox5.TabIndex = 31;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(25, 12);
            label1.MaximumSize = new Size(300, 300);
            label1.MinimumSize = new Size(350, 250);
            label1.Name = "label1";
            label1.Size = new Size(350, 250);
            label1.TabIndex = 40;
            // 
            // textBox_OpInfo
            // 
            textBox_OpInfo.Location = new Point(371, 12);
            textBox_OpInfo.MinimumSize = new Size(350, 250);
            textBox_OpInfo.Multiline = true;
            textBox_OpInfo.Name = "textBox_OpInfo";
            textBox_OpInfo.ReadOnly = true;
            textBox_OpInfo.Size = new Size(412, 250);
            textBox_OpInfo.TabIndex = 42;
            textBox_OpInfo.Text = resources.GetString("textBox_OpInfo.Text");
            // 
            // button_SaveT_Opred
            // 
            button_SaveT_Opred.Location = new Point(221, 324);
            button_SaveT_Opred.Name = "button_SaveT_Opred";
            button_SaveT_Opred.Size = new Size(133, 23);
            button_SaveT_Opred.TabIndex = 43;
            button_SaveT_Opred.Text = "Сохранить ответ";
            button_SaveT_Opred.UseVisualStyleBackColor = true;
            button_SaveT_Opred.Click += button_SaveT_Opred_Click;
            // 
            // UC_opred
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_SaveT_Opred);
            Controls.Add(textBox_OpInfo);
            Controls.Add(labelotvet_Opred);
            Controls.Add(buttonSolve);
            Controls.Add(textBox7);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(textBox9);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_opred";
            Size = new Size(800, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox labelotvet_Opred;
        private Button buttonSolve;
        private TextBox textBox7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox8;
        private TextBox textBox3;
        private TextBox textBox9;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox_OpInfo;
        private Button button_SaveT_Opred;
    }
}
