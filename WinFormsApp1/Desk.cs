using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace DeskQuote
{
    [DataContract]
    public class Desk
    {
        private static string readFile = "C:\\Users\\theha\\Source\\Repos\\COMICP\\BasicCRM\\WinFormsApp1\\Stuff\\rushOrderPrices.txt";
        [DataMember]
        private static string _fullName { get; set; }
        [DataMember]
        private static DateTime _date {get; set;}
        [DataMember]
        private static double _sqin { get; set; }
        [DataMember]
        private static double _width { get; set; }
        [DataMember]
        private static double _depth { get; set; }
        [DataMember]
        private static int _drawrs { get; set; }
        [DataMember]
        private static Surface _surface { get; set; }
        private static double _basePrice = 200;
        private static double _ppd = 50;
        [DataMember]
        private static double _rushTime { get; set; }
        [DataMember]
        private static double _price { get; set; }

        public Desk(string name, double width, double depth, int drawrs, Surface surface, int shipping = 0)
        {
            _date = DateTime.Now;
            _fullName = name;
            _width = width;
            _depth = depth;
            _drawrs = drawrs;
            _surface = surface;
            _rushTime = shipping;
            _sqin = width * depth;

            _price = CalcPrice();

            
        }
        public string GetName()
        {
            return _fullName;
        }
        protected static double GetShippingPrice()
        {
            int[,] pricelist = GetPrices();
            double rushPrice = 0;
            int time = 0;
            int size = 0;
            if (_rushTime == 0)
            {
                return rushPrice;
            }

            if (_rushTime ==7)
            {
                time = 2;
            }
            if (_rushTime == 5)
            {
                time = 1;
            }
            if (_rushTime == 3)
            {
                time = 0;
            }

            if (_sqin < 1000)
            {
                size = 0;
            }
            if (_sqin <= 2000)
            {
                size = 1;
            }
            if (_sqin > 2000)
            {
                size = 2;
            }
            
            rushPrice = pricelist[time, size];

            return rushPrice;
        }//ugly code to get rush order
        public double CalcPrice()
        {
            double finalPrice = 0;
            finalPrice += _basePrice;

            if (_sqin > 1000)
            {
                finalPrice += _sqin;
            }

            finalPrice += (int)_surface;
            finalPrice += _drawrs * _ppd;
            finalPrice += GetShippingPrice();

            return finalPrice;
        }
        public double GetPrice()
        {
            return _price;
        }
        public string GetDate()
        {
            return "Date: " + _date.ToString("dd MMMM yyyy");
        }


        public static int[,] GetPrices()
        {
            int[,] price = { { 0, 0, 0 },{ 0, 0, 0 }, { 0, 0, 0 } };
            int count = 0;
            int count2 = 0;
            
            try
            {
                StreamReader SR = new StreamReader(readFile);
                string line;

                while ((line = SR.ReadLine()) != null)
                {


                    price[count2,count] = int.Parse(line);

                    count += 1;
                    if (count == 3)
                    {
                        count = 0;
                        count2 += 1;
                    }
                    Console.WriteLine(price);
                }
                SR.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message + "File read error at price get");
                throw new Exception();
                
            }

            return price;
        }
    }
    public enum Surface
    {
        None = 0, Pine = 50, Laminate = 100, Veneer = 125, Oak = 200, RoseWood = 300
    }
}

