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
    public partial class FormSuppliers : Form
    {
        
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public FormSuppliers()
        {
            
            InitializeComponent();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Suppliers", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewSuppliers.DataSource = ds.Tables[0];
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           
                if (dataGridViewSuppliers.CurrentRow != null)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        int selectedIndex = dataGridViewSuppliers.CurrentRow.Index;
                        int id = int.Parse(dataGridViewSuppliers[0, selectedIndex].Value.ToString());
                        dataGridViewSuppliers.Rows.Remove(dataGridViewSuppliers.CurrentRow);
                        string sqlExpression = String.Format("DELETE FROM Suppliers WHERE id = {0} ", id);
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int number = command.ExecuteNonQuery();
                        if (number > 0) MessageBox.Show("Вы удалили заявку из базы!");
                        else MessageBox.Show("Ошибка!");
                    }
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("dogovor.doc");
        }
    }
}
