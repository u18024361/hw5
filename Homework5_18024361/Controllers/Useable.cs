using Homework5_18024361.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework5_18024361.Controllers
{
    public static class Useable
    {
        public static string Connection = "Data Source=.;Initial Catalog=WebStore;Integrated Security=True";
        public static List<Product> productList = new List<Product>();
    }
}