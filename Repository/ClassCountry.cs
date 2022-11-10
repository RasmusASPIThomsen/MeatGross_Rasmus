using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassCountry : ClassNotify
    {
        // Private Properties
        private int _Id;
        private string _countryName;
        private string _countryCode;
        private string _valutaName;
        private double _valutaRate;
        private DateTime _updateTime;

        // Constructor
        public ClassCountry()
        {
            Id = 0;
            countryName = "";
            countryCode = "DKK";
            valutaName = "";
            valutaRate = 1D;
            updateTime = DateTime.Now;
        }

        // Overloaded Constructor for at lave en kopi
        public ClassCountry(ClassCountry inCountry)
        {
            Id = inCountry.Id;
            countryName = inCountry.countryName;
            countryCode = inCountry.countryCode;
            valutaName = inCountry.valutaName;
            valutaRate = inCountry.valutaRate;
            updateTime = inCountry.updateTime;
        }

        // Bliver brugt til at holde den rigtige rate for det valgte land
        public double valutaRate
        {
            get { return _valutaRate; }
            set
            {
                if (_valutaRate != value)
                {
                    _valutaRate = value;
                }
                Notify("valutaRate");
            }
        }

        // Bliver brugt til at holde den rigtige rate for det valgte land
        public string valutaName
        {
            get { return _valutaName; }
            set
            {
                if (_valutaName != value)
                {
                    _valutaName = value;
                }
                Notify("valutaName");
            }
        }

        // Bliver brugt til at holde landets lande kode (for exemple: Dk, S, UK) 
        public string countryCode
        {
            get { return _countryCode; }
            set
            {
                if (_countryCode != value)
                {
                    _countryCode = value;
                }
                Notify("countryCode");
            }
        }

        // Bliver Brugt til at holde landets navn
        public string countryName
        {
            get { return _countryName; }
            set
            {
                if (_countryName != value)
                {
                    _countryName = value;
                }
                Notify("countryName");
            }
        }

        // Bliver brugt til at holde landets id
        public int Id
        {
            get { return _Id; }
            set
            {
                if (_Id != value)
                {
                    _Id = value;
                }
                Notify("Id");
            }
        }

        // Bliver brugt til at holde hvornår informationen bliver opdateret
        public DateTime updateTime
        {
            get { return _updateTime; }
            set
            {
                if (_updateTime != value)
                {
                    _updateTime = value;
                }
                Notify("updateTime");
            }
        }

    }
}