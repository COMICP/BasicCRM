using DeskQuote;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();

        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Visible = true;
            Visible = false;
        }

        private void QuitProgram_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuotesForm viewQuotesForm = new ViewQuotesForm();
            viewQuotesForm.Visible = true;
            Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Visible = true;
            Visible = false;
        }
    }
}