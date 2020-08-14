using Homework5_18024361.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework5_18024361.Controllers
{
    public class CRUDController : Controller
    {
        
        private SqlConnection myLink = new SqlConnection(Useable.Connection);
        public ActionResult Read()
        {
            try
            {
                myLink.Open();
                //read from table
                SqlCommand myCommand = new SqlCommand("SELECT Product.ID, Product.Description, Product.Price, Product.Quantity, Product.ProductType From Product ", myLink);
                //ProductType.ProductType FROM Product INNER JOIN ProductType ON Product.ProductType = ProductType.ID
                SqlDataReader myReader = myCommand.ExecuteReader();
                Useable.productList.Clear();
                while(myReader.Read())
                {
                    Product products = new Product();
                    products.ID = (int)myReader["ID"];
                    products.Description = myReader["Description"].ToString();
                    products.Price = float.Parse(myReader["Price"].ToString());
                    products.Quantity = (int)myReader["Quantity"];
                    products.ProductType = (int)myReader["ProductType"];
                   // products.Type.TypeName = myReader["TypeName"].ToString();
                    //products.Type.ID = (int)myReader["ID"];
                    Useable.productList.Add(products);

                }
            }
            catch (Exception err)
            {

                ViewBag.err = err;
            }
            finally
            {
                myLink.Close();
            }
            return View(Useable.productList);
        }
    }
}