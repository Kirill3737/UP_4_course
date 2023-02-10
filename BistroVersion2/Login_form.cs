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
    public partial class Login_form : Form
    {
        string connection = Properties.Resources.Connection;
        public Login_form()
        {
            InitializeComponent();
            password_textBox.PasswordChar = '*';
        }

        private void vhod (int c)
        {
            if (c == 0)
            {
                MessageBox.Show("Введенные данные не верны");
            }
            else
            {
                try
                {
                    SqlConnection MyConnect = new SqlConnection(connection);
                    string getRoleReq = $"select роль from Пользователи where логин = '{login_textBox.Text}'";
                    string getId = $"select id_пользователя from Пользователи where логин = '{login_textBox.Text}'";
                    SqlCommand cmdForGetRole = new SqlCommand(getRoleReq, MyConnect);
                    SqlCommand cmdForGetId = new SqlCommand(getId, MyConnect);
                    MyConnect.Open();
                    string role = cmdForGetRole.ExecuteScalar().ToString();
                    int id = Convert.ToInt32(cmdForGetId.ExecuteScalar().ToString());
                    switch (role)
                    {
                        case "пользователь":
                            {
                                User_Form user_Form = new User_Form(id, login_textBox.Text);
                                user_Form.Show();
                                this.Hide();
                                break;
                            }
                        case "админ":
                            {
                                Admin_Form admin_Form = new Admin_Form();
                                admin_Form.Show();
                                this.Hide();
                                break;
                            }
                        case "шеф":
                            {
                                Shef_Form shef_Form = new Shef_Form();
                                shef_Form.Show();
                                this.Hide();
                                break;
                            }
                        //case "официант":
                        //    {
                        //        Ofiziant_Form ofiziant_Form = new Ofiziant_Form();
                        //        ofiziant_Form.Show();
                        //        this.Hide();
                        //        break;
                        //    }
                        default:
                            {
                                MessageBox.Show("Ошибка данных");
                                break;
                            }
                    }
                    MyConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Log_in_button_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnect = new SqlConnection(connection);
            string EnterReq = "select count(*) from Пользователи where логин= '" + login_textBox.Text + "' and пароль= '" + password_textBox.Text + "'";
            SqlCommand comEnter = new SqlCommand(EnterReq, MyConnect);
            MyConnect.Open();
            int check = Convert.ToInt32(comEnter.ExecuteScalar());
            vhod(check);
            MyConnect.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password_textBox.PasswordChar = '\0';
            }
            else
            {
                password_textBox.PasswordChar = '*';
            }
        }
    }
}
