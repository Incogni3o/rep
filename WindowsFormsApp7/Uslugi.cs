using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Uslugi : Form
    {
        public Uslugi()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQLUslugi = "Select * from Uslugi";

            SqlDataAdapter adapter = new SqlDataAdapter(SQLUslugi, connection1);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            dataGridView1.Refresh();
            dataGridView1.DataSource = tb;
            dataGridView1.Columns[0].HeaderText = "N";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].Width = 557;
            dataGridView1.Columns[2].HeaderText = "Цена";
            dataGridView1.Columns[2].Width = 127;
            connection1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nameusl.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            cena.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            //nom = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            but1.Enabled = false;
            but2.Enabled = true;

        }
        private string change_comma(string s)
        {
            int pos = s.IndexOf(",");
            if (pos > 0)
            {
                s = s.Substring(0, pos) + "." + s.Substring(pos + 1, 2);
            }
            return s;      
        }

        private void Uslugi_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQLUsl = "Select * from Uslugi";

            SqlDataAdapter adapter = new SqlDataAdapter(SQLUsl, connection1);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            dataGridView1.Refresh();
            dataGridView1.DataSource = tb;
            dataGridView1.Columns[0].HeaderText = "N";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].Width = 557;
            dataGridView1.Columns[2].HeaderText = "Цена";
            dataGridView1.Columns[2].Width = 127;
            connection1.Close();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            string SQL_InsUsl = "SELECT max(id) as max FROM Sotr";
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            SqlCommand command1 = new SqlCommand(SQL_InsUsl, connection1);
            SqlDataReader dr = command1.ExecuteReader();
            string max = "";
            int max2 = 0;
            while (dr.Read())
            {
                max = string.Format("{0}", dr["max"]);
            }
            dr.Close();
            connection1.Close();
            if (max == "") { max2 = 1; }
            else { max2 = Convert.ToInt32(max) + 1; }
            max = Convert.ToString(max2);

            SQL_InsUsl = "INSERT INTO uslugi(id,naim,cena) values (" + max + ",N'" + nameusl.Text + "',N'" + change_comma(cena.Text) + "')";
            MessageBox.Show(SQL_InsUsl);
            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();
            command1 = new SqlCommand(SQL_InsUsl, connection1);
            dr = command1.ExecuteReader();
            dr.Close();
            connection1.Close();
            MessageBox.Show("Данные сохранены");
            UpdateGrid();
        }

       
    }
}
