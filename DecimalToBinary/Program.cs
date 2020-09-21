using System;
using System.Net.NetworkInformation;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input from user
            Console.WriteLine("Please enter the number in decimal: ");
            int numberDecimal = int.Parse(Console.ReadLine());

            //initialize binary number holding array
            int[] numberBinary = new int[20];
            for (int i=0; i<numberBinary.Length; i++)
            {
                numberBinary[i] = 0;
            }
            
            //conversion to binary
            if (numberDecimal > 0)
            {
                for (int i = 1; i <= numberDecimal; i++)
                {
                    int locationOnArray = 0;

                    while (numberBinary[locationOnArray] == 1)
                    {
                        locationOnArray += 1;
                    }
                    numberBinary[locationOnArray] = 1;
                    for (int j = 0; j < locationOnArray; j++)
                    {
                        numberBinary[j] = 0;
                    }
                }
            }
            else if (numberDecimal < 0)
            {
                Console.WriteLine("Sorry! Only non-negative numbers accepted!");
            }

            //display the binary number
            Console.Write($"The number {numberDecimal} is the following in binary: ");
            for (int i=numberBinary.Length-1; i>=0; i--)
            {
                Console.Write(numberBinary[i]) ;
            }
            Console.WriteLine();
            
        }
    }
}
