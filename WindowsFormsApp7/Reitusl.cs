using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp7
{
    public partial class Reting : Form
    {
        public Reting()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reit_Click(object sender, EventArgs e)
        {
            reit.Titles.Clear();
            reit.Series.RemoveAt(0);
            reit.Palette = ChartColorPalette.SeaGreen;
            string diagTitle = "Рейтинг услуг";
            reit.Titles.Add(diagTitle);

            Series s1 = new Series("Услуги");
            s1.Color = Color.Bisque;
            string SQL_text = "SELECT u.naim, count(ou.Id) as kol FROM Uslugi u, OkazanieUslug ou WHERE ou.id_usl=u.kod" + "AND ou.data >= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "AND ou.data <= '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' GROUP BY u.naim";
            SqlConnection con1 = new SqlConnection(Data.Glob_connection_string);
            con1.Open();
            SqlCommand com1 = new SqlCommand(SQL_text, con1);
            SqlDataReader dr = com1.ExecuteReader();

            string naim = "";
            int kol = 0;
            while (dr.Read())
            {
                naim = Convert.ToString(dr["naim"]);
                kol = Convert.ToInt32(dr["kol"]);
                s1.Points.AddXY(naim, kol);
            }
            dr.Close();
            con1.Close();
            reit.Series.Add(s1);

        }
    }
}
