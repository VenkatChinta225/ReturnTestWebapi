using ReturnTestWebapi.Controllers;
using System;

namespace ReturnTestWebapi
{
    public class OfferService
    {

        //Private property called Inventory which is a list of Products.

        private  List<Product> Inventory =new List<Product>();

//        Private function that creates the following 6 products and adds them to
//’Inventory’

         private void AddProducts()
        {
            Product product = new Product("p1",1000, "p1 desc");
            Product product1 = new Product("p2", 200, "p2 desc");
            Product product2 = new Product("p3", 400, "p2 desc");
            Product product3 = new Product("p4", 700, "p4 desc");
            Product product4 = new Product("p5", 600, "p5 desc");
            Product product5 = new Product("p6", 800, "p6 desc");

            Inventory.Add(product);
            Inventory.Add(product1);
            Inventory.Add(product2);
            Inventory.Add(product3);
            Inventory.Add(product4);
            Inventory.Add(product5);


        }

//        Public function named ‘GetAllProducts()’ that returns the products in the
//‘Inventory’ property.
          public List<Product> GetAllProducts()
        {
            return Inventory;
        }


        public void AddProduct(Product product)
        {
            Inventory.Add(product);
        }

        public void GetTodaysOffers()
        {

        }
        //        Public function named ‘GetTodaysOffers()’ that generates and returns four new
        //Offers with 3 random products each.
        //For example:
        //i) “ComboPackage1”, with 3 random products.
        //ii) “ComboPackage2”, with 3 random products.
        //iii) “ComboPackage3”, with 3 random products.
        //iv) “ComboPackage4”, with 3 random products.


    }
}
