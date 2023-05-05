using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DeskQuote
{
    public class Quote
    {
        private static double _price = 0;
        private static string _date = "";
        private static string _name = "name";
        private static Desk _desk;

        public Quote(Desk desk)
        {
            _price = desk.GetPrice();
            _date = desk.GetDate();
            _name = desk.GetName();
            _desk = desk;
        }

        public string GetEstimate()
        {
            return $"{_date}, Price: ${_price}, Name: {_name}";
        }
        public Desk GetDesk() {
            return _desk;
        }
        public void SaveQuote()
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

            tempList.Add(GetEstimate());
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\theha\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Stuff\\Quotes.txt");
                foreach (string quo in tempList)
                {
                    sw.WriteLine(quo);
                }
                sw.Close();
            }
            catch { }

        }
        
    }
}
