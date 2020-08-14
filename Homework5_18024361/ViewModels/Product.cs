using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework5_18024361.ViewModels
{
    public class Product
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int ProductType { get; set; }
        public ProductTypeViewModel Type { get; set; }

    }
}