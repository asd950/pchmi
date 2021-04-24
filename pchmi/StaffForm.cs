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
    public partial class StaffForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public StaffForm()
        {
            InitializeComponent();
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string sqlExpression = "select * from Cars";
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    //command.ExecuteNonQuery();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        comboBox1.Items.Add(reader["name"]);
            //    }
            //}
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string name = tbName.Text;
                string phone = tbPhone.Text;
                string email = tbEmail.Text;

                string sqlExpression = String.Format(
                    "INSERT INTO Suppliers (name, phone_number, email)" +
                    "VALUES ('{0}', '{1}', '{2}')", name, phone, email);
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Вы создали заявку!");
            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchAuto_Click(object sender, EventArgs e)
        {
            AutoCatalogForm f = new AutoCatalogForm(new Dlg(func));
            f.ShowDialog();
        }
        void func (string param)
        {
            textBox1.Text = param;
        }
        private void buttonSuppliers_Click(object sender, EventArgs e)
        {

            new FormSuppliers().Show();
        }

        private void StaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonParts_Click(object sender, EventArgs e)
        {
            FormParts f1 = new FormParts(new Dlg(func));
            f1.ShowDialog();
        }
    }
}
