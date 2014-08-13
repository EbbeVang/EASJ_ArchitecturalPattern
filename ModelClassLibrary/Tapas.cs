using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary
{
     public class Tapas
    {
        private int tapasNo;

        public int TapasNo
        {
            get { return tapasNo; }
            set { tapasNo = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; } //stykpris for hver tapas
        }

         public override string ToString()
         {
             return string.Format("TapasNo: {0}, Name: {1}, Price: {2}", tapasNo, name, _price);
         }
    }
}
