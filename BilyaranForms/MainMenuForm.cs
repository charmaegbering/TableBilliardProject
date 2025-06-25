using System;
using Microsoft.VisualBasic;
using BilyaranCommon;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilyaranForms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            TablesForm TForms = new TablesForm();
            TForms.Show();
        }
    }
}
