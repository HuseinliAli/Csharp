using System;
using System.Collections.Generic;

namespace Collections
{
    class Product
    {
        public string name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar=new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);
            sayilar.Add(40);

            List<string>isimler=new List<string>();

            isimler.Add("ali");
            isimler.Add("ahmet");
            isimler.Add("aldi");
            isimler.Add(null);
            
            List<Product> urunler1=new List<Product>()
            {
                new Product(){name="Iphone X"},
                new Product(){name="Iphone Xi"},
                new Product(){name="Iphone iX"},
                new Product(){name="Iphone Xii"},
            };
             List<Product> urunler2=new List<Product>()
            {
                new Product(){name="Smsng Galaxy3"},
                new Product(){name="Smsng Galaxy5"},
                new Product(){name="Smsng Galaxy7"},
                new Product(){name="Smsng Galaxy1"},
            };
            // urunler1.AddRange(urunler2);
            // foreach (var item in urunler1)
            // {
            //     Console.WriteLine(item.name);
            // }
            // urunler1.ForEach(p=> {
            //     Console.WriteLine(p.name);
            //     });
            int count=urunler1.Count;
            // System.Console.WriteLine(count);
            // System.Console.WriteLine(urunler2[1].name);
            // for(int i=urunler2.Count-1;i>=0; i--)
            // {
            //     System.Console.WriteLine(urunler2[i].name);
            // }
            sayilar.Insert(2,300);
            // sayilar.Add(21);
            // foreach(var item in sayilar)
            // {
            //     System.Console.WriteLine(item);
            // }
            urunler2.InsertRange(3,urunler1);
            foreach(var item in urunler2)
            {
                System.Console.WriteLine(item.name);
            }
        }
    }
}