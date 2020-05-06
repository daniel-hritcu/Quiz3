using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Test Data: \nThe members of the list are:");

            //Get random numbers
            List<int> numbers = GetNumbers(7);

            //Print random numbers:
            Console.WriteLine(String.Join(" ", numbers));


            NumbersLowerThan80(numbers);

            Console.ReadKey();
        }

        //input - int count
        //output - list of random numbers of length cout.
        static List<int> GetNumbers(int count) {
            //Random number generator
            Random random = new Random();

            //new empty list to store our numbers
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                //get numbers
                numbers.Add(random.Next(0, 500));
            }
           
            return numbers;
        }

        static void NumbersLowerThan80(List<int> numbers) 
        {
            Console.WriteLine("The numbers greater than 80 are:");
            foreach (int number in numbers)
            {
                if (number > 80) 
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void printNumbers(List<int> numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write(i);
            }
        }
    }
}
