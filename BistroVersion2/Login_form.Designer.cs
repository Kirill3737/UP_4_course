namespace BistroVersion2
{
    partial class Login_form
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Authorize_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Log_in_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::BistroVersion2.Properties.Resources.Logo;
            this.LogoBox.Location = new System.Drawing.Point(65, 7);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(185, 169);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 7;
            this.LogoBox.TabStop = false;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(130, 262);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(45, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Пароль";
            // 
            // Authorize_label
            // 
            this.Authorize_label.AutoSize = true;
            this.Authorize_label.Location = new System.Drawing.Point(106, 179);
            this.Authorize_label.Name = "Authorize_label";
            this.Authorize_label.Size = new System.Drawing.Size(95, 13);
            this.Authorize_label.TabIndex = 1;
            this.Authorize_label.Text = "Авторизируйтесь";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(137, 208);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(38, 13);
            this.Login_label.TabIndex = 2;
            this.Login_label.Text = "Логин";
            // 
            // Log_in_button
            // 
            this.Log_in_button.Location = new System.Drawing.Point(109, 338);
            this.Log_in_button.Name = "Log_in_button";
            this.Log_in_button.Size = new System.Drawing.Size(104, 43);
            this.Log_in_button.TabIndex = 0;
            this.Log_in_button.Text = "войтив в систему";
            this.Log_in_button.UseVisualStyleBackColor = true;
            this.Log_in_button.Click += new System.EventHandler(this.Log_in_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogoBox);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.password_textBox);
            this.panel1.Controls.Add(this.login_textBox);
            this.panel1.Controls.Add(this.Password_label);
            this.panel1.Controls.Add(this.Authorize_label);
            this.panel1.Controls.Add(this.Login_label);
            this.panel1.Controls.Add(this.Log_in_button);
            this.panel1.Location = new System.Drawing.Point(60, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 385);
            this.panel1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(109, 312);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(109, 288);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 20);
            this.password_textBox.TabIndex = 5;
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(109, 224);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(100, 20);
            this.login_textBox.TabIndex = 4;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(444, 438);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_form";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Authorize_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Button Log_in_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
    }
}

