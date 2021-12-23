using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{

    class Parts
    {
        string name;
        string producer;
        double price;
        int quantity;
        

        public Parts(string name, string producer, double price, int quantity)
        {
            this.Name = name;
            this.Producer = producer;
            this.Price = price;
            this.Quantity = quantity;
           
        }

        public string Name { get => name; set => name = value; }
        public string Producer { get => producer; set => producer = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override string ToString()
        {
            return $"{name};  {producer}; {price}; {quantity}";
        }



    }

}
