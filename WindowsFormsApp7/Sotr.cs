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

    public partial class Sotr : Form
    {
        string nom;
        public Sotr()
        {
            InitializeComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
                textBox1.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox2.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox3.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                dateTime1.Value = Convert.ToDateTime(dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString());
                dateTime2.Value = Convert.ToDateTime(dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString());
                nom = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                dob.Enabled = false;
                izmen.Enabled = true;
            
                      
        }
       
        private void UpdateGrid()
        {
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQL = "Select * from Sotr";

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection1);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            dataGridView1.Refresh();
            dataGridView1.DataSource = tb;
            dataGridView1.Columns[0].HeaderText = "N";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].HeaderText = "Датарожд.";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "Должность";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Специализация";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "Проф.деят-тьс";
            dataGridView1.Columns[5].Width = 130;
            connection1.Close();
        }
        private void Sotr_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQL_izm = "UPDATE Sotr set fio=N'" + textBox1.Text +
            "', data_rozd='" + dateTime1.Value.ToString("yyyy-MM-dd") +
            "', dolg = N'" + textBox2.Text +
            "', spec = N'" + textBox3.Text +
            "', data_npd = '" + dateTime2.Value.ToString("yyyy-MM-dd") + "' WHERE Id=" + nom;

            SqlCommand command1 = new SqlCommand(SQL_izm, connection1);
            SqlDataReader dr = command1.ExecuteReader();
            connection1.Close();

        }

        private void dob_Click(object sender, EventArgs e)
        {
           
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQL_dob_VetKlin = "INSERT INTO Sotr(fio,data_rozd,dolg, spec, data_npd) values (N'" + textBox1.Text + "', '" + dateTime1.Value.ToString("yyyy-MM-dd")
                            + "', N'" + textBox2.Text + "', N'" + textBox3.Text + "', '" + dateTime1.Value.ToString("yyyy-MM-dd") + "')";
            MessageBox.Show(SQL_dob_VetKlin);
            SqlCommand command1 = new SqlCommand(SQL_dob_VetKlin, connection1);
            SqlDataReader dr = command1.ExecuteReader();

            dr.Close();
            connection1.Close();

            UpdateGrid();


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
