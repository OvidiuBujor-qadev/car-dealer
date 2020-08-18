using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataGridView carsDataGridView = new DataGridView();
        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();

            SetupDataGridView();
        }
        private void SetupLayout()
        {
            this.Size = new Size(600, 500);
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(carsDataGridView);

            carsDataGridView.ColumnCount = 13;

            carsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            carsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            carsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(carsDataGridView.Font, FontStyle.Bold);

            carsDataGridView.Name = "carsDataGridView";
            carsDataGridView.Location = new Point(8, 8);
            carsDataGridView.Size = new Size(500, 250);
            carsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            carsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            carsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            carsDataGridView.GridColor = Color.Black;
            carsDataGridView.RowHeadersVisible = false;

            carsDataGridView.Columns[0].Name = "Brand";
            carsDataGridView.Columns[1].Name = "Model";
            carsDataGridView.Columns[2].Name = "Price";
            carsDataGridView.Columns[3].Name = "Park";
            carsDataGridView.Columns[4].Name = "Hp";
            carsDataGridView.Columns[5].Name = "Color";
            carsDataGridView.Columns[6].Name = "Year";
            carsDataGridView.Columns[7].Name = "Km";
            carsDataGridView.Columns[8].Name = "Engine";
            carsDataGridView.Columns[9].Name = "Fuel";
            carsDataGridView.Columns[10].Name = "Type";
            carsDataGridView.Columns[11].Name = "Condition";
            carsDataGridView.Columns[12].Name = "Doors";
            carsDataGridView.Columns[12].DefaultCellStyle.Font =
                new Font(carsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            carsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            carsDataGridView.MultiSelect = false;
            carsDataGridView.Dock = DockStyle.Fill;
        }
    }
}
