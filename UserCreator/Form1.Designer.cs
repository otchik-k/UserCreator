namespace UserCreator
{
    partial class Form1
    {
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
            label1 = new Label();
            textBoxGroupNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxOU = new TextBox();
            buttonCreate = new Button();
            label5 = new Label();
            textBoxPass = new TextBox();
            textBoxNetDiskAdress = new TextBox();
            label6 = new Label();
            numericUpDownNewUserStartNumber = new NumericUpDown();
            numericUpDownNewGroupCounter = new NumericUpDown();
            textBoxAdminLogin = new TextBox();
            textBoxAdminPass = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxHomeDrive = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewUserStartNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewGroupCounter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер группы";
            // 
            // textBoxGroupNumber
            // 
            textBoxGroupNumber.Location = new Point(290, 41);
            textBoxGroupNumber.Name = "textBoxGroupNumber";
            textBoxGroupNumber.Size = new Size(498, 23);
            textBoxGroupNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(212, 15);
            label2.TabIndex = 2;
            label2.Text = "Количество учетных записей группы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(195, 15);
            label3.TabIndex = 3;
            label3.Text = "Стартовый номер учетной записи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(272, 15);
            label4.TabIndex = 6;
            label4.Text = "OU в которую будут помещены учетные записи";
            // 
            // textBoxOU
            // 
            textBoxOU.Location = new Point(290, 12);
            textBoxOU.Name = "textBoxOU";
            textBoxOU.Size = new Size(498, 23);
            textBoxOU.TabIndex = 8;
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.Location = new Point(12, 318);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(776, 170);
            buttonCreate.TabIndex = 11;
            buttonCreate.Text = "СОЗДАТЬ!";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 12;
            label5.Text = "Стартовый пароль";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(290, 128);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(498, 23);
            textBoxPass.TabIndex = 13;
            // 
            // textBoxNetDiskAdress
            // 
            textBoxNetDiskAdress.Location = new Point(290, 157);
            textBoxNetDiskAdress.Name = "textBoxNetDiskAdress";
            textBoxNetDiskAdress.Size = new Size(498, 23);
            textBoxNetDiskAdress.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 160);
            label6.Name = "label6";
            label6.Size = new Size(174, 15);
            label6.TabIndex = 15;
            label6.Text = "Расположение сетевого диска";
            // 
            // numericUpDownNewUserStartNumber
            // 
            numericUpDownNewUserStartNumber.Location = new Point(290, 100);
            numericUpDownNewUserStartNumber.Name = "numericUpDownNewUserStartNumber";
            numericUpDownNewUserStartNumber.Size = new Size(498, 23);
            numericUpDownNewUserStartNumber.TabIndex = 18;
            // 
            // numericUpDownNewGroupCounter
            // 
            numericUpDownNewGroupCounter.Location = new Point(290, 70);
            numericUpDownNewGroupCounter.Name = "numericUpDownNewGroupCounter";
            numericUpDownNewGroupCounter.Size = new Size(498, 23);
            numericUpDownNewGroupCounter.TabIndex = 19;
            // 
            // textBoxAdminLogin
            // 
            textBoxAdminLogin.Location = new Point(290, 215);
            textBoxAdminLogin.Name = "textBoxAdminLogin";
            textBoxAdminLogin.Size = new Size(498, 23);
            textBoxAdminLogin.TabIndex = 20;
            // 
            // textBoxAdminPass
            // 
            textBoxAdminPass.Location = new Point(290, 244);
            textBoxAdminPass.Name = "textBoxAdminPass";
            textBoxAdminPass.PasswordChar = '*';
            textBoxAdminPass.Size = new Size(498, 23);
            textBoxAdminPass.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 218);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 22;
            label7.Text = "Логин администратора";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 247);
            label8.Name = "label8";
            label8.Size = new Size(143, 15);
            label8.TabIndex = 23;
            label8.Text = "Пароль администратора";
            // 
            // textBoxHomeDrive
            // 
            textBoxHomeDrive.Location = new Point(290, 186);
            textBoxHomeDrive.Name = "textBoxHomeDrive";
            textBoxHomeDrive.Size = new Size(498, 23);
            textBoxHomeDrive.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 189);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 25;
            label9.Text = "Буква сетевого диска";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(label9);
            Controls.Add(textBoxHomeDrive);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxAdminPass);
            Controls.Add(textBoxAdminLogin);
            Controls.Add(numericUpDownNewGroupCounter);
            Controls.Add(numericUpDownNewUserStartNumber);
            Controls.Add(label6);
            Controls.Add(textBoxNetDiskAdress);
            Controls.Add(textBoxPass);
            Controls.Add(label5);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxOU);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxGroupNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewUserStartNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewGroupCounter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxGroupNumber;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxOU;
        private Button buttonCreate;
        private Label label5;
        private TextBox textBoxPass;
        private TextBox textBoxNetDiskAdress;
        private Label label6;
        private NumericUpDown numericUpDownNewUserStartNumber;
        private NumericUpDown numericUpDownNewGroupCounter;
        private TextBox textBoxAdminLogin;
        private TextBox textBoxAdminPass;
        private Label label7;
        private Label label8;
        private TextBox textBoxHomeDrive;
        private Label label9;
    }
}
