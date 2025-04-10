using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace MiniTool
{
    class MiniTool_v1
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("   __  ____      _ ______          __  _   __  ___\r\n  /  |/  (_)__  (_)_  __/__  ___  / / | | / / <  /\r\n / /|_/ / / _ \\/ / / / / _ \\/ _ \\/ /  | |/ /  / / \r\n/_/  /_/_/_//_/_/ /_/  \\___/\\___/_/   |___/  /_/        ");
                Console.WriteLine("Made by 2unsigned");
                Console.WriteLine("1: Calculator ");
                Console.WriteLine("2: Unit Converter");
                int inp = Convert.ToInt32(Console.ReadLine());

                if (inp == 1)
                {
                    Calculator(inp);
                    
                }
                if (inp == 2)
                {
                    UnitCon(inp);
                    
                }
            }
        }

        static void Calculator(int inp)
        {

            Console.WriteLine("first number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("second number ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What operation, +, -, *, /");
            string op = Console.ReadLine();
            InpNum(num1, num2, op);


        }
        static void InpNum(double num1, double num2, string op)
        {
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            Console.WriteLine("Press any key to return to main menu...");
            Console.ReadKey();
        }

        static void UnitCon(int inp)
        {
            Console.WriteLine("1: temperature");
            Console.WriteLine("2: length");
            int inp_unit = Convert.ToInt32(Console.ReadLine());

            if (inp_unit == 1)
            {
                Temp(inp_unit);
            }

            if (inp_unit == 2)
            {
                length(inp_unit);
            }
        }

        static void Temp(int inp)
        {
            Console.WriteLine("1: °C to °F");
            Console.WriteLine("2: °F to °C");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter temperature in °C:");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter temperature in °F:");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            Console.WriteLine("Press any key to return to main menu...");
            Console.ReadKey();
        }

        static void length(int inp_unit)
        {
            Console.WriteLine("1: Km to mi");
            Console.WriteLine("2: mi to Km");
            double length = Convert.ToDouble(Console.ReadLine());

            if (length == 1)
            {
                Console.WriteLine("Enter length in Km: ");
                double KMeter = Convert.ToDouble(Console.ReadLine());
                double Mile = (KMeter / 1.609);
                Console.WriteLine($"{KMeter}Km = {Mile}mi");

                Console.WriteLine("Press any key to return to main menu...");
                Console.ReadKey();
            }
            else if (length == 2)
            {
                Console.WriteLine("Enter length in mi: ");
                double Mile = Convert.ToDouble(Console.ReadLine());
                double KMeter = (Mile * 1.609);
                Console.WriteLine($"{Mile}mi = {KMeter}Km");

                Console.WriteLine("Press any key to return to main menu...");
                Console.ReadKey();
            }



        }
    }

}