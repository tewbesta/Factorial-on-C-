﻿using System;

namespace Exercise_1
{
    class Facorial
    {
        static void Main(string[] args)
        {// creating a factorial of any number
            Console.WriteLine("Please enter a number to factorize.");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            int[] factorialelements = new int [number];
           
            for (int index=number-1; index>=0; index--)
            {
             
                factorialelements[index] = index+1;
                factorial *= factorialelements[index];
                
            }
            Console.WriteLine(factorial);
        }
    }
}
