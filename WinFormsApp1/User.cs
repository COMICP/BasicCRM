using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskQuote
{
    public class MainUser
    {
        private static List<string> _deskQuotes = new List<string>();

        public static void SaveList()
        {

        }
        public List<string> GetQuotes()
        {
            List<string> tempList = new List<string>();
            try
            {
                StreamReader SR = new StreamReader("C:\\Users\\theha\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Stuff\\Quotes.txt");
                string line;

                while ((line = SR.ReadLine()) != null)
                {
                    tempList.Add(line);
                }
                SR.Close();
            }
            catch (Exception ex) { }

            _deskQuotes = tempList; 
            return tempList;
        }
        
    }
}
