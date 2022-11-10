using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassMeat : ClassNotify
    {
        // Private Properties
        private int _id;
        private string _typeOfMeat;
        private int _stock;
        private string _strStock;
        private double _price;
        private string _strPrice;
        private DateTime _priceTimeStamp;
        private string _strTimeStamp;

        // Constructor
        public ClassMeat()
        {
            id = 0;
            typeOfMeat = "";
            strStock = "";
            strPrice = "";
            priceTimeStamp = DateTime.Now;
            strTimeStamp = "";
        }

        // Overloaded Constructor til at lave en kopi
        public ClassMeat(ClassMeat inMeat)
        {
            id = inMeat.id;
            typeOfMeat = inMeat.typeOfMeat;
            strStock = inMeat.strStock;
            strPrice = inMeat.strPrice;
            stock = inMeat.stock;
            price = inMeat.price;
            priceTimeStamp = inMeat.priceTimeStamp;
        }

        // Bruges til at holde hvornår kødet blev opdateret
        public string strTimeStamp
        {
            get { return _strTimeStamp; }
            set
            {
                if (_strTimeStamp != value)
                {
                    _strTimeStamp = value;
                }
                Notify("strTimeStamp");
            }
        }

        // Bruges til at holde hvornår prisen blev opdateret
        public DateTime priceTimeStamp
        {
            get { return _priceTimeStamp; }
            set
            {
                if (_priceTimeStamp != value)
                {
                    _priceTimeStamp = value;
                    strTimeStamp = value.ToString("g");
                }
                Notify("priceTimeStamp");
            }
        }

        // Bruges til at holde prisen
        public double price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                }
                Notify("price");
            }
        }

        // Bruges til at holde prisen i string format
        public string strPrice
        {
            get { return _strPrice; }
            set
            {
                if (_strPrice != value)
                {
                    if (value == "")
                    {
                        _strPrice = value;
                        price = 0;
                    }
                    else if (double.TryParse(value, out double x))
                    {
                        if (x >= 0)
                        {
                            _strPrice = value;
                            price = x;
                        }
                    }
                }
                Notify("strPrice");
            }
        }

        // Bruges til at holde hvor meget kød der er tilbage
        public int stock
        {
            get { return _stock; }
            set
            {
                if (_stock != value)
                {
                    _stock = value;
                }
                Notify("stock");
            }
        }

        // Bruges til at holde kødet i string format
        public string strStock
        {
            get { return _strStock; }
            set
            {
                if (_strStock != value)
                {
                    if (value == "")
                    {
                        _strStock = value;
                        stock = 0;
                    }
                    if (int.TryParse(value, out int x))
                    {
                        if (x >= 0)
                        {
                            _strStock = value;
                            stock = x;
                        }
                    }
                }
                Notify("strStock");
            }
        }

        // Bruges til at holde hvilken type kød der er
        public string typeOfMeat
        {
            get { return _typeOfMeat; }
            set
            {
                if (_typeOfMeat != value)
                {
                    _typeOfMeat = value;
                }
                Notify("typeOfMeat");
            }
        }

        // Bruges til at holde kødets id
        public int id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                }
                Notify("id");
            }
        }
    }
}