using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleApp2
{


    class Program
    {
        

        static void Main(string[] args)
        {
            NewMethod2();
        }


        private static void NewMethod2()
        {
            
            List<IItem> katalog = new List<IItem>();

            
            string path1 = @"C:\Users\Данил\source\repos\ConsoleApp2\Книги.txt";
            using (StreamReader sr = new StreamReader(path1, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] naming = line.Split(',');

                    katalog.Add(new Book(RandomNumberGenerator.GetInt32(20, 100), RandomNumberGenerator.GetInt32(300, 700), naming[0], naming[1]));
                }
            }


            string path2 = @"C:\Users\Данил\source\repos\ConsoleApp2\Открытки.txt";
            using (StreamReader sr = new StreamReader(path2, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] naming = line.Split(',');

                    katalog.Add(new Card(RandomNumberGenerator.GetInt32(50, 100), RandomNumberGenerator.GetInt32(10, 50), naming[0], naming[1]));
                }
            }


            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(18, 30), 12, "линейка"));
            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(30, 50), 18, "линейка"));
            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(40, 100), 24, "линейка"));
            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(60, 150), 48, "линейка"));
            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(18, 30), 12, "клетка"));
            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(30, 50), 18, "клетка"));
            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(40, 100), 24, "клетка"));
            katalog.Add(new Paper(RandomNumberGenerator.GetInt32(100, 500), RandomNumberGenerator.GetInt32(60, 150), 48, "клетка"));

            foreach (IItem item in katalog  )
            {
                Console.WriteLine(item.BinarySearch(Book).Name);
                Console.WriteLine("\n");
            }
                Console.ReadLine();
            }
    }
}
