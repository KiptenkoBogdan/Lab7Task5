using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = 2230;
            ArrayList numbers = new ArrayList(volume);
            Random rnd = new Random();
            
            for(int i = 0; i < volume; i++)
                numbers.Add(rnd.Next(300, 700));

            numbers.Sort();

            Console.WriteLine("\tSorted ArrayList");
            foreach (int item in numbers)
                Console.Write("{0} ", item);
            
            numbers.Insert(7, 7);

            int newNum1 = rnd.Next(0, 1007);
            if (numbers.Contains(newNum1))
            {
                Console.WriteLine("\nArray contains number {0} ", newNum1);
                Console.WriteLine("Index of element: {0}", numbers.IndexOf(newNum1));
            }
            else
                Console.WriteLine("Array does not contain number {0} ", newNum1);

            int newNum2 = rnd.Next(0, volume);
            if (numbers.Contains(newNum2))
            {
                Console.WriteLine("\nArray contains number {0} ", newNum1);
                Console.WriteLine("Index of deleted element: {0}", numbers.IndexOf(newNum2));
            }
            else
                Console.WriteLine("Array does not contain number {0}", newNum2);

            Console.WriteLine("\tSorted ArrayList");
            foreach (int item in numbers)
                Console.Write("{0} ", item);

            numbers.Clear();
            Console.ReadKey();
        }
    }
}
