using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BistroVersion2
{
    public partial class Admin_Form : Form
    {

        string MyConnection = Properties.Resources.Connection;
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void End_button_Click(object sender, EventArgs e)
        {
            Login_form form = new Login_form();
            form.Show();
            this.Hide();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter1.Fill(this.dataSet_college.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter1.Fill(this.dataSet_college.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college.Заказ_На_Блюда". При необходимости она может быть перемещена или удалена.
            this.заказ_На_БлюдаTableAdapter1.Fill(this.dataSet_college.Заказ_На_Блюда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter1.Fill(this.dataSet_college.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college.рецепты". При необходимости она может быть перемещена или удалена.
            this.рецептыTableAdapter1.Fill(this.dataSet_college.рецепты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter1.Fill(this.dataSet_college.Блюда);
            //для MYPC
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            //this.пользователиTableAdapter.Fill(this.samoilovBistroDataSet.Пользователи);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            //this.клиентыTableAdapter.Fill(this.samoilovBistroDataSet.Клиенты);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.Заказ_На_Блюда". При необходимости она может быть перемещена или удалена.
            //this.заказ_На_БлюдаTableAdapter.Fill(this.samoilovBistroDataSet.Заказ_На_Блюда);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            //this.продуктыTableAdapter.Fill(this.samoilovBistroDataSet.Продукты);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.рецепты". При необходимости она может быть перемещена или удалена.
            //this.рецептыTableAdapter.Fill(this.samoilovBistroDataSet.рецепты);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            //this.блюдаTableAdapter.Fill(this.samoilovBistroDataSet.Блюда);

        }

        private void add_recept_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnection);
            string s1 = dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();
            string s2 = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();
            string s3 = dataGridView2[2, dataGridView2.CurrentRow.Index].Value.ToString();
            string s4 = dataGridView2[3, dataGridView2.CurrentRow.Index].Value.ToString();

            string ComandAdd = "Insert into [dbo].[рецепты] (id_блюда, id_продукта, Время_приготовления, Рецепт) values (@id, @id_prod, @time, @recept)";

            
            try
            {
                SqlCommand command = new SqlCommand(ComandAdd, connection);
                SqlParameter id = new SqlParameter("@id", s1);
                SqlParameter id_prod = new SqlParameter("@id_prod", s2);
                SqlParameter time = new SqlParameter("@time", s3);
                SqlParameter recept = new SqlParameter("@recept", s4);

                command.Parameters.Add(id);
                command.Parameters.Add(id_prod);
                command.Parameters.Add(time);
                command.Parameters.Add(recept);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_recept_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnection);

            DialogResult dialog = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                int row = dataGridView2.CurrentCell.RowIndex;
                string s1 = dataGridView1[0, row].Value.ToString();
                string ComDel = " Delete from [рецепты] where [id_блюда] = " + s1;

                
                SqlCommand cmd1 = new SqlCommand(ComDel, connection);
                connection.Open();
                cmd1.ExecuteNonQuery();
                connection.Close();
                
                this.рецептыTableAdapter1.Fill(this.dataSet_college.рецепты);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnection);
            string s9 = dataGridView3[0, dataGridView2.CurrentRow.Index].Value.ToString();
            string s5 = dataGridView3[1, dataGridView2.CurrentRow.Index].Value.ToString();
            string s6 = dataGridView3[2, dataGridView2.CurrentRow.Index].Value.ToString();
            string s7 = dataGridView3[3, dataGridView2.CurrentRow.Index].Value.ToString();
            string s8 = dataGridView3[4, dataGridView2.CurrentRow.Index].Value.ToString();

            string ComandAdd = "Insert into [dbo].[Продукты] (id_продукта, Название_продукта, Калорийность, Вес_продукта, Цена_продукта) values (@id, @prod_name, @kkal, @ves, @cost)";


            try
            {
                SqlCommand command = new SqlCommand(ComandAdd, connection);
                SqlParameter id = new SqlParameter("@id", s9);
                SqlParameter id_prod = new SqlParameter("@prod_name", s5);
                SqlParameter kkal = new SqlParameter("@kkal", s6);
                SqlParameter ves = new SqlParameter("@ves", s7);
                SqlParameter cost = new SqlParameter("@cost", s8);


                command.Parameters.Add(id);
                command.Parameters.Add(id_prod);
                command.Parameters.Add(kkal);
                command.Parameters.Add(ves);
                command.Parameters.Add(cost);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnection);

            DialogResult dialog = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                int row = dataGridView3.CurrentCell.RowIndex;
                string s11 = dataGridView1[0, row].Value.ToString();
                string ComDel = " Delete from [Продукты] where [id_продукта] = " + s11;


                SqlCommand cmd1 = new SqlCommand(ComDel, connection);
                connection.Open();
                cmd1.ExecuteNonQuery();
                connection.Close();

                this.продуктыTableAdapter1.Fill(this.dataSet_college.Продукты);
            }
        }
    }
}
