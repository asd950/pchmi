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
using System.Configuration;


namespace pchmi
{
    public partial class FormInsertPart : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public FormInsertPart()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string mark = tbMark.Text;
                string model = tbModel.Text;
                string price = tbPrice.Text;
                string name = tbName.Text;
                string sqlExpression = String.Format("INSERT INTO Parts (mark, model, price, name) " +
                                                    "VALUES ('{0}', '{1}', '{2}', '{3}')",
                                                    mark, model, price, name);
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                if (number > 0) MessageBox.Show("Вы добавили запчасть в базу!");
                else MessageBox.Show("Ошибка!");
            }
        }


    }
}
