using System;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private AddCarForm addCarForm;
        private TabPage TabPageCars;
        private TabPage TabPageConfigurator;
        private TabPage TabPageFinancial;
        private TabPage TabPageAdmin;
        private TabPage TabPageReports;
       
        private Button ButtonIncoming;
        private Button ButtonOutgoing;

        private DataGridView carsDataGridView = new DataGridView();
        private DataGridView reportsDataGridView = new DataGridView();
        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
            addCarForm = new AddCarForm();
        }

        private void LoadData() {
            using (var connection = new SqlConnection(
                   "Server=AVG-188;" +
                   "Database=Cars; Integrated Security=True;" +
                   "TrustServerCertificate=False;Connection Timeout=30;"
                   ))
            {
                connection.Open();

                var queryString = "SELECT Brand, Model, Price, Park, Hp, Color, Year, Km, Engine, Fuel, Type, Condition, Doors FROM dbo.CarsApp";
                var queryString2 = "SELECT Invoice, Date, Brand, Model, Price, Park, Hp, Color, Year, Km, Engine, Fuel, Type, Condition, Doors FROM dbo.CarsApp";
                var sqlDataAdapter = new SqlDataAdapter(queryString, connection);
                var sqlDataAdapter2 = new SqlDataAdapter(queryString2, connection);

                DataSet cars = new DataSet();
                DataSet cars2 = new DataSet();
                sqlDataAdapter.Fill(cars, "CarsApp");
                sqlDataAdapter2.Fill(cars2, "CarsApp");

                carsDataGridView.DataSource = cars.Tables["CarsApp"];
                reportsDataGridView.DataSource = cars2.Tables["CarsApp"];
            }
        }
        private void Form1_Load(Object sender, EventArgs e)
        {
            SetupLayout();            

            SetupTabControl();
            SetupDataGridViewCars();
            SetupDataGridViewReports();

            LoadData();
        }
        private void SetupLayout()
        {
            this.Size = new Size(1425, 750);
        }


        private void SetupTabControl() 
        {
            TabControl tb = new TabControl();
            tb.BackColor = Color.White;
            tb.ForeColor = Color.Black;
            tb.Font = new Font("Corbel", 10);
            tb.Width = 1425;
            tb.Height = 700;
            Controls.Add(tb);

            TabPageCars = ControlsHelper.GenerateTabPage("Cars", tb);
            TabPageConfigurator = ControlsHelper.GenerateTabPage("Configurator", tb);
            TabPageFinancial = ControlsHelper.GenerateTabPage("Financial", tb);
            TabPageAdmin = ControlsHelper.GenerateTabPage("Admin", tb);
            TabPageReports = ControlsHelper.GenerateTabPage("Reports", tb);

            TabPageCars.Controls.Add(carsDataGridView);
            TabPageReports.Controls.Add(reportsDataGridView);
            
            ButtonIncoming = ControlsHelper.GenerateButtonX(new Point(100, 550), "Incoming Report", 150, 30);
            ButtonOutgoing = ControlsHelper.GenerateButtonX(new Point(300, 550), "Outgoing Report", 150, 30);

            addCarForm.InitAddCarForm(TabPageAdmin, LoadData);
        }       
       

        private void carsDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void SetupDataGridViewCars()
        {
            carsDataGridView.ColumnCount = 1;

            carsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            carsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            carsDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            carsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(carsDataGridView.Font, FontStyle.Bold);
            
            carsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(carsDataGridView_RowPostPaint);

            carsDataGridView.Name = "carsDataGridView";
            carsDataGridView.Location = new Point(8, 8);
            carsDataGridView.Size = new Size(1425, 700);
            carsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            carsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            carsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            carsDataGridView.GridColor = Color.Black;
            carsDataGridView.RowHeadersVisible = false;

            carsDataGridView.Columns[0].Name = "Index";
            //carsDataGridView.Columns[1].Name = "Model";
            //carsDataGridView.Columns[2].Name = "Price";
            //carsDataGridView.Columns[3].Name = "Park";
            //carsDataGridView.Columns[4].Name = "Hp";
            //carsDataGridView.Columns[5].Name = "Color";
            //carsDataGridView.Columns[6].Name = "Year";
            //carsDataGridView.Columns[7].Name = "Km";
            //carsDataGridView.Columns[8].Name = "Engine";
            //carsDataGridView.Columns[9].Name = "Fuel";
            //carsDataGridView.Columns[10].Name = "Type";
            //carsDataGridView.Columns[11].Name = "Condition";
            //carsDataGridView.Columns[12].Name = "Doors";

            //carsDataGridView.Columns[13].DefaultCellStyle.Font =
                //new Font(carsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            carsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            carsDataGridView.MultiSelect = false;
            carsDataGridView.Dock = DockStyle.Fill;
        }

        private void SetupDataGridViewReports()
        {
            reportsDataGridView.ColumnCount = 1;

            reportsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            reportsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            reportsDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            reportsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(carsDataGridView.Font, FontStyle.Bold);

            reportsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(carsDataGridView_RowPostPaint);

            reportsDataGridView.Name = "reportsDataGridView";
            reportsDataGridView.Location = new Point(8, 8);
            reportsDataGridView.Size = new Size(1425, 700);
            reportsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            reportsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            reportsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            reportsDataGridView.GridColor = Color.Black;
            reportsDataGridView.RowHeadersVisible = false;

            reportsDataGridView.Columns[0].Name = "Index";

            reportsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            reportsDataGridView.MultiSelect = false;
            reportsDataGridView.Dock = DockStyle.Fill;
        }
    }
}
