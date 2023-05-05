using DeskQuote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddQuote : Form
    {
        string fullName = "void";
        double width = -1;
        double depth = -1;
        int drawrs = -1;
        int rushTime = -1;
        Surface surface = Surface.None;


        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fullName != "void" && width != -1 && depth != -1 && drawrs != -1  && rushTime != -1 && surface != Surface.None)
            {
                Desk desk = new Desk(fullName, width, depth, drawrs, surface, rushTime);
                Quote quote = new Quote(desk);


                SavedDisplay.Text = quote.GetEstimate();
                quote.SaveQuote();

            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fullName = textBox1.Text;
        }


        private void MaterialInput_TextChanged(object sender, EventArgs e)
        {
            string inputMaterial = MaterialInput.Text;

            try
            {
                surface = (Surface)Enum.Parse(typeof(Surface), inputMaterial, true);
                MaterialInput.BackColor = Color.White;
            }
            catch {
                MaterialInput.BackColor = Color.Red;
            }

        }

        private void SavedDisplay_Click(object sender, EventArgs e)
        {
            
        }


        private void WidthInput_TextChanged(object sender, EventArgs e)
        {
            string input = WidthInput.Text;
            double doubleInputWidth = ConvertInputDouble(input);

            if (doubleInputWidth < 96 && doubleInputWidth > 24)
            {
                width = doubleInputWidth;
                WidthInput.BackColor = Color.White;

            }
            else WidthInput.BackColor = Color.Red;
        }

        private void DepthInput_TextChanged(object sender, EventArgs e)
        {
            string input = DepthInput.Text;
            double doubleInput = ConvertInputDouble(input);

            if (doubleInput < 48 && doubleInput  > 12)
            {
                depth = doubleInput;
                DepthInput.BackColor = Color.White; 

            }
            else DepthInput.BackColor = Color.Red;
        }

        private void DrawrsInput_TextChanged(object sender, EventArgs e)
        {
            string input = DrawrsInput.Text;
            int doubleInputD = ConvertInputInt(input);
            if (doubleInputD <=7 && doubleInputD >= 0)
            {
                drawrs = doubleInputD;
                DrawrsInput.BackColor = Color.White;
            }
            else DrawrsInput.BackColor = Color.Red;
        }

        private void RushInput_TextChanged(object sender, EventArgs e)
        {
            string input = RushInput.Text;
            int doubleInputR = ConvertInputInt(input);

            if (doubleInputR ==7 || doubleInputR == 5 || doubleInputR == 3 || doubleInputR == 0)
            {
                rushTime = doubleInputR;
                RushInput.BackColor = Color.White;
            }
            else { 
                RushInput.BackColor = Color.Red;
            }
        }
        public static int ConvertInputInt(string input)
        {
            
            try
            {
                int stringToInt = Int32.Parse(input);
                
                return stringToInt;
            }
            catch
            {
                return -1;
            }

            
        }
        public static double ConvertInputDouble(string input)
        {

            try
            {
                double stringToDouble = Double.Parse(input);
                return stringToDouble;
            }
            catch
            {
                return -1;
            }


        }
    }
}
