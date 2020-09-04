using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox BrandBox;
        private TextBox ModelBox;
        private TextBox PriceBox;
        private TextBox ParkBox;
        private TextBox HpBox;
        private TextBox ColorBox;
        private TextBox YearBox;
        private TextBox KmBox;
        private TextBox EngineBox; 
        private TextBox FuelBox;
        private TextBox TypeBox;
        private TextBox ConditionBox;
        private TextBox DoorsBox;
        private ErrorProvider appErorProvider;
        private Label LabelBrand;
        private Label LabelModel;
        private Label LabelPrice;
        private Label LabelPark;
        private Label LabelHp;
        private Label LabelColor;
        private Label LabelYear;
        private Label LabelKm;
        private Label LabelEngine;
        private Label LabelFuel;
        private Label LabelType;
        private Label LabelCondition;
        private Label LabelDoors;
        private TabPage TabPageCars;
        private TabPage TabPageConfigurator;
        private TabPage TabPageFinancial;
        private TabPage TabPageAdmin;
        private Button Button0;

        private DataGridView carsDataGridView = new DataGridView();
        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(Object sender, EventArgs e)
        {
            SetupLayout();
            InitTextBoxes();
            InitLabels();
            SetupTabControl();
            SetupDataGridView();

            appErorProvider = new ErrorProvider();
        }
        private void SetupLayout()
        {
            this.Size = new Size(1325, 500);
        }

        private void InitTextBoxes()
        {
            BrandBox = ControlsHelper.GenerateTexBox(new Point(100, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating));
            ModelBox = ControlsHelper.GenerateTexBox(new Point(300, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating));
            PriceBox = ControlsHelper.GenerateTexBox(new Point(500, 100), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating));
            ParkBox = ControlsHelper.GenerateTexBox(new Point(700, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating));
            HpBox = ControlsHelper.GenerateTexBox(new Point(900, 100), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating));
            ColorBox = ControlsHelper.GenerateTexBox(new Point(1100, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating));
            YearBox = ControlsHelper.GenerateTexBox(new Point(100, 200), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating));
            KmBox = ControlsHelper.GenerateTexBox(new Point(300, 200), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating));
            EngineBox = ControlsHelper.GenerateTexBox(new Point(500, 200), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating));
            FuelBox = ControlsHelper.GenerateTexBox(new Point(700, 200), new TextBoxEventsParameters(null, TextBoxRequired_Validating));
            TypeBox = ControlsHelper.GenerateTexBox(new Point(900, 200), new TextBoxEventsParameters(null, TextBoxRequired_Validating));
            ConditionBox = ControlsHelper.GenerateTexBox(new Point(1100, 200), new TextBoxEventsParameters(null, TextBoxRequired_Validating));
            DoorsBox = ControlsHelper.GenerateTexBox(new Point(100, 300), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating));
        }

        private void InitLabels()
        {
            LabelBrand = ControlsHelper.GenerateLabelX(new Point(25, 105), "Brand");
            LabelModel = ControlsHelper.GenerateLabelX(new Point(225, 105), "Model");
            LabelPrice = ControlsHelper.GenerateLabelX(new Point(425, 105), "Price");
            LabelPark = ControlsHelper.GenerateLabelX(new Point(625, 105), "Park");
            LabelHp = ControlsHelper.GenerateLabelX(new Point(825, 105), "HP");
            LabelColor = ControlsHelper.GenerateLabelX(new Point(1025, 105), "Color");
            LabelYear = ControlsHelper.GenerateLabelX(new Point(25, 205), "Year");
            LabelKm = ControlsHelper.GenerateLabelX(new Point(225, 205), "Km");
            LabelEngine = ControlsHelper.GenerateLabelX(new Point(425, 205), "Engine");
            LabelFuel = ControlsHelper.GenerateLabelX(new Point(625, 205), "Fuel");
            LabelType = ControlsHelper.GenerateLabelX(new Point(825, 205), "Type");
            LabelCondition = ControlsHelper.GenerateLabelX(new Point(1025, 205), "Condition");
            LabelDoors = ControlsHelper.GenerateLabelX(new Point(25, 305), "Doors");
        }

        private void InitTabPage4()
        {
            TabPageAdmin.Controls.Add(BrandBox);
            TabPageAdmin.Controls.Add(ModelBox);
            TabPageAdmin.Controls.Add(PriceBox);
            TabPageAdmin.Controls.Add(ParkBox);
            TabPageAdmin.Controls.Add(HpBox);
            TabPageAdmin.Controls.Add(ColorBox);
            TabPageAdmin.Controls.Add(YearBox);
            TabPageAdmin.Controls.Add(KmBox);
            TabPageAdmin.Controls.Add(EngineBox);
            TabPageAdmin.Controls.Add(FuelBox);
            TabPageAdmin.Controls.Add(TypeBox);
            TabPageAdmin.Controls.Add(ConditionBox);
            TabPageAdmin.Controls.Add(DoorsBox);

            TabPageAdmin.Controls.Add(LabelBrand);
            TabPageAdmin.Controls.Add(LabelModel);
            TabPageAdmin.Controls.Add(LabelPrice);
            TabPageAdmin.Controls.Add(LabelPark);
            TabPageAdmin.Controls.Add(LabelHp);
            TabPageAdmin.Controls.Add(LabelColor);
            TabPageAdmin.Controls.Add(LabelYear);
            TabPageAdmin.Controls.Add(LabelKm);
            TabPageAdmin.Controls.Add(LabelEngine);
            TabPageAdmin.Controls.Add(LabelFuel);
            TabPageAdmin.Controls.Add(LabelType);
            TabPageAdmin.Controls.Add(LabelCondition);
            TabPageAdmin.Controls.Add(LabelDoors);

            TabPageAdmin.Controls.Add(Button0);
        }

        private void SetupTabControl() 
        {
            TabControl tb = new TabControl();
            tb.BackColor = Color.White;
            tb.ForeColor = Color.Black;
            tb.Font = new Font("Corbel", 10);
            tb.Width = 1325;
            tb.Height = 455;
            Controls.Add(tb);

            TabPageCars = ControlsHelper.GenerateTabPage("Cars", tb);
            TabPageConfigurator = ControlsHelper.GenerateTabPage("Configurator", tb);
            TabPageFinancial = ControlsHelper.GenerateTabPage("Financial", tb);
            TabPageAdmin = ControlsHelper.GenerateTabPage("Admin", tb);

            InitTabPage4();

            TabPageCars.Controls.Add(carsDataGridView);                    

            Button0 = ControlsHelper.GenerateButtonX(new Point(1125, 350), "Add Car");

            Button0.Click += button1_Click;
        }       

        private void TextBoxRequired_Validating(object sender, CancelEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null)
                return;

            if (string.IsNullOrEmpty(txtBox.Text))
            {
                appErorProvider.SetError(txtBox, "This field is required");
            }
        }


        private void TextBoxOnlyNumbers_TextChanged(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null)
                return;

            if (Regex.IsMatch(txtBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBox.Text = Regex.Replace(txtBox.Text, "[^0-9]", "");
            }
        }

        private void SetupDataGridView()
        {
            carsDataGridView.ColumnCount = 13;

            carsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            carsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            carsDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            carsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(carsDataGridView.Font, FontStyle.Bold);

            carsDataGridView.Name = "carsDataGridView";
            carsDataGridView.Location = new Point(8, 8);
            carsDataGridView.Size = new Size(1200, 455);
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

       

        private void button1_Click(object sender, EventArgs e)
        {
            var price = 0;
            var hp = 0;
            var year = 0;
            var km = 0;
            var engine = 0;
            var doors = 0;


            var priceParsed = int.TryParse(PriceBox.Text, out price);
            var hpParsed = int.TryParse(HpBox.Text, out hp);
            var yearParsed = int.TryParse(YearBox.Text, out year);
            var kmParsed = int.TryParse(KmBox.Text, out km);
            var engineParsed = int.TryParse(EngineBox.Text, out engine);
            var doorsParsed = int.TryParse(DoorsBox.Text, out doors);
            if (!priceParsed)
            {
                MessageBox.Show("Parsing of price failed");
            }
            if (!hpParsed) 
            {
                MessageBox.Show("Parsing of Hp failed");
            }
            if (!yearParsed)
            {
                MessageBox.Show("Parsing of year failed");
            }
            if (!kmParsed)
            {
                MessageBox.Show("Parsing of Km failed");
            }
            if (!engineParsed)
            {
                MessageBox.Show("Parsing of engine failed");
            }
            if (!doorsParsed)
            {
                MessageBox.Show("Parsing of doors failed");
            }

            //Create new Car Object from form
            var newCar = new Car
            {
                Brand = BrandBox.Text,
                Model = ModelBox.Text,
                Price = price,
                Park = ParkBox.Text,
                Hp = hp,
                Color = ColorBox.Text,
                Year = year,
                Km = km,
                Engine = engine,
                Fuel = FuelBox.Text,
                Type = TypeBox.Text,
                Condition = ConditionBox.Text,
                Doors = doors,
            };

            //Clear inputs
            BrandBox.Clear();
            ModelBox.Clear();
            PriceBox.Clear();
            ParkBox.Clear();
            HpBox.Clear();
            ColorBox.Clear();
            YearBox.Clear();
            KmBox.Clear();
            EngineBox.Clear();
            FuelBox.Clear();
            TypeBox.Clear();
            ConditionBox.Clear();
            DoorsBox.Clear();

            //Add new car to listView
            var DataGridViewItem = new string[]
            { newCar.Brand,
                newCar.Model,
                newCar.Price.ToString(),
                newCar.Park,
                newCar.Hp.ToString(),
                newCar.Color,
                newCar.Year.ToString(),
                newCar.Km.ToString(),
                newCar.Engine.ToString(),
                newCar.Fuel,
                newCar.Type,
                newCar.Condition,
                newCar.Doors.ToString()
            };

            carsDataGridView.Rows.Add(DataGridViewItem);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
