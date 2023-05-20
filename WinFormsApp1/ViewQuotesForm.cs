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
    public partial class ViewQuotesForm : Form
    {
        public ViewQuotesForm()
        {
            InitializeComponent();


        }

        private void ListOutput_Click(object sender, EventArgs e)
        {

        }
        private static void DisplayQuotes()
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            MainUser mainUser = new MainUser();
            string output = "";

            List<string> disList = mainUser.GetQuotes();




            foreach (string dis in disList)
            {
                output += dis + Environment.NewLine;
            }
            ListOutput.Text = output;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            Visible = false;
        }
    }
}
