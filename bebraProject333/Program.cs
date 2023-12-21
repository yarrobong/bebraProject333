using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebraProject333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { -2, -4, 0, 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] > 0)
                {
                    numbersList[i] = 0; 
                }
            }
            
            
            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }


            Console.ReadKey();
        }
    }
}
