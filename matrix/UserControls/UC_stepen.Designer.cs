namespace matrix.UserControls
{
    partial class UC_stepen
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
            TextBox textBox11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_stepen));
            labelotvet_Stepen = new TextBox();
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
            degreematrix = new TextBox();
            textBox10 = new TextBox();
            textBox12 = new TextBox();
            textBox_StInfo = new TextBox();
            button_SaveT_Stepen = new Button();
            textBox11 = new TextBox();
            SuspendLayout();
            // 
            // textBox11
            // 
            textBox11.CausesValidation = false;
            textBox11.Enabled = false;
            textBox11.HideSelection = false;
            textBox11.Location = new Point(39, 140);
            textBox11.Name = "textBox11";
            textBox11.ShortcutsEnabled = false;
            textBox11.Size = new Size(134, 23);
            textBox11.TabIndex = 55;
            textBox11.Text = "Возвести в степень:";
            // 
            // labelotvet_Stepen
            // 
            labelotvet_Stepen.Dock = DockStyle.Right;
            labelotvet_Stepen.Location = new Point(360, 0);
            labelotvet_Stepen.MinimumSize = new Size(440, 330);
            labelotvet_Stepen.Multiline = true;
            labelotvet_Stepen.Name = "labelotvet_Stepen";
            labelotvet_Stepen.ScrollBars = ScrollBars.Both;
            labelotvet_Stepen.Size = new Size(440, 350);
            labelotvet_Stepen.TabIndex = 53;
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(39, 198);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(75, 23);
            buttonSolve.TabIndex = 51;
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
            textBox7.TabIndex = 50;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(27, 23);
            textBox1.TabIndex = 42;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(27, 23);
            textBox2.TabIndex = 43;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(113, 97);
            textBox8.MaxLength = 3;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(27, 23);
            textBox8.TabIndex = 49;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 39);
            textBox3.MaxLength = 3;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(27, 23);
            textBox3.TabIndex = 44;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(188, 97);
            textBox9.MaxLength = 3;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(27, 23);
            textBox9.TabIndex = 48;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(188, 68);
            textBox6.MaxLength = 3;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(27, 23);
            textBox6.TabIndex = 45;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(39, 68);
            textBox4.MaxLength = 3;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(27, 23);
            textBox4.TabIndex = 47;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 68);
            textBox5.MaxLength = 3;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(27, 23);
            textBox5.TabIndex = 46;
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
            label1.TabIndex = 52;
            // 
            // degreematrix
            // 
            degreematrix.Location = new Point(39, 169);
            degreematrix.MaxLength = 1;
            degreematrix.Name = "degreematrix";
            degreematrix.Size = new Size(27, 23);
            degreematrix.TabIndex = 54;
            degreematrix.TextChanged += degreematrix_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(113, 39);
            textBox10.MaxLength = 3;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(27, 23);
            textBox10.TabIndex = 43;
            textBox10.TextChanged += textBox2_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(39, 39);
            textBox12.MaxLength = 3;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(27, 23);
            textBox12.TabIndex = 42;
            textBox12.TextChanged += textBox1_TextChanged;
            // 
            // textBox_StInfo
            // 
            textBox_StInfo.Location = new Point(371, 12);
            textBox_StInfo.MinimumSize = new Size(350, 250);
            textBox_StInfo.Multiline = true;
            textBox_StInfo.Name = "textBox_StInfo";
            textBox_StInfo.ReadOnly = true;
            textBox_StInfo.Size = new Size(412, 250);
            textBox_StInfo.TabIndex = 56;
            textBox_StInfo.Text = resources.GetString("textBox_StInfo.Text");
            // 
            // button_SaveT_Stepen
            // 
            button_SaveT_Stepen.Location = new Point(221, 324);
            button_SaveT_Stepen.Name = "button_SaveT_Stepen";
            button_SaveT_Stepen.Size = new Size(133, 23);
            button_SaveT_Stepen.TabIndex = 57;
            button_SaveT_Stepen.Text = "Сохранить ответ";
            button_SaveT_Stepen.UseVisualStyleBackColor = true;
            button_SaveT_Stepen.Click += button_SaveT_Stepen_Click;
            // 
            // UC_stepen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_SaveT_Stepen);
            Controls.Add(textBox_StInfo);
            Controls.Add(textBox11);
            Controls.Add(degreematrix);
            Controls.Add(labelotvet_Stepen);
            Controls.Add(buttonSolve);
            Controls.Add(textBox7);
            Controls.Add(textBox12);
            Controls.Add(textBox10);
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
            Name = "UC_stepen";
            Size = new Size(800, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox labelotvet_Stepen;
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
        private TextBox degreematrix;
        private TextBox textBox10;
        private TextBox textBox12;
        private TextBox textBox_StInfo;
        private Button button_SaveT_Stepen;
    }
}
