using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class ControlsHelper
    {
        public static TextBox GenerateTexBox(Point position, TextBoxEventsParameters eventParams)
        {
            TextBox txtBox = new TextBox();
            txtBox.Size = new Size(100, 25);
            txtBox.Location = position;
            txtBox.BorderStyle = BorderStyle.Fixed3D;
            txtBox.Validating += eventParams.Validating;
            txtBox.TextChanged += eventParams.TextChanged;
            return txtBox;
        }

        public static Label GenerateLabelX(Point position, string Text)
        {
            Label LabelX = new Label();
            LabelX.Font = new Font("Microsoft Sans Serif", 11);
            LabelX.Text = Text;
            LabelX.Location = position;
            LabelX.ForeColor = Color.Black;

            return LabelX;
        }

        public static Button GenerateButtonX(Point position, string Text)
        {
            Button ButtonX = new Button();
            ButtonX.Font = new Font("Microsoft Sans Serif", 11);
            ButtonX.Text = Text;
            ButtonX.Location = position;
            ButtonX.ForeColor = Color.Black;

            return ButtonX;
        }

        public static TabPage GenerateTabPage(string pageName, TabControl tabControl)
        {
            TabPage tg = new TabPage();
            tg.Text = pageName;
            tg.BackColor = Color.LightGray;
            tg.ForeColor = Color.White;
            tg.Font = new Font("Corbel", 10);
            tg.Width = 1325;
            tg.Height = 455;

            tabControl.TabPages.Add(tg);

            return tg;
        }
    }
}
