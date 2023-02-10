namespace BistroVersion2
{
    partial class User_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.Clear_button2 = new System.Windows.Forms.Button();
            this.Clear_button1 = new System.Windows.Forms.Button();
            this.Zakazat_button = new System.Windows.Forms.Button();
            this.Add_inZakaz_button = new System.Windows.Forms.Button();
            this.NewOrder_dataGridView = new System.Windows.Forms.DataGridView();
            this.Choose_Client_combox = new System.Windows.Forms.ComboBox();
            this.Cost_dowm_button = new System.Windows.Forms.Button();
            this.Cost_up_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Menu_dataGridView = new System.Windows.Forms.DataGridView();
            this.Search_vid_button = new System.Windows.Forms.Button();
            this.Search_bludo_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vid_bluda_textBox = new System.Windows.Forms.TextBox();
            this.Bluda_textBox = new System.Windows.Forms.TextBox();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Klient_Add_button = new System.Windows.Forms.Button();
            this.Clients_button = new System.Windows.Forms.Button();
            this.History_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Order_dataGridView = new System.Windows.Forms.DataGridView();
            this.user_login_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Menu_button = new System.Windows.Forms.Button();
            this.Profile_button = new System.Windows.Forms.Button();
            this.Employees_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.GoExcel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewOrder_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_dataGridView)).BeginInit();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Controls.Add(this.tabEmployees);
            this.tabControl.Location = new System.Drawing.Point(12, 107);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(979, 628);
            this.tabControl.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.Silver;
            this.tabMenu.Controls.Add(this.GoExcel);
            this.tabMenu.Controls.Add(this.Clear_button2);
            this.tabMenu.Controls.Add(this.Clear_button1);
            this.tabMenu.Controls.Add(this.Zakazat_button);
            this.tabMenu.Controls.Add(this.Add_inZakaz_button);
            this.tabMenu.Controls.Add(this.NewOrder_dataGridView);
            this.tabMenu.Controls.Add(this.Choose_Client_combox);
            this.tabMenu.Controls.Add(this.Cost_dowm_button);
            this.tabMenu.Controls.Add(this.Cost_up_button);
            this.tabMenu.Controls.Add(this.label4);
            this.tabMenu.Controls.Add(this.label3);
            this.tabMenu.Controls.Add(this.Menu_dataGridView);
            this.tabMenu.Controls.Add(this.Search_vid_button);
            this.tabMenu.Controls.Add(this.Search_bludo_button);
            this.tabMenu.Controls.Add(this.label2);
            this.tabMenu.Controls.Add(this.label1);
            this.tabMenu.Controls.Add(this.vid_bluda_textBox);
            this.tabMenu.Controls.Add(this.Bluda_textBox);
            this.tabMenu.Location = new System.Drawing.Point(4, 29);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(971, 595);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Блюда";
            // 
            // Clear_button2
            // 
            this.Clear_button2.Location = new System.Drawing.Point(581, 54);
            this.Clear_button2.Name = "Clear_button2";
            this.Clear_button2.Size = new System.Drawing.Size(105, 30);
            this.Clear_button2.TabIndex = 15;
            this.Clear_button2.Text = "Отчистить";
            this.Clear_button2.UseVisualStyleBackColor = true;
            this.Clear_button2.Click += new System.EventHandler(this.Clear_button2_Click);
            // 
            // Clear_button1
            // 
            this.Clear_button1.Location = new System.Drawing.Point(238, 54);
            this.Clear_button1.Name = "Clear_button1";
            this.Clear_button1.Size = new System.Drawing.Size(105, 30);
            this.Clear_button1.TabIndex = 14;
            this.Clear_button1.Text = "Отчистить";
            this.Clear_button1.UseVisualStyleBackColor = true;
            this.Clear_button1.Click += new System.EventHandler(this.Clear_button1_Click);
            // 
            // Zakazat_button
            // 
            this.Zakazat_button.Location = new System.Drawing.Point(417, 327);
            this.Zakazat_button.Name = "Zakazat_button";
            this.Zakazat_button.Size = new System.Drawing.Size(90, 48);
            this.Zakazat_button.TabIndex = 13;
            this.Zakazat_button.Text = "Заказать";
            this.Zakazat_button.UseVisualStyleBackColor = true;
            this.Zakazat_button.Click += new System.EventHandler(this.Zakazat_button_Click);
            // 
            // Add_inZakaz_button
            // 
            this.Add_inZakaz_button.Location = new System.Drawing.Point(289, 327);
            this.Add_inZakaz_button.Name = "Add_inZakaz_button";
            this.Add_inZakaz_button.Size = new System.Drawing.Size(102, 48);
            this.Add_inZakaz_button.TabIndex = 12;
            this.Add_inZakaz_button.Text = "Добавить в заказ";
            this.Add_inZakaz_button.UseVisualStyleBackColor = true;
            this.Add_inZakaz_button.Click += new System.EventHandler(this.Add_inZakaz_button_Click);
            // 
            // NewOrder_dataGridView
            // 
            this.NewOrder_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewOrder_dataGridView.Location = new System.Drawing.Point(10, 381);
            this.NewOrder_dataGridView.Name = "NewOrder_dataGridView";
            this.NewOrder_dataGridView.Size = new System.Drawing.Size(930, 208);
            this.NewOrder_dataGridView.TabIndex = 11;
            // 
            // Choose_Client_combox
            // 
            this.Choose_Client_combox.FormattingEnabled = true;
            this.Choose_Client_combox.Location = new System.Drawing.Point(10, 347);
            this.Choose_Client_combox.Name = "Choose_Client_combox";
            this.Choose_Client_combox.Size = new System.Drawing.Size(224, 28);
            this.Choose_Client_combox.TabIndex = 10;
            // 
            // Cost_dowm_button
            // 
            this.Cost_dowm_button.Location = new System.Drawing.Point(850, 46);
            this.Cost_dowm_button.Name = "Cost_dowm_button";
            this.Cost_dowm_button.Size = new System.Drawing.Size(90, 28);
            this.Cost_dowm_button.TabIndex = 9;
            this.Cost_dowm_button.Text = "Дешевле";
            this.Cost_dowm_button.UseVisualStyleBackColor = true;
            this.Cost_dowm_button.Click += new System.EventHandler(this.Cost_dowm_button_Click);
            // 
            // Cost_up_button
            // 
            this.Cost_up_button.Location = new System.Drawing.Point(723, 46);
            this.Cost_up_button.Name = "Cost_up_button";
            this.Cost_up_button.Size = new System.Drawing.Size(90, 28);
            this.Cost_up_button.TabIndex = 8;
            this.Cost_up_button.Text = "Дороже";
            this.Cost_up_button.UseVisualStyleBackColor = true;
            this.Cost_up_button.Click += new System.EventHandler(this.Cost_up_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сортировать по стоимости:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сделать заказ:";
            // 
            // Menu_dataGridView
            // 
            this.Menu_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menu_dataGridView.Location = new System.Drawing.Point(12, 90);
            this.Menu_dataGridView.Name = "Menu_dataGridView";
            this.Menu_dataGridView.ShowCellErrors = false;
            this.Menu_dataGridView.Size = new System.Drawing.Size(928, 231);
            this.Menu_dataGridView.TabIndex = 5;
            // 
            // Search_vid_button
            // 
            this.Search_vid_button.Location = new System.Drawing.Point(581, 20);
            this.Search_vid_button.Name = "Search_vid_button";
            this.Search_vid_button.Size = new System.Drawing.Size(105, 28);
            this.Search_vid_button.TabIndex = 4;
            this.Search_vid_button.Text = "Поиск";
            this.Search_vid_button.UseVisualStyleBackColor = true;
            this.Search_vid_button.Click += new System.EventHandler(this.Search_vid_button_Click);
            // 
            // Search_bludo_button
            // 
            this.Search_bludo_button.Location = new System.Drawing.Point(238, 20);
            this.Search_bludo_button.Name = "Search_bludo_button";
            this.Search_bludo_button.Size = new System.Drawing.Size(105, 28);
            this.Search_bludo_button.TabIndex = 4;
            this.Search_bludo_button.Text = "Поиск";
            this.Search_bludo_button.UseVisualStyleBackColor = true;
            this.Search_bludo_button.Click += new System.EventHandler(this.Search_bludo_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск блюда по виду:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск блюда по названию:";
            // 
            // vid_bluda_textBox
            // 
            this.vid_bluda_textBox.Location = new System.Drawing.Point(372, 43);
            this.vid_bluda_textBox.Name = "vid_bluda_textBox";
            this.vid_bluda_textBox.Size = new System.Drawing.Size(206, 26);
            this.vid_bluda_textBox.TabIndex = 1;
            // 
            // Bluda_textBox
            // 
            this.Bluda_textBox.Location = new System.Drawing.Point(6, 43);
            this.Bluda_textBox.Name = "Bluda_textBox";
            this.Bluda_textBox.Size = new System.Drawing.Size(206, 26);
            this.Bluda_textBox.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.Silver;
            this.tabProfile.Controls.Add(this.Delete_button);
            this.tabProfile.Controls.Add(this.Klient_Add_button);
            this.tabProfile.Controls.Add(this.Clients_button);
            this.tabProfile.Controls.Add(this.History_button);
            this.tabProfile.Controls.Add(this.Back_button);
            this.tabProfile.Controls.Add(this.Order_dataGridView);
            this.tabProfile.Controls.Add(this.user_login_TB);
            this.tabProfile.Controls.Add(this.label5);
            this.tabProfile.Controls.Add(this.pictureBox1);
            this.tabProfile.Location = new System.Drawing.Point(4, 29);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(971, 595);
            this.tabProfile.TabIndex = 1;
            this.tabProfile.Text = "Профиль Постоянного Клиента";
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(762, 202);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(86, 53);
            this.Delete_button.TabIndex = 8;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Klient_Add_button
            // 
            this.Klient_Add_button.Location = new System.Drawing.Point(630, 202);
            this.Klient_Add_button.Name = "Klient_Add_button";
            this.Klient_Add_button.Size = new System.Drawing.Size(111, 53);
            this.Klient_Add_button.TabIndex = 7;
            this.Klient_Add_button.Text = "Добавить Клиента";
            this.Klient_Add_button.UseVisualStyleBackColor = true;
            this.Klient_Add_button.Visible = false;
            this.Klient_Add_button.Click += new System.EventHandler(this.Klient_Add_button_Click);
            // 
            // Clients_button
            // 
            this.Clients_button.Location = new System.Drawing.Point(461, 202);
            this.Clients_button.Name = "Clients_button";
            this.Clients_button.Size = new System.Drawing.Size(96, 35);
            this.Clients_button.TabIndex = 6;
            this.Clients_button.Text = "Клиенты";
            this.Clients_button.UseVisualStyleBackColor = true;
            this.Clients_button.Click += new System.EventHandler(this.Clients_button_Click);
            // 
            // History_button
            // 
            this.History_button.Location = new System.Drawing.Point(248, 202);
            this.History_button.Name = "History_button";
            this.History_button.Size = new System.Drawing.Size(163, 35);
            this.History_button.TabIndex = 5;
            this.History_button.Text = "История заказов";
            this.History_button.UseVisualStyleBackColor = true;
            this.History_button.Click += new System.EventHandler(this.History_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(838, 556);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(84, 33);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Order_dataGridView
            // 
            this.Order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_dataGridView.Location = new System.Drawing.Point(20, 261);
            this.Order_dataGridView.Name = "Order_dataGridView";
            this.Order_dataGridView.Size = new System.Drawing.Size(828, 280);
            this.Order_dataGridView.TabIndex = 3;
            this.Order_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_dataGridView_CellContentClick);
            // 
            // user_login_TB
            // 
            this.user_login_TB.Enabled = false;
            this.user_login_TB.Location = new System.Drawing.Point(220, 97);
            this.user_login_TB.Name = "user_login_TB";
            this.user_login_TB.Size = new System.Drawing.Size(91, 26);
            this.user_login_TB.TabIndex = 2;
            this.user_login_TB.Text = "User Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Пользователь";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BistroVersion2.Properties.Resources.client1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabEmployees
            // 
            this.tabEmployees.BackColor = System.Drawing.Color.Silver;
            this.tabEmployees.Controls.Add(this.label8);
            this.tabEmployees.Controls.Add(this.label7);
            this.tabEmployees.Controls.Add(this.label6);
            this.tabEmployees.Controls.Add(this.pictureBox4);
            this.tabEmployees.Controls.Add(this.pictureBox3);
            this.tabEmployees.Controls.Add(this.pictureBox2);
            this.tabEmployees.Location = new System.Drawing.Point(4, 29);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(971, 595);
            this.tabEmployees.TabIndex = 2;
            this.tabEmployees.Text = "Вас Обслуживали:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Официант месяца";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Шеф-Повар";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Директор";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BistroVersion2.Properties.Resources.огузок;
            this.pictureBox4.Location = new System.Drawing.Point(641, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 189);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BistroVersion2.Properties.Resources.шеф;
            this.pictureBox3.Location = new System.Drawing.Point(344, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 189);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BistroVersion2.Properties.Resources.нагиев2;
            this.pictureBox2.Location = new System.Drawing.Point(58, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.Color.Tan;
            this.Menu_button.Location = new System.Drawing.Point(236, 39);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(123, 51);
            this.Menu_button.TabIndex = 1;
            this.Menu_button.Text = "Открыть меню";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Profile_button
            // 
            this.Profile_button.BackColor = System.Drawing.Color.Tan;
            this.Profile_button.Location = new System.Drawing.Point(419, 39);
            this.Profile_button.Name = "Profile_button";
            this.Profile_button.Size = new System.Drawing.Size(126, 51);
            this.Profile_button.TabIndex = 2;
            this.Profile_button.Text = "Открыть Профиль";
            this.Profile_button.UseVisualStyleBackColor = false;
            this.Profile_button.Click += new System.EventHandler(this.Profile_button_Click);
            // 
            // Employees_button
            // 
            this.Employees_button.BackColor = System.Drawing.Color.Tan;
            this.Employees_button.Location = new System.Drawing.Point(597, 39);
            this.Employees_button.Name = "Employees_button";
            this.Employees_button.Size = new System.Drawing.Size(121, 51);
            this.Employees_button.TabIndex = 3;
            this.Employees_button.Text = "Сотрудники";
            this.Employees_button.UseVisualStyleBackColor = false;
            this.Employees_button.Click += new System.EventHandler(this.Employees_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(12, 51);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(191, 24);
            this.Header_label.TabIndex = 4;
            this.Header_label.Text = "Samoilov Bistro №1";
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Tan;
            this.Exit_button.Location = new System.Drawing.Point(915, 12);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(91, 54);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Выйти из Системы";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // GoExcel
            // 
            this.GoExcel.Location = new System.Drawing.Point(591, 333);
            this.GoExcel.Name = "GoExcel";
            this.GoExcel.Size = new System.Drawing.Size(151, 36);
            this.GoExcel.TabIndex = 16;
            this.GoExcel.Text = "Выгрузка в Excel";
            this.GoExcel.UseVisualStyleBackColor = true;
            this.GoExcel.Click += new System.EventHandler(this.GoExcel_Click);
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1026, 747);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.Employees_button);
            this.Controls.Add(this.Profile_button);
            this.Controls.Add(this.Menu_button);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User_Form";
            this.Text = "User_Form";
            this.Load += new System.EventHandler(this.User_Form_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewOrder_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_dataGridView)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Button Zakazat_button;
        private System.Windows.Forms.Button Add_inZakaz_button;
        private System.Windows.Forms.DataGridView NewOrder_dataGridView;
        private System.Windows.Forms.ComboBox Choose_Client_combox;
        private System.Windows.Forms.Button Cost_dowm_button;
        private System.Windows.Forms.Button Cost_up_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Menu_dataGridView;
        private System.Windows.Forms.Button Search_vid_button;
        private System.Windows.Forms.Button Search_bludo_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vid_bluda_textBox;
        private System.Windows.Forms.TextBox Bluda_textBox;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.Button Menu_button;
        private System.Windows.Forms.Button Profile_button;
        private System.Windows.Forms.Button Employees_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.DataGridView Order_dataGridView;
        private System.Windows.Forms.TextBox user_login_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Clients_button;
        private System.Windows.Forms.Button History_button;
        private System.Windows.Forms.Button Klient_Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Clear_button2;
        private System.Windows.Forms.Button Clear_button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button GoExcel;
    }
}