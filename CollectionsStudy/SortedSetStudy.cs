using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CollectionsStudy
{
    public class SortedSetStudy
    {
        public void Run()
        {
            var sw = new Stopwatch();
            sw.Start();

            SortedSet<ThirdProduct> sortedSet = new()
            {
                new ThirdProduct(4, 10), new ThirdProduct(2, 10), new ThirdProduct(3, 10), new ThirdProduct(1, 10),
                new ThirdProduct(5, 10), new ThirdProduct(8, 10), new ThirdProduct(6, 10), new ThirdProduct(7, 10),
            };

            foreach (var product in sortedSet)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("SortedSet: " + sw.ElapsedMilliseconds);
            sw.Stop();

            Console.WriteLine();

            sw.Start();
            List<ThirdProduct> productList = new()
            {
                new ThirdProduct(4, 10), new ThirdProduct(2, 10), new ThirdProduct(3, 10), new ThirdProduct(1, 10),
                new ThirdProduct(5, 10), new ThirdProduct(8, 10), new ThirdProduct(6, 10), new ThirdProduct(7, 10),
            };

            productList.Sort();

            foreach (var product in productList)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("List: " + sw.ElapsedMilliseconds);
            sw.Stop();
        }
    }
}