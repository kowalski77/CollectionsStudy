using System;
using System.Collections.Generic;

namespace CollectionsStudy
{
    public class HashSetStudy
    {
        public void Run()
        {
            var hashSet = new HashSet<SimpleProduct>
            {
                new(1, 10),
                new(2, 10),
                new(3, 10),
                new(4, 10),
                new(4, 10)
            };

            Console.WriteLine(hashSet.Count);
            if (hashSet.Contains(new SimpleProduct(2, 10)))
            {
                Console.WriteLine("Yes");
            }
        }
    }
}