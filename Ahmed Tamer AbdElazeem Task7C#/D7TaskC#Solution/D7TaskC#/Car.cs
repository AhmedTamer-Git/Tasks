using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7TaskC_
{
    internal class Car
    {
        #region attributes

        private int id;
        private string brand;
        private double price;

        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
        #endregion
        
        #region Constructors
        public Car() 
        {
            id = 0; 
            brand = "Unknown";
            price = 0.0; 
        }
        public Car(int _id, string _brand, double _price)
        { 
            id = _id; 
            brand = _brand; 
            price = _price;
        }
        public Car(int _id) : this(_id, "Unknown", 0.0)
        { }
        
        public Car(int _id, string _brand) : this(_id, _brand, 0.0)
        { }
        
        #endregion
            
        public override string ToString() => $"Id= {Id} , Brand= {Brand} , Price= {Price}";
        
    }
        
}
