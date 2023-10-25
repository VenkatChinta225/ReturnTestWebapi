using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ReturnTestWebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Product
    {

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ProductName { get; set; }

      public  Product(string description, decimal price, string productName)
        {
            Description = description;
            Price = price;
            ProductName = productName;
        }
    }

    public class Offer {

        public string OfferName { get; set; }

        public List<Product> Products { get; set; }

      public  Offer(string offerName, List<Product> products)
        {
            OfferName = offerName;
            Products = products;
        }
    }


    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        OfferService offServvice = new OfferService();
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }




        [HttpGet(Name = "GetAllProducts")]
        public IEnumerable<Product> Get()
        {




            //            Write a program that loops through[1..100]. It should do the following:
            //a) If the number is divisible by 3, print “fizz”.
            //b) If divisible by 5 print “buzz”.
            //c) If divisible by 3 & 5, print “fizzbuzz”.

            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                if (i % 3 == 0)
                {
                    //Console.WriteLine("fizz");
                    output = "fizz";

                }
                if (i % 5 == 0)
                {
                    output = output + "buzz";
                }
                Console.WriteLine(output);
            }


            //            Write a program to reverse a string “abcdef” --> “fedcba” without using the.NET
            //reverse() function

            string input = "abcdef";
            string reversedstring = String.Empty;
            for (int i = input.Length; i > 0; i--)
            {
                reversedstring = reversedstring + input[i - 1];
            }



            var allproducts = offServvice.GetAllProducts();

            return  allproducts.OrderByDescending(x => x.Price).Take(3);

        }

        [HttpGet(Name = "GetSecondProduct")]
        public Product GetSecondProduct()
        {


            var allproducts = offServvice.GetAllProducts();

           // return allproducts.OrderByDescending(x => x.Price).Take(3);

            return allproducts.OrderByDescending(x => x.Price).Skip(1).FirstOrDefault();
          //  allproducts.OrderBy(p => p.Price).Select(p => p.Name).First();

        }

        [HttpPost(Name = "AddProduct")]
        public void AddProduct(Product product)
        {

            offServvice.AddProduct(product);

        }



        }
}