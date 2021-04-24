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
    public partial class AutoCatalogForm : Form
    {
        Dlg d;
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AutoCatalogForm( Dlg sender)
        {
            InitializeComponent();
            d = sender;
            string sqlExpression = "SELECT * FROM Cars";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            new OrderAutoForm().Show();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           if(dataGridView1.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int selectedIndex = dataGridView1.CurrentRow.Index;
                    int autoID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    string sqlExpression = String.Format("DELETE FROM Cars WHERE autoID = {0} ", autoID);
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    if (number > 0) MessageBox.Show("Вы удалили авто из базы!");
                }
            }
        }

        private void buttonParts_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = dataGridView1.CurrentCell.RowIndex;
            string str = String.Format("{0}, {1}, {2}, {3}, {4}, {5}", dataGridView1.Rows[rowInd].Cells[1].Value.ToString().Replace(" ", ""),
                dataGridView1.Rows[rowInd].Cells[2].Value.ToString().Replace(" ", ""),
            dataGridView1.Rows[rowInd].Cells[3].Value.ToString().Replace(" ", ""),
                dataGridView1.Rows[rowInd].Cells[4].Value.ToString().Replace(" ", ""),
                dataGridView1.Rows[rowInd].Cells[5].Value.ToString().Replace(" ", ""),
                dataGridView1.Rows[rowInd].Cells[6].Value.ToString().Replace(" ", ""));
            d(str);
        }
    }
}
