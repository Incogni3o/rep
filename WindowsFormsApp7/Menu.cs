using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Sotr fs = new Sotr();
            fs.ShowDialog();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
           
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uslugi fs = new Uslugi();
            fs.ShowDialog();
        }

        private void оказаниеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkazanieUslug fs = new OkazanieUslug();
            fs.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client fs = new Client();
            fs.ShowDialog();
        }

        private void данныеОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DannieOrg fs = new DannieOrg();
            fs.ShowDialog();
        }

        private void рейтингУслугЗаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reting fs = new Reting();
            fs.ShowDialog();
        }
    }
}
