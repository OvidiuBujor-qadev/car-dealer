using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Configurator
    {
        private Label BrandLConfigurator;
        private Label ModelLConfigurator;
        private Label PriceLConfigurator;
        private Label ParkLConfigurator;
        private Label HpLConfigurator;
        private Label ColorLConfigurator;
        private Label YearLConfigurator;
        private Label KmLConfigurator;
        private Label EngineLConfigurator;
        private Label FuelLConfigurator;
        private Label TypeLConfigurator;
        private Label ConditionLConfigurator;
        private Label DoorsLConfigurator;
        private Label InvoiceLConfigurator;

        private TextBox BrandConfigurator;
        private TextBox ModelConfigurator;
        private TextBox PriceConfigurator;
        private TextBox ParkConfigurator;
        private TextBox HpConfigurator;
        private TextBox ColorConfigurator;
        private TextBox YearConfigurator;
        private TextBox KmConfigurator;
        private TextBox EngineConfigurator;
        private TextBox FuelConfigurator;
        private TextBox TypeConfigurator;
        private TextBox ConditionConfigurator;
        private TextBox DoorsConfigurator;
        private TextBox InvoiceConfigurator;

        private void InitConfiguratorTextBoxes()
        {
            BrandConfigurator = ControlsHelper.GenerateTexBox(new Point(100, 50), new TextBoxEventsParameters(null, null), true);
            ModelConfigurator = ControlsHelper.GenerateTexBox(new Point(300, 50), new TextBoxEventsParameters(null, null), true);
            PriceConfigurator = ControlsHelper.GenerateTexBox(new Point(100, 150), new TextBoxEventsParameters(null, null), true);
            ParkConfigurator = ControlsHelper.GenerateTexBox(new Point(300, 150), new TextBoxEventsParameters(null, null), true);
            HpConfigurator = ControlsHelper.GenerateTexBox(new Point(100, 250), new TextBoxEventsParameters(null, null), true);
            ColorConfigurator = ControlsHelper.GenerateTexBox(new Point(300, 250), new TextBoxEventsParameters(null, null), true);
            YearConfigurator = ControlsHelper.GenerateTexBox(new Point(100, 350), new TextBoxEventsParameters(null, null), true);
            KmConfigurator = ControlsHelper.GenerateTexBox(new Point(300, 350), new TextBoxEventsParameters(null, null), true);
            EngineConfigurator = ControlsHelper.GenerateTexBox(new Point(100, 450), new TextBoxEventsParameters(null, null), true);
            FuelConfigurator = ControlsHelper.GenerateTexBox(new Point(300, 450), new TextBoxEventsParameters(null, null), true);
            TypeConfigurator = ControlsHelper.GenerateTexBox(new Point(100, 550), new TextBoxEventsParameters(null, null), true);
            ConditionConfigurator = ControlsHelper.GenerateTexBox(new Point(300, 550), new TextBoxEventsParameters(null, null), true);
            DoorsConfigurator = ControlsHelper.GenerateTexBox(new Point(100, 650), new TextBoxEventsParameters(null, null), true);
            InvoiceConfigurator = ControlsHelper.GenerateTexBox(new Point(300, 650), new TextBoxEventsParameters(null, null), true);
        }

        private void InitConfiguratorLabels() 
        {
            BrandLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 55), "Brand");
            ModelLConfigurator = ControlsHelper.GenerateLabelX(new Point(225, 55), "Model");
            PriceLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 155), "Price");
            ParkLConfigurator = ControlsHelper.GenerateLabelX(new Point(225, 155), "Park");
            HpLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 255), "HP");
            ColorLConfigurator = ControlsHelper.GenerateLabelX(new Point(225, 255), "Color");
            YearLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 355), "Year");
            KmLConfigurator = ControlsHelper.GenerateLabelX(new Point(225, 355), "Km");
            EngineLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 455), "Engine");
            FuelLConfigurator = ControlsHelper.GenerateLabelX(new Point(225, 455), "Fuel");
            TypeLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 555), "Type");
            ConditionLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 555), "Condition");
            DoorsLConfigurator = ControlsHelper.GenerateLabelX(new Point(25, 655), "Doors");
            InvoiceLConfigurator = ControlsHelper.GenerateLabelX(new Point(225, 655), "Invoice");
        }

        public void InitAddTextBoxes(TabPage carConfigurator) 
        {
            InitConfiguratorTextBoxes();
            InitConfiguratorLabels();

            carConfigurator.Controls.Add(BrandConfigurator);
            carConfigurator.Controls.Add(ModelConfigurator);
            carConfigurator.Controls.Add(PriceConfigurator);
            carConfigurator.Controls.Add(ParkConfigurator);
            carConfigurator.Controls.Add(HpConfigurator);
            carConfigurator.Controls.Add(ColorConfigurator);
            carConfigurator.Controls.Add(YearConfigurator);
            carConfigurator.Controls.Add(KmConfigurator);
            carConfigurator.Controls.Add(EngineConfigurator);
            carConfigurator.Controls.Add(FuelConfigurator);
            carConfigurator.Controls.Add(TypeConfigurator);
            carConfigurator.Controls.Add(ConditionConfigurator);
            carConfigurator.Controls.Add(DoorsConfigurator);
            carConfigurator.Controls.Add(InvoiceConfigurator);

            carConfigurator.Controls.Add(BrandLConfigurator);
            carConfigurator.Controls.Add(ModelLConfigurator);
            carConfigurator.Controls.Add(PriceLConfigurator);
            carConfigurator.Controls.Add(ParkLConfigurator);
            carConfigurator.Controls.Add(HpLConfigurator);
            carConfigurator.Controls.Add(ColorLConfigurator);
            carConfigurator.Controls.Add(YearLConfigurator);
            carConfigurator.Controls.Add(KmLConfigurator);
            carConfigurator.Controls.Add(EngineLConfigurator);
            carConfigurator.Controls.Add(FuelLConfigurator);
            carConfigurator.Controls.Add(TypeLConfigurator);
            carConfigurator.Controls.Add(ConditionLConfigurator);
            carConfigurator.Controls.Add(DoorsLConfigurator);
            carConfigurator.Controls.Add(InvoiceLConfigurator);
        }

        private void carsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
