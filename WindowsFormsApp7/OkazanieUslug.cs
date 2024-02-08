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
    public partial class OkazanieUslug : Form
    {
        private Excel.Application excel_app;

        public OkazanieUslug()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            MessageBox.Show("Update grid");
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQL = "SELECT ok.id, ok.data, a.nom_pasp, a.klichka, a.vid, "
                + "s.fio, u.naim, ok.komment "
                + "from OkazanieUslugi as ok, Givotnie as a, Sotr as s, Uslugi as u "
                + "WHERE ok.id = a.id AND ok.id_sotr = s.id AND ok.kod = u.id";

           // MessageBox.Show(SQL);
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection1);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            dataGrid1.Refresh();
            dataGrid1.DataSource = tb;
            dataGrid1.Columns[0].HeaderText = "Ном.пасп.";
            dataGrid1.Columns[0].Width = 20;
            dataGrid1.Columns[1].HeaderText = "Дата";
            dataGrid1.Columns[1].Width = 70;
            dataGrid1.Columns[2].HeaderText = "Ном.пасп";
            dataGrid1.Columns[2].Width = 70;
            dataGrid1.Columns[3].HeaderText = "Кличка";
            dataGrid1.Columns[3].Width = 60;
            dataGrid1.Columns[4].HeaderText = "Вид";
            dataGrid1.Columns[4].Width = 60;
            dataGrid1.Columns[5].HeaderText = "Сотрудник";
            dataGrid1.Columns[5].Width = 100;
            dataGrid1.Columns[6].HeaderText = "Услуга";
            dataGrid1.Columns[6].Width = 110;
            dataGrid1.Columns[7].HeaderText = "Комментарий";
            dataGrid1.Columns[7].Width = 90;

            connection1.Close();
        }

        private void ZapoInCombo()
        {
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQL_text = "SELECT id, (a.nom_pass +':'+a.klichka +':'+a.vid) as Givotnie FROM Givotnie as a";
            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();
            SqlDataAdapter da = new SqlDataAdapter(SQL_text, connection1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            givotnoe.DataSource = dt;
            givotnoe.DisplayMember = "givotnie";
            givotnoe.ValueMember = "id";
            connection1.Close();

            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            SQL_text = "SELECT kod, naim FROM Uslugi";
            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();
            da = new SqlDataAdapter(SQL_text, connection1);
            dt = new DataTable();
            da.Fill(dt);
            uslugi.DataSource = dt;
            uslugi.DisplayMember = "naim";
            uslugi.ValueMember = "kod";
            connection1.Close();

            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            SQL_text = "SELECT id, fio FROM Sotr";
            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();
            da = new SqlDataAdapter(SQL_text, connection1);
            dt = new DataTable();
            da.Fill(dt);
            sotr.DataSource = dt;
            sotr.DisplayMember = "fio";
            sotr.ValueMember = "id";
            connection1.Close();
        }

        private void OkazanieUslug_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ZapoInCombo();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            string SQL_insOk = "SELECT max(id) as max FROM Uslugi";
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            SqlCommand command1 = new SqlCommand(SQL_insOk, connection1);
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

            SQL_insOk = "INSERT INTO Uslugi(id,data,id_givot,id_usl,id_sotr,komment) values (" + max + ",N'" + dataline.Value.ToString("yyyy-MM-dd") + "',N'" + givotnoe.SelectedValue + "','" + uslugi.SelectedValue
                + "',N'" + sotr.SelectedValue + "',N'" + komment.Text + "')";
            MessageBox.Show(SQL_insOk);
            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();
            command1 = new SqlCommand(SQL_insOk, connection1);
            dr = command1.ExecuteReader();
            dr.Close();
            connection1.Close();
            MessageBox.Show("Данные сохранены");
            UpdateGrid();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            excel_app = new Excel.Application
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            excel_app.Workbooks.Add(Type.Missing);

            Excel.Range _excelCells = (Excel.Range)excel_app.get_Range("A1", "F1").Cells;
            _excelCells.Merge(Type.Missing);
            _excelCells = (Excel.Range)excel_app.get_Range("A2", "F2").Cells;
            _excelCells.Merge(Type.Missing);
            _excelCells = (Excel.Range)excel_app.get_Range("A3", "F3").Cells;
            _excelCells.Merge(Type.Missing);
            _excelCells = (Excel.Range)excel_app.get_Range("A4", "F4").Cells;
            _excelCells.Merge(Type.Missing);
            _excelCells = (Excel.Range)excel_app.get_Range("A5", "F5").Cells;
            _excelCells.Merge(Type.Missing);

            excel_app.Cells[1, 1].Value = "Наименование: " + "dk_naim";
            excel_app.Cells[2, 1].Value = "Адрес: " + "dk_adres";
            excel_app.Cells[3, 1].Value = "ИНН: " + "dk_inn";
            excel_app.Cells[4, 1].Value = "Р.сч.: " + "dk_rs";
            excel_app.Cells[5, 1].Value = "Телефон: " + "dk_naim";

            _excelCells = (Excel.Range)excel_app.get_Range("A7", "F7").Cells;
            _excelCells.Merge(Type.Missing);
            excel_app.Cells[7, 1].Value = "Квитанция на оплату ветеринарных услуг";
            excel_app.Cells[7, 1].Font.Bold = true;
            excel_app.Cells[7, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            _excelCells = (Excel.Range)excel_app.get_Range("A8", "F8").Cells;
            _excelCells.Merge(Type.Missing);
            excel_app.Cells[8, 1].Value = "Потребитель: ";

            //таблица 
            excel_app.Cells[9, 1].Value = "Вид услуги";
            excel_app.Columns[1].columnwidth = 30;

            excel_app.Cells[9, 2].Value = "Количество";
            excel_app.Columns[2].columnwidth = 10;

            excel_app.Cells[9, 3].Value = "Ед.изм.";
            excel_app.Columns[3].columnwidth = 10;

            excel_app.Cells[9, 4].Value = "Цена";
            excel_app.Columns[4].columnwidth = 12;

            excel_app.Cells[9, 5].Value = "Стоимость";
            excel_app.Columns[5].columnwidth = 12;


            int i;
            for (i = 1; i <= 5; i++)
            {
                excel_app.Cells[9, i].Font.Size = 11;
                excel_app.Cells[9, i].Font.Bold = true;
                excel_app.Cells[9, i].Borders.LineStyle = 1;
                excel_app.Cells[9, i].Borders.Weight = Excel.XlBorderWeight.xlThick;
            }

            string SQL_text = "SELECT O.id, O.data, U.naim, U.cena " +
                "FROM OkazanieUslugi O, USLUGI U  WHERE " +
                "O.id_usl = U.kod AND O.Id = " + "id_okaz_usl";
            MessageBox.Show(SQL_text);
            SqlConnection con1 = new SqlConnection(Data.Glob_connection_string);
            con1.Open();

            SqlCommand comm = new SqlCommand(SQL_text, con1);
            SqlDataReader dr = comm.ExecuteReader();
            i = 10;
            decimal itog_summa = 0;
            string myData = "";
            while (dr.Read())
            {
                //excel_app.Cells[i, 1].Value = i - 9;
                excel_app.Cells[i, 1].Value = String.Format("{0}", dr["naim"]);
                excel_app.Cells[i, 2].Value = String.Format("{0}", "1");
                excel_app.Cells[i, 3].Value = String.Format("{0}", "шт.");
                excel_app.Cells[i, 4].Value = String.Format("{0}", dr["cena"]);
                excel_app.Cells[i, 5].Value = String.Format("{0}", dr["cena"]);

                myData = String.Format("{0}", dr["data"]);

                Excel.Range curr_cells = (Excel.Range)excel_app.get_Range("A" + i, "E" + i).Cells;
                curr_cells.Font.Size = 11;
                curr_cells.Borders.LineStyle = 1;

                itog_summa = itog_summa + Convert.ToDecimal(dr["cena"]);
                i = i + 1;
            }

            excel_app.Cells[i, 4].Value = "ИТОГО";
            excel_app.Cells[i, 4].Font.Size = 11;
            excel_app.Cells[i, 4].Borders.LineStyle = 1;
            excel_app.Cells[i, 5].Value = itog_summa;
            excel_app.Cells[i, 5].Font.Size = 11;
            excel_app.Cells[i, 5].Borders.LineStyle = 1;

            i += 1;
            _excelCells = (Excel.Range)excel_app.get_Range("A" + i, "F" + i).Cells;
            _excelCells.Merge(Type.Missing);
            excel_app.Cells[i, 1].Value = "Итого оплачено потребителем: ";

            i += 1;
            _excelCells = (Excel.Range)excel_app.get_Range("A" + i, "F" + i).Cells;
            _excelCells.Merge(Type.Missing);
            excel_app.Cells[i, 1].Value = "наличными д.с.: ";

            i += 1;
            _excelCells = (Excel.Range)excel_app.get_Range("A" + i, "F" + i).Cells;
            _excelCells.Merge(Type.Missing);
            excel_app.Cells[i, 1].Value = "с использованием платежных карт: ";

            i += 1;
            _excelCells = (Excel.Range)excel_app.get_Range("A" + i, "F" + i).Cells;
            _excelCells.Merge(Type.Missing);
            excel_app.Cells[i, 1].Value = "Потребитель: ____________  _______________ " + myData;

            dr.Close();
            con1.Close();
        }

    }
}

