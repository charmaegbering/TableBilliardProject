using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilyaranBusinessLayer;
using BilyaranCommon;

namespace FormsBilliard
{
    public partial class DisplayTForm : Form
    {
        private BilyaranBLServices bilyaranBL = new BilyaranBLServices();
        public DisplayTForm()
        {
            InitializeComponent();
            dataview2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataview2.MultiSelect = false;
            dataview2.ReadOnly = true;
            dataview2.AllowUserToAddRows = false;
            dataview2.RowHeadersVisible = false;
            dataview2.ClearSelection();
            ToGrid();
            dataview2.SelectionChanged += dataview2_ChangeChoice;
        }
        private void ToGrid()
        {
            dataview2.Rows.Clear();
            var tables = bilyaranBL.GetAllTables();

            for (int i = 1; i <= 4; i++)
            {
                var table = tables.FirstOrDefault(t => t.TableNumber == i);
                bool isOccupied = table != null && table.BilyarPlayers != null && table.BilyarPlayers.Count > 0;
                string status = isOccupied ? "In Use" : "Available";
                string availability = isOccupied ? "Not Available" : "Available";

                int rowIndex = dataview2.Rows.Add(i.ToString(), status, availability);

                if (isOccupied)
                {
                    dataview2.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dataview2.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }
        }
        private void dataview2_ChangeChoice(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataview2.SelectedRows)
            {
                if (row.Cells["cmn_stats"].Value?.ToString() == "In Use")
                {
                    row.Selected = false;
                }
            }
        }



        private void dataview2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            AddPTForm addplayertable = new AddPTForm();
            addplayertable.ShowDialog();
        }
    }
}
