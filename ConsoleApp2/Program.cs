using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store store = new Store();


            Notebook nt1 = new Notebook
            {
                Brand = "Apple",
                Model = "AirMAcbook",
                Price = 2450,
                Ram = 8,
                CPU = 4.2,


            };


            Notebook nt2 = new Notebook
            {
                Brand = "Apple",
                Model = "AirMAcbookpro",
                Price = 3450,
                Ram = 16,
                CPU = 4.2,
            };

            Notebook nt3 = new Notebook
            {
                Brand = "Apple",
                Model = "AirMAcbook",
                Price = 2550,
                Ram = 8,
                CPU = 4.2,
            };

            Phone phone = new Phone
            {
                Brand = "Apple",
                Model = "13pro",
                Price = 3200,
                Simcount = 1,
            };
            Phone phone1 = new Phone
            {

                Brand = "Apple",
                Model = "13promax",
                Price = 3400,
                Simcount = 1,
            };

            Store.AddProduct(nt1);
            Store.AddProduct(nt2);
            Store.AddProduct(nt3);
            Store.AddProduct(phone1);
            Store.AddProduct(phone1);

            Console.WriteLine(store.GetNotebookCount());

        }
    }
}
