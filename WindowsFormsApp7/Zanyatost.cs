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
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp7
{

    public partial class Zanyat : Form
    {
        private Excel.Application excel_app;
        public Zanyat()
        {
            InitializeComponent();
        }

        private void formEX_Click(object sender, EventArgs e)
        {
            excel_app = new Excel.Application();
            excel_app.Visible = true;
            excel_app.SheetsInNewWorkbook = 1;
            excel_app.Workbooks.Add(Type.Missing);

            Excel.Range _excelCells = (Excel.Range)excel_app.get_Range("A1", "E1").Cells;
            _excelCells.Merge(Type.Missing);

            excel_app.Cells[1, 1].Value = "Занятость специалиста Иванов Петр Андреевич" + "за период с" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "no" + dateTimePicker2.Value.ToString("yyyy-MM-dd");

            excel_app.Cells[1, 1].Font.Bold = true;
            excel_app.Cells[1, 1].Font.Size = 16;
            excel_app.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            excel_app.Cells[2, 1].Value = "N";
            excel_app.Columns[1].columneidth = 6;

            excel_app.Cells[2, 2].Value = "Дата";
            excel_app.Columns[2].columneidth = 20;

            excel_app.Cells[2, 3].Value = "Животное";
            excel_app.Columns[3].columneidth = 30;

            excel_app.Cells[2, 4].Value = "Услуга";
            excel_app.Columns[4].columneidth = 50;

            excel_app.Cells[2, 5].Value = "Комментарий";
            excel_app.Columns[5].columneidth = 35;

            for (int i = 1; i <= 5; i++)
            {
                excel_app.Cells[2, i].Font.Size = 14;
                excel_app.Cells[2, i].Font.Italic = true;
                excel_app.Cells[2, i].Font.Bold = true;
                excel_app.Cells[2, i].Borders.LineStyle = 1;
                excel_app.Cells[2, i].Borders.Weight = Excel.XlBorderWeight.xlThick;
                excel_app.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }

            string SQL_text = "SELECT OkazanieUslug.id, OkazanieUslug.data, Givotnie.nom_pasp + '/' + Givotnie.klichka as giv" + "Uslugi.naim, OkazanieUslug.komment" + "FROM OkazanieUslug, USLUGI, Givotnie" + "WHERE (OkazanieUslug.id_usl = Uslugi.kod) AND" + "(OkazanieUslug.id_givot = Givotnie.id) AND" + "(OkazanieUslug.data <= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "') AND (OkazanieUslug.data <= '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')";

            SqlConnection con1 = new SqlConnection(Data.Glob_connection_string);
            con1.Open();

            SqlCommand comm = new SqlCommand(SQL_text, con1);
            SqlDataReader dr = comm.ExecuteReader();
            int j = 3;
            int itogo = 0;
            while (dr.Read())
            {
                excel_app.Cells[j, 1].Value = String.Format("{0}", j - 3);
                excel_app.Cells[j, 1].Value = String.Format("{0}", dr["data"]);
                excel_app.Cells[j, 1].Value = String.Format("{0}", dr["giv"]);
                excel_app.Cells[j, 1].Value = String.Format("{0}", dr["naim"]);
                excel_app.Cells[j, 1].Value = String.Format("{0}", dr["komment"]);

                Excel.Range curr_cells = (Excel.Range)excel_app.get_Range("A" + j, "E" + j).Cells;
                curr_cells.Font.Size = 12;
                curr_cells.Borders.LineStyle = 1;

                itogo = itogo + 1;
                j = j + 1;

            }
            dr.Close();
            con1.Close();
        }
    }
}
