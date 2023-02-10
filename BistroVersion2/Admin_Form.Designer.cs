namespace BistroVersion2
{
    partial class Admin_Form
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
            this.components = new System.ComponentModel.Container();
            this.End_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idблюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видблюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выходвесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьблюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_college = new BistroVersion2.DataSet_college();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete_recept_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_recept_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idблюдаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idпродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяприготовленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idпродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.калорийностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.веспродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценапродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idблюдаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПорцийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриготовленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказНаБлюдаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеркартылояльностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idпользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.idпользователяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samoilovBistroDataSet = new BistroVersion2.SamoilovBistroDataSet();
            this.рецептыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказНаБлюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.блюдаTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.БлюдаTableAdapter();
            this.рецептыTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.рецептыTableAdapter();
            this.продуктыTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.ПродуктыTableAdapter();
            this.заказ_На_БлюдаTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.Заказ_На_БлюдаTableAdapter();
            this.клиентыTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.КлиентыTableAdapter();
            this.пользователиTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.ПользователиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.блюдаTableAdapter1 = new BistroVersion2.DataSet_collegeTableAdapters.БлюдаTableAdapter();
            this.рецептыTableAdapter1 = new BistroVersion2.DataSet_collegeTableAdapters.рецептыTableAdapter();
            this.продуктыTableAdapter1 = new BistroVersion2.DataSet_collegeTableAdapters.ПродуктыTableAdapter();
            this.заказ_На_БлюдаTableAdapter1 = new BistroVersion2.DataSet_collegeTableAdapters.Заказ_На_БлюдаTableAdapter();
            this.клиентыTableAdapter1 = new BistroVersion2.DataSet_collegeTableAdapters.КлиентыTableAdapter();
            this.пользователиTableAdapter1 = new BistroVersion2.DataSet_collegeTableAdapters.ПользователиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_college)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказНаБлюдаBindingSource1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samoilovBistroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказНаБлюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // End_button
            // 
            this.End_button.BackColor = System.Drawing.Color.Tan;
            this.End_button.Location = new System.Drawing.Point(677, 367);
            this.End_button.Margin = new System.Windows.Forms.Padding(2);
            this.End_button.Name = "End_button";
            this.End_button.Size = new System.Drawing.Size(91, 57);
            this.End_button.TabIndex = 5;
            this.End_button.Text = "Выйти из Системы";
            this.End_button.UseVisualStyleBackColor = false;
            this.End_button.Click += new System.EventHandler(this.End_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 377);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Блюда";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idблюдаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.видблюдаDataGridViewTextBoxColumn,
            this.выходвесDataGridViewTextBoxColumn,
            this.стоимостьблюдаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.блюдаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(587, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // idблюдаDataGridViewTextBoxColumn
            // 
            this.idблюдаDataGridViewTextBoxColumn.DataPropertyName = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn.HeaderText = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn.Name = "idблюдаDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // видблюдаDataGridViewTextBoxColumn
            // 
            this.видблюдаDataGridViewTextBoxColumn.DataPropertyName = "Вид_блюда";
            this.видблюдаDataGridViewTextBoxColumn.HeaderText = "Вид_блюда";
            this.видблюдаDataGridViewTextBoxColumn.Name = "видблюдаDataGridViewTextBoxColumn";
            // 
            // выходвесDataGridViewTextBoxColumn
            // 
            this.выходвесDataGridViewTextBoxColumn.DataPropertyName = "Выход_вес";
            this.выходвесDataGridViewTextBoxColumn.HeaderText = "Выход_вес";
            this.выходвесDataGridViewTextBoxColumn.Name = "выходвесDataGridViewTextBoxColumn";
            // 
            // стоимостьблюдаDataGridViewTextBoxColumn
            // 
            this.стоимостьблюдаDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_блюда";
            this.стоимостьблюдаDataGridViewTextBoxColumn.HeaderText = "Стоимость_блюда";
            this.стоимостьблюдаDataGridViewTextBoxColumn.Name = "стоимостьблюдаDataGridViewTextBoxColumn";
            // 
            // блюдаBindingSource1
            // 
            this.блюдаBindingSource1.DataMember = "Блюда";
            this.блюдаBindingSource1.DataSource = this.dataSet_college;
            // 
            // dataSet_college
            // 
            this.dataSet_college.DataSetName = "DataSet_college";
            this.dataSet_college.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delete_recept_button);
            this.tabPage2.Controls.Add(this.edit_button);
            this.tabPage2.Controls.Add(this.add_recept_button);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рецепты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete_recept_button
            // 
            this.delete_recept_button.Location = new System.Drawing.Point(362, 315);
            this.delete_recept_button.Name = "delete_recept_button";
            this.delete_recept_button.Size = new System.Drawing.Size(72, 25);
            this.delete_recept_button.TabIndex = 3;
            this.delete_recept_button.Text = "Удалить";
            this.delete_recept_button.UseVisualStyleBackColor = true;
            this.delete_recept_button.Click += new System.EventHandler(this.delete_recept_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(178, 313);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(103, 27);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_recept_button
            // 
            this.add_recept_button.Location = new System.Drawing.Point(36, 315);
            this.add_recept_button.Name = "add_recept_button";
            this.add_recept_button.Size = new System.Drawing.Size(76, 25);
            this.add_recept_button.TabIndex = 1;
            this.add_recept_button.Text = "Добавить";
            this.add_recept_button.UseVisualStyleBackColor = true;
            this.add_recept_button.Click += new System.EventHandler(this.add_recept_button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idблюдаDataGridViewTextBoxColumn1,
            this.idпродуктаDataGridViewTextBoxColumn,
            this.времяприготовленияDataGridViewTextBoxColumn,
            this.рецептDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.рецептыBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(5, 6);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(583, 287);
            this.dataGridView2.TabIndex = 0;
            // 
            // idблюдаDataGridViewTextBoxColumn1
            // 
            this.idблюдаDataGridViewTextBoxColumn1.DataPropertyName = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn1.HeaderText = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn1.Name = "idблюдаDataGridViewTextBoxColumn1";
            // 
            // idпродуктаDataGridViewTextBoxColumn
            // 
            this.idпродуктаDataGridViewTextBoxColumn.DataPropertyName = "id_продукта";
            this.idпродуктаDataGridViewTextBoxColumn.HeaderText = "id_продукта";
            this.idпродуктаDataGridViewTextBoxColumn.Name = "idпродуктаDataGridViewTextBoxColumn";
            // 
            // времяприготовленияDataGridViewTextBoxColumn
            // 
            this.времяприготовленияDataGridViewTextBoxColumn.DataPropertyName = "Время_приготовления";
            this.времяприготовленияDataGridViewTextBoxColumn.HeaderText = "Время_приготовления";
            this.времяприготовленияDataGridViewTextBoxColumn.Name = "времяприготовленияDataGridViewTextBoxColumn";
            // 
            // рецептDataGridViewTextBoxColumn
            // 
            this.рецептDataGridViewTextBoxColumn.DataPropertyName = "Рецепт";
            this.рецептDataGridViewTextBoxColumn.HeaderText = "Рецепт";
            this.рецептDataGridViewTextBoxColumn.Name = "рецептDataGridViewTextBoxColumn";
            // 
            // рецептыBindingSource1
            // 
            this.рецептыBindingSource1.DataMember = "рецепты";
            this.рецептыBindingSource1.DataSource = this.dataSet_college;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(599, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Продукты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idпродуктаDataGridViewTextBoxColumn1,
            this.названиепродуктаDataGridViewTextBoxColumn,
            this.калорийностьDataGridViewTextBoxColumn,
            this.веспродуктаDataGridViewTextBoxColumn,
            this.ценапродуктаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.продуктыBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(10, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(582, 300);
            this.dataGridView3.TabIndex = 0;
            // 
            // idпродуктаDataGridViewTextBoxColumn1
            // 
            this.idпродуктаDataGridViewTextBoxColumn1.DataPropertyName = "id_продукта";
            this.idпродуктаDataGridViewTextBoxColumn1.HeaderText = "id_продукта";
            this.idпродуктаDataGridViewTextBoxColumn1.Name = "idпродуктаDataGridViewTextBoxColumn1";
            // 
            // названиепродуктаDataGridViewTextBoxColumn
            // 
            this.названиепродуктаDataGridViewTextBoxColumn.DataPropertyName = "Название_продукта";
            this.названиепродуктаDataGridViewTextBoxColumn.HeaderText = "Название_продукта";
            this.названиепродуктаDataGridViewTextBoxColumn.Name = "названиепродуктаDataGridViewTextBoxColumn";
            // 
            // калорийностьDataGridViewTextBoxColumn
            // 
            this.калорийностьDataGridViewTextBoxColumn.DataPropertyName = "Калорийность";
            this.калорийностьDataGridViewTextBoxColumn.HeaderText = "Калорийность";
            this.калорийностьDataGridViewTextBoxColumn.Name = "калорийностьDataGridViewTextBoxColumn";
            // 
            // веспродуктаDataGridViewTextBoxColumn
            // 
            this.веспродуктаDataGridViewTextBoxColumn.DataPropertyName = "Вес_продукта";
            this.веспродуктаDataGridViewTextBoxColumn.HeaderText = "Вес_продукта";
            this.веспродуктаDataGridViewTextBoxColumn.Name = "веспродуктаDataGridViewTextBoxColumn";
            // 
            // ценапродуктаDataGridViewTextBoxColumn
            // 
            this.ценапродуктаDataGridViewTextBoxColumn.DataPropertyName = "Цена_продукта";
            this.ценапродуктаDataGridViewTextBoxColumn.HeaderText = "Цена_продукта";
            this.ценапродуктаDataGridViewTextBoxColumn.Name = "ценапродуктаDataGridViewTextBoxColumn";
            // 
            // продуктыBindingSource1
            // 
            this.продуктыBindingSource1.DataMember = "Продукты";
            this.продуктыBindingSource1.DataSource = this.dataSet_college;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(599, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Заказ Блюд";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idблюдаDataGridViewTextBoxColumn2,
            this.количествоПорцийDataGridViewTextBoxColumn,
            this.датаПриготовленияDataGridViewTextBoxColumn,
            this.суммазаказаDataGridViewTextBoxColumn,
            this.номерзаказаDataGridViewTextBoxColumn,
            this.idКлиентаDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.заказНаБлюдаBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(2, 2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(589, 304);
            this.dataGridView4.TabIndex = 0;
            // 
            // idблюдаDataGridViewTextBoxColumn2
            // 
            this.idблюдаDataGridViewTextBoxColumn2.DataPropertyName = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn2.HeaderText = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn2.Name = "idблюдаDataGridViewTextBoxColumn2";
            // 
            // количествоПорцийDataGridViewTextBoxColumn
            // 
            this.количествоПорцийDataGridViewTextBoxColumn.DataPropertyName = "Количество_Порций";
            this.количествоПорцийDataGridViewTextBoxColumn.HeaderText = "Количество_Порций";
            this.количествоПорцийDataGridViewTextBoxColumn.Name = "количествоПорцийDataGridViewTextBoxColumn";
            // 
            // датаПриготовленияDataGridViewTextBoxColumn
            // 
            this.датаПриготовленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Приготовления";
            this.датаПриготовленияDataGridViewTextBoxColumn.HeaderText = "Дата_Приготовления";
            this.датаПриготовленияDataGridViewTextBoxColumn.Name = "датаПриготовленияDataGridViewTextBoxColumn";
            // 
            // суммазаказаDataGridViewTextBoxColumn
            // 
            this.суммазаказаDataGridViewTextBoxColumn.DataPropertyName = "Сумма_заказа";
            this.суммазаказаDataGridViewTextBoxColumn.HeaderText = "Сумма_заказа";
            this.суммазаказаDataGridViewTextBoxColumn.Name = "суммазаказаDataGridViewTextBoxColumn";
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            // 
            // idКлиентаDataGridViewTextBoxColumn
            // 
            this.idКлиентаDataGridViewTextBoxColumn.DataPropertyName = "id_Клиента";
            this.idКлиентаDataGridViewTextBoxColumn.HeaderText = "id_Клиента";
            this.idКлиентаDataGridViewTextBoxColumn.Name = "idКлиентаDataGridViewTextBoxColumn";
            // 
            // заказНаБлюдаBindingSource1
            // 
            this.заказНаБлюдаBindingSource1.DataMember = "Заказ_На_Блюда";
            this.заказНаБлюдаBindingSource1.DataSource = this.dataSet_college;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(599, 351);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Клиенты";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idКлиентаDataGridViewTextBoxColumn1,
            this.номеркартылояльностиDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.idпользователяDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.клиентыBindingSource1;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(593, 294);
            this.dataGridView5.TabIndex = 0;
            // 
            // idКлиентаDataGridViewTextBoxColumn1
            // 
            this.idКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "id_Клиента";
            this.idКлиентаDataGridViewTextBoxColumn1.HeaderText = "id_Клиента";
            this.idКлиентаDataGridViewTextBoxColumn1.Name = "idКлиентаDataGridViewTextBoxColumn1";
            // 
            // номеркартылояльностиDataGridViewTextBoxColumn
            // 
            this.номеркартылояльностиDataGridViewTextBoxColumn.DataPropertyName = "номер_карты_лояльности";
            this.номеркартылояльностиDataGridViewTextBoxColumn.HeaderText = "номер_карты_лояльности";
            this.номеркартылояльностиDataGridViewTextBoxColumn.Name = "номеркартылояльностиDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // idпользователяDataGridViewTextBoxColumn
            // 
            this.idпользователяDataGridViewTextBoxColumn.DataPropertyName = "id_пользователя";
            this.idпользователяDataGridViewTextBoxColumn.HeaderText = "id_пользователя";
            this.idпользователяDataGridViewTextBoxColumn.Name = "idпользователяDataGridViewTextBoxColumn";
            // 
            // клиентыBindingSource1
            // 
            this.клиентыBindingSource1.DataMember = "Клиенты";
            this.клиентыBindingSource1.DataSource = this.dataSet_college;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(599, 351);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Пользователи";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idпользователяDataGridViewTextBoxColumn1,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.пользователиBindingSource1;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(593, 302);
            this.dataGridView6.TabIndex = 0;
            // 
            // idпользователяDataGridViewTextBoxColumn1
            // 
            this.idпользователяDataGridViewTextBoxColumn1.DataPropertyName = "id_пользователя";
            this.idпользователяDataGridViewTextBoxColumn1.HeaderText = "id_пользователя";
            this.idпользователяDataGridViewTextBoxColumn1.Name = "idпользователяDataGridViewTextBoxColumn1";
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            // 
            // пользователиBindingSource1
            // 
            this.пользователиBindingSource1.DataMember = "Пользователи";
            this.пользователиBindingSource1.DataSource = this.dataSet_college;
            // 
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // samoilovBistroDataSet
            // 
            this.samoilovBistroDataSet.DataSetName = "SamoilovBistroDataSet";
            this.samoilovBistroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рецептыBindingSource
            // 
            this.рецептыBindingSource.DataMember = "рецепты";
            this.рецептыBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // заказНаБлюдаBindingSource
            // 
            this.заказНаБлюдаBindingSource.DataMember = "Заказ_На_Блюда";
            this.заказНаБлюдаBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BistroVersion2.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(647, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // блюдаTableAdapter
            // 
            this.блюдаTableAdapter.ClearBeforeFill = true;
            // 
            // рецептыTableAdapter
            // 
            this.рецептыTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // заказ_На_БлюдаTableAdapter
            // 
            this.заказ_На_БлюдаTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Владимир Вольфович";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Администратор";
            // 
            // блюдаTableAdapter1
            // 
            this.блюдаTableAdapter1.ClearBeforeFill = true;
            // 
            // рецептыTableAdapter1
            // 
            this.рецептыTableAdapter1.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter1
            // 
            this.продуктыTableAdapter1.ClearBeforeFill = true;
            // 
            // заказ_На_БлюдаTableAdapter1
            // 
            this.заказ_На_БлюдаTableAdapter1.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter1
            // 
            this.клиентыTableAdapter1.ClearBeforeFill = true;
            // 
            // пользователиTableAdapter1
            // 
            this.пользователиTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(210, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 27);
            this.button5.TabIndex = 8;
            this.button5.Text = "Редактировать";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(68, 313);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.End_button);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_college)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказНаБлюдаBindingSource1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samoilovBistroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказНаБлюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button End_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private SamoilovBistroDataSet samoilovBistroDataSet;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private SamoilovBistroDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idблюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видблюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выходвесDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьблюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource рецептыBindingSource;
        private SamoilovBistroDataSetTableAdapters.рецептыTableAdapter рецептыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idблюдаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idпродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяприготовленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рецептDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private SamoilovBistroDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idпродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиепродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn калорийностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn веспродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценапродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource заказНаБлюдаBindingSource;
        private SamoilovBistroDataSetTableAdapters.Заказ_На_БлюдаTableAdapter заказ_На_БлюдаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idблюдаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПорцийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриготовленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммазаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private SamoilovBistroDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКлиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеркартылояльностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idпользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private SamoilovBistroDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idпользователяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_recept_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_recept_button;
        private DataSet_college dataSet_college;
        private System.Windows.Forms.BindingSource блюдаBindingSource1;
        private DataSet_collegeTableAdapters.БлюдаTableAdapter блюдаTableAdapter1;
        private System.Windows.Forms.BindingSource рецептыBindingSource1;
        private DataSet_collegeTableAdapters.рецептыTableAdapter рецептыTableAdapter1;
        private System.Windows.Forms.BindingSource продуктыBindingSource1;
        private DataSet_collegeTableAdapters.ПродуктыTableAdapter продуктыTableAdapter1;
        private System.Windows.Forms.BindingSource заказНаБлюдаBindingSource1;
        private DataSet_collegeTableAdapters.Заказ_На_БлюдаTableAdapter заказ_На_БлюдаTableAdapter1;
        private System.Windows.Forms.BindingSource клиентыBindingSource1;
        private DataSet_collegeTableAdapters.КлиентыTableAdapter клиентыTableAdapter1;
        private System.Windows.Forms.BindingSource пользователиBindingSource1;
        private DataSet_collegeTableAdapters.ПользователиTableAdapter пользователиTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}