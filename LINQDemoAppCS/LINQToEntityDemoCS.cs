using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQDemoAppCS.EFDemos;

namespace LINQDemoAppCS
{
    class LINQToEntityDemoCS
    {
        static void Main(string[] args)
        {
            ICT22022DBEntities ICT2DBEF = new ICT22022DBEntities();
            EFDemos.Category newCategory = new EFDemos.Category();
            newCategory.CategoryID = 5;
            newCategory.ProductCategory = "Farming";
            ICT2DBEF.Categories.Add(newCategory);
            ICT2DBEF.Entry(newCategory).State = System.Data.EntityState.Added;
            ICT2DBEF.SaveChanges();
            foreach (Category category in ICT2DBEF.Categories)
            {
                Console.WriteLine(category.ProductCategory);
            }
           

            Console.ReadKey();
        }
    }
}
