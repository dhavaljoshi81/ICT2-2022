using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQDemoAppCS.LINQToSQLLib;


namespace LINQDemoAppCS
{
    class LINQToSQLDemo
    {
        static void Main1(string[] args)
        {
            ICT22022DBDataContext ICT2DC 
                = new ICT22022DBDataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ICT22022DB.mdf;Integrated Security=True");

            Category newCategory = new Category();
            newCategory.CategoryID = 4;
            newCategory.ProductCategory = "Eye wears";

            ICT2DC.Categories.InsertOnSubmit(newCategory);
            ICT2DC.SubmitChanges();

            foreach (Category category in ICT2DC.Categories)
            {
                Console.WriteLine(category.CategoryID + " - " + category.ProductCategory);
            }

            Console.WriteLine("-------------------");

            foreach (Product product in ICT2DC.Products)
            {
                Console.WriteLine(product.ProductID + " - " + product.ProductName
                    + " - " + product.Quantity + " - " + product.Rate + " - "
                    + product.Category.ProductCategory);
            }
            Console.ReadKey();
        }
    }
}
