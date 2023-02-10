using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BistroVersion2
{
    public partial class NewClient : Form
    {
        User_Form user_Form;
        int userId;
        public NewClient(User_Form form, int id)
        {
            InitializeComponent();
            user_Form = form;
            userId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fio_tb.Text != "" && phone_tb.Text != "")
            {
                string newClient = $"insert into Клиенты values((select max(id_Клиента) + 1 from Клиенты), {layalnost_card_tb.Text}, '{fio_tb.Text}', '{phone_tb.Text}', {id_tb.Text})";
                user_Form.doNoneRequest(newClient);
                user_Form.updateTabClients();
                user_Form.updateComboBox();
                MessageBox.Show("Клиент успешно добавлен");
                this.Hide();
                user_Form.Show();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void NewClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            user_Form.Show();
        }
    }
}
