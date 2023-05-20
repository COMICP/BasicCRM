using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DeskQuote
{

    [DataContract]
    public class Quote
    {   private string saveFile = "C:\\Users\\theha\\Source\\Repos\\COMICP\\BasicCRM\\WinFormsApp1\\Stuff\\Quotes.json";
        [DataMember]
        private static double _price { get; set; }
        [DataMember]
        private static string _date { get; set; }
        [DataMember]
        private static string _name  { get; set; }
        [DataMember]
        private static Desk _desk { get; set; }

        public Quote(Desk desk , double price = 0, string name = "null", string date = "null")
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
                StreamReader SR = new StreamReader(saveFile);
                string line;

                while ((line = SR.ReadLine()) != null)
                {
                    tempList.Add(line);
                }
                SR.Close();
            }
            catch (Exception ex) { }
            Quote tempQuote = new Quote(_desk);

            tempList.Add(JsonConvert.SerializeObject(_desk));
            try
            {
                StreamWriter sw = new StreamWriter(saveFile);
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
