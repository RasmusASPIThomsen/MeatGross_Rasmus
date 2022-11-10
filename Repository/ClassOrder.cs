
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassOrder : ClassNotify
    {
        // Public Properties
        private ClassMeat _orderMeat;
        private ClassCustomer _orderCustomer;
        private int _orderWeight;
        private double _orderPriceDKK;
        private double _orderPriceValuta;
        private string _weight;
        private string _priceDKK;
        private string _priceValuta;

        // Constructor
        public ClassOrder()
        {
            orderMeat = new ClassMeat();
            orderCustomer = new ClassCustomer();
            orderWeight = 0;
            orderPriceDKK = 0D;
            orderPriceValuta = 0D;
            weight = "";
            priceDKK = "0.00";
            priceValuta = "0.00";
        }

        //Public Properties

        // Bruges til at holde hvor meget ordneren vejer og bliver brugt på brugegrænsefladen
        public string weight
        {
            get { return _weight; }
            set
            {
                if (_weight != value)
                {
                    if (value == "")
                    {
                        orderWeight = 0;
                        _weight = value;
                    }
                    else if (int.TryParse(value, out int x))
                    {
                        // A: Make sure the amount doesn't exceed the stock available
                        if (x > orderMeat.stock)
                        {
                            // A: If it does, set the amount equal to the stock
                            orderWeight = orderMeat.stock;
                            _weight = orderMeat.stock.ToString();
                        }
                        else if (x >= 0)
                        {
                            orderWeight = x;
                            _weight = value;
                        }
                    }
                }
                Notify("weight");
            }
        }

        // Bruges til at holde hvor meget ordren koster i egen valuta og bliver brugt på bruger grænsefladen
        public string priceValuta
        {
            get { return _priceValuta; }
            set
            {
                if (_priceValuta != value)
                {
                    _priceValuta = value;
                }
                Notify("priceValuta");
            }
        }

        // Bruges til at vise hvor meget ordren koster i DKK og bliver brugt på brugergrænsefladen
        public string priceDKK
        {
            get { return _priceDKK; }
            set
            {
                if (_priceDKK != value)
                {
                    _priceDKK = value;
                }
                Notify("priceDKK");
            }
        }

        // Bruges til at holde hvor meget ordren koster i kundens egen valuta og bliver brugt i databasen
        public double orderPriceValuta
        {
            get { return _orderPriceValuta; }
            set
            {
                if (_orderPriceValuta != value)
                {
                    _orderPriceValuta = value;
                }
                Notify("orderPriceValuta");
            }
        }

        // Bruges til at holde hvor meget ordren koster i DKK og bliver brugt i databasen
        public double orderPriceDKK
        {
            get { return _orderPriceDKK; }
            set
            {
                if (_orderPriceDKK != value)
                {
                    _orderPriceDKK = value;
                }
                Notify("orderPriceDKK");
            }
        }

        // Holder hvor meget ordren vejer og bliver brugt i databasen
        public int orderWeight
        {
            get { return _orderWeight; }
            set
            {
                if (_orderWeight != value)
                {
                    _orderWeight = value;
                    CalculateAllPrices();
                }
                Notify("orderWeight");
            }
        }

        // Holder hvilken bruger der har lavet ordren og deres information
        public ClassCustomer orderCustomer
        {
            get { return _orderCustomer; }
            set
            {
                if (_orderCustomer != value)
                {
                    _orderCustomer = value;
                    weight = "";
                }
                Notify("orderCustomer");
            }
        }

        // Holder hvilken kød der er blevet købt og dens information
        public ClassMeat orderMeat
        {
            get { return _orderMeat; }
            set
            {
                if (_orderMeat != value)
                {
                    _orderMeat = value;
                    weight = "";
                }
                Notify("orderMeat");
            }
        }

        /// <summary>
        /// Bruges til at udregne priserne
        /// </summary>
        public void CalculateAllPrices()
        {
            orderPriceDKK = orderWeight * orderMeat.price;
            orderPriceValuta = orderPriceDKK / orderCustomer.country.valutaRate;

            priceDKK = orderPriceDKK.ToString("#0.00");
            priceValuta = orderPriceValuta.ToString("#0.00");
        }

    }
}