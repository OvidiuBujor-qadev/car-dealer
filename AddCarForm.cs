using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AddCarForm
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
        private TextBox InvoiceBox;
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
        private Label LabelInvoice;
        private Label LabelAddCars;
        private Label LabelReports;
        private Button ButtonAddCar;
        private Action LoadData;

        public void InitAddCarForm(TabPage addCarFormTab, Action loadData)
        {
            LoadData = loadData;

            InitLabels();
            InitTextBoxes();
            ButtonAddCar = ControlsHelper.GenerateButtonX(new Point(1110, 350), "Add Car", 70, 30);
            ButtonAddCar.Click += button1_Click;

            appErorProvider = new ErrorProvider();

            addCarFormTab.Controls.Add(BrandBox);
            addCarFormTab.Controls.Add(ModelBox);
            addCarFormTab.Controls.Add(PriceBox);
            addCarFormTab.Controls.Add(ParkBox);
            addCarFormTab.Controls.Add(HpBox);
            addCarFormTab.Controls.Add(ColorBox);
            addCarFormTab.Controls.Add(YearBox);
            addCarFormTab.Controls.Add(KmBox);
            addCarFormTab.Controls.Add(EngineBox);
            addCarFormTab.Controls.Add(FuelBox);
            addCarFormTab.Controls.Add(TypeBox);
            addCarFormTab.Controls.Add(ConditionBox);
            addCarFormTab.Controls.Add(DoorsBox);
            addCarFormTab.Controls.Add(InvoiceBox);

            addCarFormTab.Controls.Add(LabelBrand);
            addCarFormTab.Controls.Add(LabelModel);
            addCarFormTab.Controls.Add(LabelPrice);
            addCarFormTab.Controls.Add(LabelPark);
            addCarFormTab.Controls.Add(LabelHp);
            addCarFormTab.Controls.Add(LabelColor);
            addCarFormTab.Controls.Add(LabelYear);
            addCarFormTab.Controls.Add(LabelKm);
            addCarFormTab.Controls.Add(LabelEngine);
            addCarFormTab.Controls.Add(LabelFuel);
            addCarFormTab.Controls.Add(LabelType);
            addCarFormTab.Controls.Add(LabelCondition);
            addCarFormTab.Controls.Add(LabelDoors);
            addCarFormTab.Controls.Add(LabelInvoice);
            addCarFormTab.Controls.Add(LabelAddCars);
            addCarFormTab.Controls.Add(LabelReports);

            addCarFormTab.Controls.Add(ButtonAddCar);
        }

        private void InitTextBoxes()
        {
            BrandBox = ControlsHelper.GenerateTexBox(new Point(100, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
            ModelBox = ControlsHelper.GenerateTexBox(new Point(300, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
            PriceBox = ControlsHelper.GenerateTexBox(new Point(500, 100), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating), false);
            ParkBox = ControlsHelper.GenerateTexBox(new Point(700, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
            HpBox = ControlsHelper.GenerateTexBox(new Point(900, 100), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating), false);
            ColorBox = ControlsHelper.GenerateTexBox(new Point(1100, 100), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
            YearBox = ControlsHelper.GenerateTexBox(new Point(100, 200), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating), false);
            KmBox = ControlsHelper.GenerateTexBox(new Point(300, 200), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating), false);
            EngineBox = ControlsHelper.GenerateTexBox(new Point(500, 200), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating), false);
            FuelBox = ControlsHelper.GenerateTexBox(new Point(700, 200), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
            TypeBox = ControlsHelper.GenerateTexBox(new Point(900, 200), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
            ConditionBox = ControlsHelper.GenerateTexBox(new Point(1100, 200), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
            DoorsBox = ControlsHelper.GenerateTexBox(new Point(100, 300), new TextBoxEventsParameters(TextBoxOnlyNumbers_TextChanged, TextBoxRequired_Validating), false);
            InvoiceBox = ControlsHelper.GenerateTexBox(new Point(300, 300), new TextBoxEventsParameters(null, TextBoxRequired_Validating), false);
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
            LabelInvoice = ControlsHelper.GenerateLabelX(new Point(225, 305), "Invoice");
            LabelAddCars = ControlsHelper.GenerateLabelX(new Point(625, 35), "Add Cars");
            LabelReports = ControlsHelper.GenerateLabelX(new Point(625, 455), "Reports");
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

        private bool SendingStopped(Car car) 
        {
            if (string.IsNullOrEmpty(car.Brand)) 
            {
                MessageBox.Show("Brand is required");
                return false;
            }
            if (string.IsNullOrEmpty(car.Model))
            {
                MessageBox.Show("Model is required");
                return false;
            }
            if (string.IsNullOrEmpty(car.Park))
            {
                MessageBox.Show("Park is required");
                return false;
            }
            if (string.IsNullOrEmpty(car.Color))
            {
                MessageBox.Show("Color is required");
                return false;
            }
            if (string.IsNullOrEmpty(car.Fuel))
            {
                MessageBox.Show("Fuel is required");
                return false;
            }
            if (string.IsNullOrEmpty(car.Type))
            {
                MessageBox.Show("Type is required");
                return false;
            }
            if (string.IsNullOrEmpty(car.Condition))
            {
                MessageBox.Show("Condition is required");
                return false;
            }
            if (string.IsNullOrEmpty(car.Invoice))
            {
                MessageBox.Show("Invoice is required");
                return false;
            }
            return true;
        }

        private void ParsingValidation() 
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var price = 0;
            var hp = 0;
            var year = 0;
            var km = 0;
            var engine = 0;
            var doors = 0;

            ParsingValidation();

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
                Invoice = InvoiceBox.Text,
            };

            var validCar = SendingStopped(newCar);
            if (!validCar) 
            {
                return;
            }

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
            InvoiceBox.Clear();

            InsertCar(newCar);
            LoadData();
        }

        private void InsertCar(Car car)
        {
            DateTime localDate = DateTime.Now.ToUniversalTime();

            string insertCar = "INSERT INTO dbo.CarsApp " +
                "VALUES(@Invoice, @Date, @Brand, @Model, @Price, @Park, @Hp, @Color, @Year, @Km, @Engine, @Fuel, @Type, @Condition, @Doors)";

            using (var connection = new SqlConnection(
                   "Server=AVG-188;" +
                   "Database=Cars; Integrated Security=True;" +
                   "TrustServerCertificate=False;Connection Timeout=30;"
                   ))
            using (SqlCommand cmd = new SqlCommand(insertCar, connection))
            {
                cmd.Parameters.Add("@Brand", SqlDbType.VarChar, 50).Value = car.Brand;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = localDate;
                cmd.Parameters.Add("@Model", SqlDbType.VarChar, 50).Value = car.Model;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = car.Price;
                cmd.Parameters.Add("@Park", SqlDbType.VarChar, 50).Value = car.Park;
                cmd.Parameters.Add("@Hp", SqlDbType.Int).Value = car.Hp;
                cmd.Parameters.Add("@Color", SqlDbType.VarChar, 50).Value = car.Color;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = car.Year;
                cmd.Parameters.Add("@Km", SqlDbType.Int).Value = car.Km;
                cmd.Parameters.Add("@Engine", SqlDbType.Int).Value = car.Engine;
                cmd.Parameters.Add("@Fuel", SqlDbType.VarChar, 50).Value = car.Fuel;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = car.Type;
                cmd.Parameters.Add("@Condition", SqlDbType.VarChar, 50).Value = car.Condition;
                cmd.Parameters.Add("@Doors", SqlDbType.Int).Value = car.Doors;
                cmd.Parameters.Add("@Invoice", SqlDbType.VarChar).Value = car.Invoice;
                

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
