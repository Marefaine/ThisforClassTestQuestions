// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace RedoTestQuestions
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter any Number we will be adding");
            int x = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter any Number to add");
            int y = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("This is equal to " + (x + y));*/



            string aa, bb;

            Console.WriteLine("Input the 1st string:");
            aa = Console.ReadLine();

            Console.WriteLine("Input the 2nd string:");
            bb = Console.ReadLine();




            if (aa.Length != bb.Length)
            {
                Console.WriteLine("These lines do not equal and the strings are not the same");

            }
            else
            {
                bool equal = true;
                for (int i = 0; i < aa.Length; i++)
                {
                    if (aa[i] != bb[i])
                    {
                        equal = false;
                        break;
                    }
                }



                if (equal)
                {
                    Console.WriteLine("The length of both strings are equal and also, both strings are equal.");

                }
                else
                {
                    Console.WriteLine("The length of both strings are equal, but the strings are not the same");
                }

            }









        }
    }
}

