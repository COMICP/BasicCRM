using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DeskQuote
{
    public class Desk
    {
        private static string _fullName = "";
        private static DateTime _date;
        private static double _sqin = 0;
        private static double _width = 0;
        private static double _depth = 0;
        private static int _drawrs = 0;
        private static Surface _surface = Surface.Pine;
        private static double _basePrice = 200;
        private static double _ppd = 50;
        private static double _rushTime = 0;
        private static double _price = 0;

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
            double rushprice = 0;
            if (_rushTime == 0)
            {
                return rushprice;
            }

            else if (_rushTime == 7 && _sqin < 1000)
            {
                rushprice = 30;
            }
            else if (_rushTime == 7 && _sqin <= 2000)
            {
                rushprice = 35;
            }
            else if (_rushTime == 7 && _sqin > 2000)
            {
                rushprice = 40;
            }


            else if (_rushTime == 5)
            {
                rushprice = 40;
            }
            else if (_rushTime == 3)
            {
                rushprice = 60;
            }


            if (_sqin < 1000)
            {
                rushprice += 10;
            }
            else if (_sqin <= 2000)
            {
                rushprice += 20;
            }
            else if (_sqin > 1000)
            {
                rushprice += 30;
            }

            return rushprice;
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



    }
    public enum Surface
    {
        None = 0, Pine = 50, Laminate = 100, Veneer = 125, Oak = 200, RoseWood = 300
    }
}

