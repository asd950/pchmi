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
    public partial class RegistrForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            (new AutorizeForm()).Show();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            string name = tbName.Text;
            string phone_number = tbPhoneNumber.Text;
            string email = tbEmail.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = String.Format("INSERT INTO Users (login, password, name, " +
                                                    "phone_number, email)" +
                                                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                                    login, password, name, phone_number, email);
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Пользователь зарегистрирован!");
            new AutorizeForm().Show();
            this.Close();
        }
    }
}
