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
    public partial class Shef_Form : Form
    {
        public Shef_Form()
        {
            InitializeComponent();
        }

        private void Shef_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college2.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter1.Fill(this.dataSet_college2.Блюда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college2.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter1.Fill(this.dataSet_college2.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_college2.рецепты". При необходимости она может быть перемещена или удалена.
            this.рецептыTableAdapter1.Fill(this.dataSet_college2.рецепты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            //this.блюдаTableAdapter.Fill(this.samoilovBistroDataSet.Блюда);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            //this.продуктыTableAdapter.Fill(this.samoilovBistroDataSet.Продукты);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "samoilovBistroDataSet.рецепты". При необходимости она может быть перемещена или удалена.
            //this.рецептыTableAdapter.Fill(this.samoilovBistroDataSet.рецепты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_form form = new Login_form();
            form.Show();
            this.Hide();
        }
    }
}
