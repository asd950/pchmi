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
    public partial class AutorizeForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AutorizeForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            (new RegistrForm()).Show();
            this.Hide();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            int user;
            //MessageBox.Show("Неправильный логин или пароль!");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = String.Format(
                    "SELECT * FROM Users WHERE login = '{0}' AND password = '{1}'",
                    login, password);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    
                        if ((reader.GetString(1).Replace(" ", "") == login) && (reader.GetString(2).Replace(" ", "") == password))
                        {
                        var ID = reader.GetValue(0);
                        int id = Convert.ToInt32(ID);
                            (new StaffForm(id)).Show();
                            this.Hide();
                        }
                       
                    
                    reader.Close();

                    
                }
                else if (login == "" || password == "")
                {
                    MessageBox.Show("Введите данные!");
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
                
            }
        }
    }
}
