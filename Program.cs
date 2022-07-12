using System; 
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection namespace

            ArrayList list=new ArrayList();
            // list.Add("Ayşe");
            // list.Add(2);
            // list.Add(true);
            // list.Add('A');
            
            // //içerisinde verilere erişme
            // Console.WriteLine(list[1]);

            // foreach (var item in list)
            //     Console.WriteLine(item);

            // //AddRange
            // Console.WriteLine("***** Add Range *****");
            // string[] colors={"Kırmızı","Sarı","Yeşil"};
            List<int> numbers=new List<int>(){1,8,3,7,9,92,5};
            // list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
                Console.WriteLine(item);
            //Sort
            Console.WriteLine("***** Sort *****");
            list.Sort();

            foreach (var item in list)
                Console.WriteLine(item);
            //Binary Search
            Console.WriteLine("***** Binary Search ");
            Console.WriteLine(list.BinarySearch(9));

            //Revers
            Console.WriteLine("***** Reverse *****");
            list.Reverse();
            foreach (var item in list)
                Console.WriteLine(item);
            //Clear
            Console.WriteLine("***** Clear *****");
            list.Clear();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}