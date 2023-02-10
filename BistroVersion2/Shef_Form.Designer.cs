namespace BistroVersion2
{
    partial class Shef_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idблюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idпродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяприготовленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samoilovBistroDataSet = new BistroVersion2.SamoilovBistroDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idпродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.калорийностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.веспродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценапродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idблюдаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видблюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выходвесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьблюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рецептыTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.рецептыTableAdapter();
            this.продуктыTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.ПродуктыTableAdapter();
            this.блюдаTableAdapter = new BistroVersion2.SamoilovBistroDataSetTableAdapters.БлюдаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet_college2 = new BistroVersion2.DataSet_college2();
            this.рецептыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.рецептыTableAdapter1 = new BistroVersion2.DataSet_college2TableAdapters.рецептыTableAdapter();
            this.продуктыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter1 = new BistroVersion2.DataSet_college2TableAdapters.ПродуктыTableAdapter();
            this.блюдаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.блюдаTableAdapter1 = new BistroVersion2.DataSet_college2TableAdapters.БлюдаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samoilovBistroDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_college2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BistroVersion2.Properties.Resources.шеф;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 201);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 250);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рецепты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idблюдаDataGridViewTextBoxColumn,
            this.idпродуктаDataGridViewTextBoxColumn,
            this.времяприготовленияDataGridViewTextBoxColumn,
            this.рецептDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.рецептыBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // idблюдаDataGridViewTextBoxColumn
            // 
            this.idблюдаDataGridViewTextBoxColumn.DataPropertyName = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn.HeaderText = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn.Name = "idблюдаDataGridViewTextBoxColumn";
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
            // рецептыBindingSource
            // 
            this.рецептыBindingSource.DataMember = "рецепты";
            this.рецептыBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // samoilovBistroDataSet
            // 
            this.samoilovBistroDataSet.DataSetName = "SamoilovBistroDataSet";
            this.samoilovBistroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продукты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idпродуктаDataGridViewTextBoxColumn1,
            this.названиепродуктаDataGridViewTextBoxColumn,
            this.калорийностьDataGridViewTextBoxColumn,
            this.веспродуктаDataGridViewTextBoxColumn,
            this.ценапродуктаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.продуктыBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(633, 212);
            this.dataGridView2.TabIndex = 0;
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
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блюда";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idблюдаDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.видблюдаDataGridViewTextBoxColumn,
            this.выходвесDataGridViewTextBoxColumn,
            this.стоимостьблюдаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.блюдаBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(635, 218);
            this.dataGridView3.TabIndex = 0;
            // 
            // idблюдаDataGridViewTextBoxColumn1
            // 
            this.idблюдаDataGridViewTextBoxColumn1.DataPropertyName = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn1.HeaderText = "id_блюда";
            this.idблюдаDataGridViewTextBoxColumn1.Name = "idблюдаDataGridViewTextBoxColumn1";
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
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.samoilovBistroDataSet;
            // 
            // рецептыTableAdapter
            // 
            this.рецептыTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // блюдаTableAdapter
            // 
            this.блюдаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(703, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выйти из системы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet_college2
            // 
            this.dataSet_college2.DataSetName = "DataSet_college2";
            this.dataSet_college2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рецептыBindingSource1
            // 
            this.рецептыBindingSource1.DataMember = "рецепты";
            this.рецептыBindingSource1.DataSource = this.dataSet_college2;
            // 
            // рецептыTableAdapter1
            // 
            this.рецептыTableAdapter1.ClearBeforeFill = true;
            // 
            // продуктыBindingSource1
            // 
            this.продуктыBindingSource1.DataMember = "Продукты";
            this.продуктыBindingSource1.DataSource = this.dataSet_college2;
            // 
            // продуктыTableAdapter1
            // 
            this.продуктыTableAdapter1.ClearBeforeFill = true;
            // 
            // блюдаBindingSource1
            // 
            this.блюдаBindingSource1.DataMember = "Блюда";
            this.блюдаBindingSource1.DataSource = this.dataSet_college2;
            // 
            // блюдаTableAdapter1
            // 
            this.блюдаTableAdapter1.ClearBeforeFill = true;
            // 
            // Shef_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(785, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shef_Form";
            this.Text = "Shef_Form";
            this.Load += new System.EventHandler(this.Shef_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samoilovBistroDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_college2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private SamoilovBistroDataSet samoilovBistroDataSet;
        private System.Windows.Forms.BindingSource рецептыBindingSource;
        private SamoilovBistroDataSetTableAdapters.рецептыTableAdapter рецептыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idблюдаDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private SamoilovBistroDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idблюдаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видблюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выходвесDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьблюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private DataSet_college2 dataSet_college2;
        private System.Windows.Forms.BindingSource рецептыBindingSource1;
        private DataSet_college2TableAdapters.рецептыTableAdapter рецептыTableAdapter1;
        private System.Windows.Forms.BindingSource продуктыBindingSource1;
        private DataSet_college2TableAdapters.ПродуктыTableAdapter продуктыTableAdapter1;
        private System.Windows.Forms.BindingSource блюдаBindingSource1;
        private DataSet_college2TableAdapters.БлюдаTableAdapter блюдаTableAdapter1;
    }
}