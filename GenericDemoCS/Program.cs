using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class Program
    {
        static void Main1(string[] args)
        {
            GenericFirstTest<int> intTest = new GenericFirstTest<int>();
            intTest.X = 22;
            intTest.PrintData();
            Console.WriteLine(intTest.GetData());
            Console.WriteLine("===========");

            GenericFirstTest<float> floatTest = new GenericFirstTest<float>();
            floatTest.X = 22.55f;
            floatTest.PrintData();
            Console.WriteLine(floatTest.GetData());
            Console.WriteLine("===========");

            GenericFirstTest<Book> bookTest = new GenericFirstTest<Book>();
            
            //bookTest.X = new Book { BookID = 111, Title = "C Programming", Amount = 300 };
            
            Book book = new Book();
            book.BookID = 111;
            book.Title = "Software Engineering";
            book.Amount = 400;
            bookTest.X = book;

            bookTest.PrintData();
            Console.WriteLine(bookTest.GetData());
            
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            GenericTestTwo GenTest2 = new GenericTestTwo();
            GenTest2.ShowData<int>(33);
            GenTest2.ShowData<float>(55.43f);

            Book book = new Book();
            book.BookID = 111;
            book.Title = "Software Engineering";
            book.Amount = 400;
            GenTest2.ShowData<Book>(book);

            GenTest2.ShowData<int, float>(22);
            GenTest2.ShowData<int, float>(22, 55.42f);
            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            //GenericRestTest<Student> studentTest = new GenericRestTest<Student>();

            //IClassDesign ICDRef = new Student();
            //ICDRef.ShowData();

            List<IClassDesign> ICDList = new List<IClassDesign>();
            ICDList.Add(new Student { StudentID = 1, Name = "ABC" });
            ICDList.Add(new Customer { CustomerId = 101, Name = "XYZ" });
            ICDList.Add(new Student { StudentID = 2, Name = "PQR" });
            ICDList.Add(new Customer { CustomerId = 201, Name = "SDF" });

            foreach (IClassDesign ICD  in ICDList)
            {
                ICD.ShowData();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            IClassBase<int> objCBA = new ClassBaseA();
            
            Console.ReadKey();
        }
}
