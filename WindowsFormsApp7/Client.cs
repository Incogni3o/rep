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

namespace WindowsFormsApp7
{
    public partial class Client : Form
    {
        string selectedHoz;
        public Client()
        {
            InitializeComponent();
        }

        
        private void dataGridHoz_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            selectedHoz = dataGridHoz[0, dataGridHoz.CurrentRow.Index].Value.ToString();
            dataGridHoz.Columns[0].HeaderText = "N";
            dataGridHoz.Columns[0].Width = 30;
            dataGridHoz.Columns[1].HeaderText = "ФИО";
            dataGridHoz.Columns[1].Width = 170;
            dataGridHoz.Columns[2].HeaderText = "Телефон";
            dataGridHoz.Columns[2].Width = 80;
            dataGridHoz.Columns[3].HeaderText = "Адрес";
            dataGridHoz.Columns[3].Width = 170;
            dataGridHoz.Columns[4].HeaderText = "Эл.почта";
            dataGridHoz.Columns[4].Width = 100;
            dataGridHoz.Columns[5].HeaderText = "Паспортные данные";
            dataGridHoz.Columns[5].Width = 200;
        }

        private void poisk_Click(object sender, EventArgs e)
        {
            string SQL_text = "SELECT * FROM Client WHERE fio LIKE N'%" + fio.Text + "%'AND phone LIKE N'%" + phone.Text + "%'";
            SqlConnection con1 = new SqlConnection(Data.Glob_connection_string);
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter(SQL_text, con1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridHoz.Refresh();
            dataGridHoz.DataSource = dt;


            
            con1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dobClient F1 = new dobClient();
            F1.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView2[3, dataGridView2.CurrentRow.Index].Value.ToString();
            //nom = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            button3.Enabled = false;
            button4.Enabled = true;
        }
    }
}
