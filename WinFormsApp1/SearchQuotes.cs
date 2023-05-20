using DeskQuote;
using System;
using System.Collections;
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
    public partial class SearchQuotes : Form
    {
        List<string> list = new List<string>();
        public SearchQuotes()
        {
            InitializeComponent();
            CreateSearchList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            string output = "";
            foreach (string dis in list)
            {
                if (dis.Contains(userInput))
                {
                    output += dis + Environment.NewLine;
                }

            }
            Output.Text = output;
        }
        private void CreateSearchList()
        {
            MainUser mainUser = new MainUser();
            list = mainUser.GetQuotes();
            
        }

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            Visible = false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
