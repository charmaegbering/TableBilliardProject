using BilyaranBusinessLayer;
using BilyaranCommon;
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
    public partial class ViewTablesForm : Form
    {
        private BilyaranBLServices bilyaranBL = new BilyaranBLServices();
        public ViewTablesForm()
        {
            InitializeComponent();
            dataview1.Columns.Add("ID", "ID");
            dataview1.Columns.Add("TableNumber", "TableNumber");
            dataview1.Columns.Add("PlayerName", "PlayerName");
            dataview1.Columns.Add("Payment", "Payment");

            dataview1.ReadOnly = true;
            dataview1.AllowUserToAddRows = false;
            dataview1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadTablesToGrid();
        }
        private void LoadTablesToGrid()
        {
            dataview1.Rows.Clear();
            List<BTables> tables = bilyaranBL.GetAllTables();

            int id = 1;
            foreach (var table in tables)
            {
                foreach (var player in table.BilyarPlayers)
                {
                    dataview1.Rows.Add(
                        id, table.TableNumber,
                        player.Name,
                        player.Payment);
                    id++;
                }
            }
        }
        public void ReloadTables()
        {
            LoadTablesToGrid();
        }

        private void dataview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataview1.SelectedRows.Count > 0)
            {
                int tableNumber = Convert.ToInt32(dataview1.SelectedRows[0].Cells[1].Value);
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this table?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool removed = bilyaranBL.RemovePlayerFromATable(tableNumber);
                    if (removed)
                    {
                        MessageBox.Show("Table removed successfully.");
                        LoadTablesToGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove table. Please check the input and try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a table to delete.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataview1.SelectedRows.Count > 0)
            {
                int tableNumber = Convert.ToInt32(dataview1.SelectedRows[0].Cells[1].Value);
                string namePlayer = dataview1.SelectedRows[0].Cells[2].Value?.ToString();
                if (!string.IsNullOrEmpty(namePlayer))
                {
                    string newPrice = Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter new payment amount: "
                        , "Update Payment", "0");
                    if (int.TryParse(newPrice, out int newAmount))
                    {
                        bool updated = bilyaranBL.UpdatePayment(tableNumber, namePlayer, newAmount);
                        if (updated)
                        {
                            MessageBox.Show("Payment updated successfully.");
                            LoadTablesToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update payment. Please check the input and try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid payment amount entered.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a player to update.");
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addplayer_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddPTForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    ReloadTables();
                }
            }
        }
    }
}

