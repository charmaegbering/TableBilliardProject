using BilyaranBusinessLayer;
using BilyaranServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBilliard
{
    public partial class BilyarMenuForm : Form
    {
        private BilyaranBLServices bilyaranBL = new BilyaranBLServices();
        public BilyarMenuForm()
        {
            InitializeComponent();
        }

        private void BilyarMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            AddPTForm addplayertable = new AddPTForm();
            addplayertable.ShowDialog();

            ViewTablesForm viewTables = new ViewTablesForm();
            viewTables.ShowDialog();

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            DisplayTForm displayTable = new DisplayTForm();
            displayTable.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
