using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassApiRates : ClassNotify
    {
        // Private properties
        private Dictionary<string, double> _rates;

        // Constructor
        public ClassApiRates()
        {
            rates = new Dictionary<string, double>();
        }

        // Public Properties

        // Property til at finde hvilken rate svarer til hvilken currency
        public Dictionary<string, double> rates
        {
            get { return _rates; }
            set
            {
                if (_rates != value)
                {
                    _rates = value;
                }
                Notify("rates");
            }
        }
    }
}