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
    public partial class FormParts : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        Dlg d;
        public FormParts(Dlg sender)
        {
            InitializeComponent();
            d = sender;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //AutoCatalogForm autoCatalog = new AutoCatalogForm();

                string sqlExpression = "SELECT * FROM Parts";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewParts.DataSource = ds.Tables[0];
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            new FormInsertPart().Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int selectedIndex = dataGridViewParts.CurrentRow.Index;
                    int id = int.Parse(dataGridViewParts[0, selectedIndex].Value.ToString());
                    dataGridViewParts.Rows.Remove(dataGridViewParts.CurrentRow);
                    string sqlExpression = String.Format("DELETE FROM Parts WHERE id = {0} ", id);
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    if (number > 0) MessageBox.Show("Вы удалили запчасть из базы!");
                    else MessageBox.Show("Ошибка!");
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string mark = tbMark.Text;
                string model = tbModel.Text;
                string sqlExpression = String.Format("SELECT * FROM Parts WHERE mark = '{0}' AND model = '{1}'",
                                                    mark, model);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewParts.DataSource = ds.Tables[0];
            }
        }

        private void dataGridViewParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = dataGridViewParts.CurrentCell.RowIndex;
            string str = String.Format("{0}, {1}, {2}, {3}",dataGridViewParts.Rows[rowInd].Cells[1].Value.ToString(),
                dataGridViewParts.Rows[rowInd].Cells[2].Value.ToString().Replace(" ", ""),
            dataGridViewParts.Rows[rowInd].Cells[3].Value.ToString().Replace(" ", ""),
                dataGridViewParts.Rows[rowInd].Cells[4].Value.ToString().Replace(" ", "")) ;
            d(str);
        }
    }
}
