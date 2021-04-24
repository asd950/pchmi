using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace pchmi
{
    public partial class OrderAutoForm : Form
    {
        string stringConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public OrderAutoForm()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string mark = tbMark.Text;
            string model = tbModel.Text;
            string date = tbDate.Text;
            string complectation = tbComplectation.Text;
            string color = tbColor.Text;
            string price = tbPrice.Text;

           using(SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string sqlExpression = String.Format("INSERT INTO Cars (mark, model, date, complectation, color, price)" +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", mark, model, date, complectation, color, price);

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                if (number > 0) MessageBox.Show("Вы добавили авто в базу!");
                else MessageBox.Show("Ошибка!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
