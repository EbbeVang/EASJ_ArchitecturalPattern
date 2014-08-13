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

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; } //stykpris for hver tapas
        }
        

        
    }
}
