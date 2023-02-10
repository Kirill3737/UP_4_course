using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BistroVersion2
{
    public partial class User_Form : Form
    {
        string connection = Properties.Resources.Connection;
        SqlDataAdapter adapter;
        DataSet ds;
        int userId;
        string userLogin;
        int flag = 0;
        int flagNewZakaz = 0;
        public User_Form(int id, string login)
        {
            userId = id;
            userLogin = login;
            InitializeComponent();
        }
        internal string doRequest(string req) //запрос со значением
        {
            try
            {
                SqlConnection MyConnect = new SqlConnection(connection);
                MyConnect.Open();
                string value;
                SqlCommand command = new SqlCommand(req, MyConnect);
                value = command.ExecuteScalar().ToString();
                MyConnect.Close();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return"";
            }
        }
        internal void doNoneRequest(string req) // запрос без значения
        {
            try
            {
                SqlConnection MyConnect = new SqlConnection(connection);
                MyConnect.Open();
                SqlCommand command = new SqlCommand(req, MyConnect);
                command.ExecuteNonQuery();
                MyConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataSet doTable(string req) //Отобразить таблицу
        {
            try
            {
                SqlConnection MyConnect = new SqlConnection(connection);
                ds = new DataSet();
                adapter = new SqlDataAdapter(req, connection);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Login_form login_Form = new Login_form();
            //login_Form.Show();
            //this.Hide();
        }
        private void remove()
        {
            tabControl.Controls.Remove(tabMenu);
            tabControl.Controls.Remove(tabProfile);
            tabControl.Controls.Remove(tabEmployees);
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            remove();
            tabControl.Controls.Add(tabMenu);
        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            remove();
            tabControl.Controls.Add(tabProfile);
        }

        private void Employees_button_Click(object sender, EventArgs e)
        {
            remove();
            tabControl.Controls.Add(tabEmployees);
        }

        private void updateTabOrders()
        {
            string getOrders = $"select Номер_заказа as 'Номер', Название as'Название', Количество_Порций as 'Количество', SUM(Сумма_заказа) as 'Итог.Стоимость', Дата_Приготовления as 'Дата заказа' from Блюда inner join Заказ_На_Блюда on Блюда.id_блюда = Заказ_На_Блюда.id_блюда inner join Клиенты on Заказ_На_Блюда.id_Клиента = Клиенты.id_Клиента where id_пользователя = { userId} group by Заказ_На_Блюда.Дата_Приготовления, Название, Количество_Порций, Сумма_заказа, Номер_заказа";
            doTable(getOrders);
            Order_dataGridView.DataSource = ds.Tables[0];
            Order_dataGridView.Columns[0].Visible = false;
        }

        private void updateTabMenu()
        {
            string getMenu = $"select Блюда.id_блюда, Название as 'Название', Вид_блюда as 'Вид', Время_приготовления as 'Время ожидания', Выход_вес as 'Вес порции', Стоимость_блюда as 'Стоимость' from рецепты inner join Блюда on рецепты.id_блюда = Блюда.id_блюда order by Время_приготовления";
            doTable(getMenu);
            Menu_dataGridView.DataSource = ds.Tables[0];
            Menu_dataGridView.Columns[0].Visible = false;
        }
        internal void updateTabClients()
        {
            string getClients = $"select Клиенты.id_Клиента, ФИО, телефон as 'Телефон', номер_карты_лояльности as 'Карта лояльности' from Клиенты where id_пользователя = {userId}";
            doTable(getClients);
            Order_dataGridView.DataSource = ds.Tables[0];
            Order_dataGridView.Columns[0].Visible = false;
        }

        internal void updateComboBox()
        {
            try
            {
                Choose_Client_combox.Items.Clear();
                SqlConnection MyConnect = new SqlConnection(connection);
                string getFIO = $"select ФИО from Клиенты where id_пользователя = {userId}";
                SqlCommand commandGetFio = new SqlCommand(getFIO, MyConnect);
                MyConnect.Open();
                using (SqlDataReader reader = commandGetFio.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Choose_Client_combox.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                MyConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            updateTabOrders();
            updateTabMenu();
            updateComboBox();
            remove();
            tabControl.Controls.Add(tabMenu);
            user_login_TB.Text = userLogin;
        }

        private void Order_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(flag == 0 )
            {
                Back_button.Visible = true;
                flag = 1;
                string getInfo = $"select Блюда.id_блюда, Название, Вид_блюда as 'Вид', Время_приготовления as 'Время ожидания', Стоимость_блюда as 'Стоимость', ФИО as 'Клиент' from рецепты inner join Блюда on рецепты.id_блюда = Блюда.id_блюда inner join Заказ_На_Блюда on Блюда.id_блюда = Заказ_На_Блюда.id_блюда inner join Клиенты on Заказ_На_Блюда.id_Клиента = Клиенты.id_Клиента where id_user = {userId} and Номер_заказа = {Menu_dataGridView.SelectedCells[0].Value}";
                doTable(getInfo);
                Order_dataGridView.DataSource = ds.Tables[0];
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            flag = 0;
            updateTabOrders();
            Back_button.Visible = false;
        }

        private void History_button_Click(object sender, EventArgs e)
        {
            flag = 0;
            updateTabOrders();
            Back_button.Visible = false;
            Klient_Add_button.Visible = false;
            Delete_button.Visible = true;
        }

        private void modificateTabMenu(string getMenu)
        {
            doTable(getMenu);
            Menu_dataGridView.DataSource = ds.Tables[0];
            Menu_dataGridView.Columns[0].Visible = false;
        }
        
        private void Clients_button_Click(object sender, EventArgs e)
        {
            flag = 1;
            updateTabClients();
            Back_button.Visible = true;
            Klient_Add_button.Visible = true;
            Delete_button.Visible = true;
        }

        private void Search_bludo_button_Click(object sender, EventArgs e)
        {
            string SearchBludo = $"select Блюда.id_блюда, Название as 'Название', Вид_блюда as 'Вид', Время_приготовления as 'Время ожидания', Выход_вес as 'Вес порции', Стоимость_блюда as 'Стоимость' from рецепты inner join Блюда on рецепты.id_блюда = Блюда.id_блюда and Название = '{Bluda_textBox.Text}'  order by Время_приготовления";
            modificateTabMenu(SearchBludo);
        }

        private void Clear_button1_Click(object sender, EventArgs e)
        {
            Bluda_textBox.Clear();
            updateTabMenu();
        }

        private void Search_vid_button_Click(object sender, EventArgs e)
        {
            string SearchVid = $"select Блюда.id_блюда, Название as 'Название', Вид_блюда as 'Вид', Время_приготовления as 'Время ожидания', Выход_вес as 'Вес порции', Стоимость_блюда as 'Стоимость'  from рецепты inner join Блюда on рецепты.id_блюда = Блюда.id_блюда and Вид_блюда = '{vid_bluda_textBox.Text}' order by Время_приготовления";
            modificateTabMenu(SearchVid);
        }

        private void Clear_button2_Click(object sender, EventArgs e)
        {
            vid_bluda_textBox.Clear();
            updateTabMenu();
        }

        private void Cost_up_button_Click(object sender, EventArgs e)
        {
            string getDorozhe = $"select Блюда.id_блюда, Название as 'Название', Вид_блюда as 'Вид', Время_приготовления as 'Время ожидания', Выход_вес as 'Вес порции', Стоимость_блюда as 'Стоимость' from рецепты inner join Блюда on рецепты.id_блюда = Блюда.id_блюда order by Стоимость_блюда desc";
            modificateTabMenu(getDorozhe);
        }

        private void Cost_dowm_button_Click(object sender, EventArgs e)
        {
            string getDechevle = $"select Блюда.id_блюда, Название as 'Название', Вид_блюда as 'Вид', Время_приготовления as 'Время ожидания', Выход_вес as 'Вес порции', Стоимость_блюда as 'Стоимость' from рецепты inner join Блюда on рецепты.id_блюда = Блюда.id_блюда order by Стоимость_блюда asc";
            modificateTabMenu(getDechevle);
        }

        int newOrderId;
        private void updateNewOrder()
        {
            string getNewOrder = $"select Блюда.id_блюда, Название, Вид_блюда as 'Вид', Время_приготовления as 'Время ожидания', Стоимость_блюда as 'Стоимость', ФИО as 'Клиент' from рецепты inner join Блюда on рецепты.id_блюда = Блюда.id_блюда inner join Заказ_На_Блюда on Блюда.id_блюда = Заказ_На_Блюда.id_блюда inner join Клиенты on Заказ_На_Блюда.id_Клиента = Клиенты.id_Клиента where Клиенты.id_Клиента = { userId} and Номер_заказа = { newOrderId }"; 
            doTable(getNewOrder);
            NewOrder_dataGridView.DataSource = ds.Tables[0];
        }

        private void Add_inZakaz_button_Click(object sender, EventArgs e)
        {
            if (Choose_Client_combox.Text != "")
            {
                string getClientId = $"select id_Клиента from Клиенты where ФИО = '{Choose_Client_combox.Text}'";

                int client_id = Convert.ToInt32(doRequest(getClientId));
                int bludo_id = Convert.ToInt32(Menu_dataGridView.Rows[0].Cells[0].Value);

                if (flagNewZakaz == 0)
                {
                    string getIdOrder = $"select max(Номер_заказа) from Заказ_На_Блюда";
                    newOrderId = Convert.ToInt32(doRequest(getIdOrder)) + 1;

                    string NewOrderAdd = $"insert into Заказ_На_Блюда values({bludo_id},{client_id},'{DateTime.Now.ToShortDateString()}',{newOrderId})";
                    doNoneRequest(NewOrderAdd);

                    updateNewOrder();
                    flagNewZakaz = 1;
                }
                else
                {
                    string getException = $"select count(id_Клиента) from Заказ_На_Блюда where Номер_заказа = {newOrderId} and id_Клиента = {client_id}";
                    int except = Convert.ToInt32(doRequest(getException));
                    if (except == 1)
                    {
                        MessageBox.Show("Выбранный Клиент уже сделал заказ");
                    }
                    else
                    {
                        string NewOrderAdd = $"insert into Заказ_На_Блюда values({bludo_id},{client_id},'{DateTime.Now.ToShortDateString()}',{newOrderId})";
                        doNoneRequest(NewOrderAdd);
                        updateNewOrder();
                    }
                }
            }
            else { MessageBox.Show("Клиент не выбран"); }
        }

        private void Zakazat_button_Click(object sender, EventArgs e)
        {
            updateTabOrders();
            NewOrder_dataGridView.Columns.Clear();
            Choose_Client_combox.Text = "";
            MessageBox.Show("Заказ оформлен");
        }

        private void Klient_Add_button_Click(object sender, EventArgs e)
        {
            NewClient formNewClient = new NewClient(this, userId);
            formNewClient.Show();
            this.Hide();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(Menu_dataGridView.SelectedRows[0].Cells[0].Value);
            string del = $"delete Клиенты where id_Клиента = {clientId}";
            doNoneRequest(del);
            MessageBox.Show("Выбранный клиент удален");
            updateTabClients();
            updateComboBox();
        }

        private void GoExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            for (int i = 0; i < Menu_dataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j < Menu_dataGridView.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = Menu_dataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
            exApp.UserControl = true;
        }
    }
}
