﻿using System;
//Assignment 02
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1

            //Console.WriteLine("enter the number");
            //String read_number= Console.ReadLine();

            //Console.WriteLine("You enter :"+read_number);

            #endregion

            #region Question2

            //String IntStringVar = "150A";
            //
            //int.TryParse(IntStringVar,out int res);
            //Console.WriteLine("The string is a valid integer: " + res);
           

            #endregion

            #region Question3

            float DividToInt = 10.6f;
            int int_value = (int)DividToInt; //explicit casting
            
            Console.WriteLine(int_value);
            #endregion
        }
    }
}
