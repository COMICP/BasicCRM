using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using static System.Windows.Forms.AxHost;

namespace DeskQuote
{
    public class MainUser
    {
        private static List<string> _deskQuotes = new List<string>();
        private static string readFile = "C:\\Users\\theha\\Source\\Repos\\COMICP\\BasicCRM\\WinFormsApp1\\Stuff\\Quotes.json";

        public static void LoadList()
        {
            
        }
        public List<string> GetQuotes()
        {
            List<string> tempList = new List<string>();
            try
            {
                StreamReader SR = new StreamReader(readFile);
                string line;

                while ((line = SR.ReadLine()) != null)
                {
                    

                    dynamic jsonObj = JsonConvert.DeserializeObject(line);
                    string name = jsonObj["_fullName"];
                    
                    string price = (jsonObj["_price"]);
                    string date = jsonObj["_date"];
                    tempList.Add($"{date}, Price: ${price}, Name: {name}");
                    
                }
                SR.Close();
            }
            catch (Exception ex) { }

            _deskQuotes = tempList; 
            return tempList;
        }
        
    }
}
