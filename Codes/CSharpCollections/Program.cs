using CSharpCollections.Models;
using System.Collections;

namespace CSharpCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Coollections 2 yerə ayrilir

            #region Non-Generic Coollection

            // Məsələn:

            #region ArrayList

            ArrayList arrayList = new ArrayList(); // arxada object tipinde array yaradilir (private object?[] _items;)
            arrayList.Add(1);           // int elave etdik
            arrayList.Add("string");    // string elave etdik 
            arrayList.Add(true);        // boolean elave etdik
            arrayList.Add(false);       // boolean elave etdik
            arrayList.Add(10.5);        // double elave etdik
            arrayList.Add(new Student() { Id = 1, Name = "Emil"}); // Student elave etdik

            Console.WriteLine(arrayList.Count); // 6
            Console.WriteLine(arrayList.Capacity);// 8 (default 4-dur, lazim olduqda 2-qat artirilir)

            arrayList.Remove(10.5); // 10.5 silindi
            Console.WriteLine(arrayList.Count); // 5

            arrayList.RemoveAt(0); // 0-cı index silindi
            Console.WriteLine(arrayList.Count); // 4

            arrayList.Insert(0, "new string"); // 0-cı indexə "new string" elave edildi
            Console.WriteLine(arrayList.Count); // 5

            arrayList.Clear(); // butun elementler silindi
            Console.WriteLine(arrayList.Count); // 0

            arrayList.AddRange(arrayList); // arrayList-in butun elementleri arrayList-e elave edildi
            Console.WriteLine(arrayList.Count); // 0

            arrayList.AddRange(new int[] {3,4,5}); // yeni int array elave edildi
            Console.WriteLine(arrayList.Count); // 3

            arrayList.Add(new int[] {9,8,7}); // yeni int array elave edildi
            Console.WriteLine(arrayList.Count); // 4

            Console.Clear();
            // arrayList-in butun elementlerini ekrana cixardiriq
            foreach (var item in arrayList)
            {   // item-in tipi object-dir
                if (item is Array arr)
                {    // item-in tipi array-dir
                    foreach (var intary in arr)
                    {   // int array-in butun elementlerini ekrana cixardiriq
                        Console.WriteLine(intary);
                    }
                }
            }

            #endregion



            #endregion

            #region Generic Coollection

            #endregion
        }
    }
}
