using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{


    public class Customer
    {
        public List<Order> Orders;

        public Customer()
        {
           Orders = new List<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        //Let's overload this constructor
        public Customer(int id, string name)
            :this(id)
        {
            //this.Id=id;
            this.Name = name;
        }

        //default constructor
        //public Customer()
        //{

        //}
    }

}
