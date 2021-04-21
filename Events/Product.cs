using System;
using System.Collections.Generic;
using System.Text;

namespace Events  // eventler delegedir
{

    public delegate void StockControl();
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {  //get stoğu okumak set stoğu yazmak
            get { return _stock; }
            set
            {
                _stock = value; //stoğu set etmek
                if (value<=15 && StockControlEvent != null)  //yani event e abone olmuşsa
                {
                    StockControlEvent();
                    
                }

            }
        }
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock amount : {0}", Stock,ProductName);
        }

        
    }
}
