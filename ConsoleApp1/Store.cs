using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Store
    {

        public static List<Phone> Phones;
        public static List<Product> AllProducts;    
        public static List <Notebook> Notebooks;


        Store store = new Store();



        public static void AddProduct(Product product)
        {
          
            AllProducts.Add(product);

        }
     

        public int  GetNotebookCount()
        {
            int count = 0;
            foreach (var item in AllProducts)
            {
                if (item is Notebook)
                
                    count++;
       
            }
            return count;
        }

        public int GetPhoneCount()
        {
            int Count=0;  
            foreach(var item in AllProducts)
            {
                if (item is Phone)
                {
                    Count++;
                }
            }   
            return Count;
        }
       
    }
}
