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
    public partial class dobClient : Form
    {
        private Func<string> selecteddobClient;

        public dobClient()
        {
            InitializeComponent();
        }

        private void dataGridHoz1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridHoz1.Columns[0].HeaderText = "N";
            dataGridHoz1.Columns[0].Width = 30;
            dataGridHoz1.Columns[1].HeaderText = "ФИО";
            dataGridHoz1.Columns[1].Width = 170;
            dataGridHoz1.Columns[2].HeaderText = "Телефон";
            dataGridHoz1.Columns[2].Width = 80;
            dataGridHoz1.Columns[3].HeaderText = "Адрес";
            dataGridHoz1.Columns[3].Width = 170;
            dataGridHoz1.Columns[4].HeaderText = "Эл.почта";
            dataGridHoz1.Columns[4].Width = 100;
            dataGridHoz1.Columns[5].HeaderText = "Паспортные данные";
            dataGridHoz1.Columns[5].Width = 200;

            selecteddobClient = dataGridHoz1[0, dataGridHoz1.CurrentRow.Index].Value.ToString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();
        }
    }
}
