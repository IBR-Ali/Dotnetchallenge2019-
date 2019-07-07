﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите действительную часть первого комплексного числа: ");
            int realPart = Int32.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            int imaginaryPart = Int32.Parse(Console.ReadLine());
            ComplexNumber firstNumber = new ComplexNumber(realPart, imaginaryPart);

            Console.Write("Введите действительную часть второго комплексного числа: ");
            realPart = Int32.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть второго комплексного числа: ");
            imaginaryPart = Int32.Parse(Console.ReadLine());
            ComplexNumber secondNumber = new ComplexNumber(realPart, imaginaryPart);

            Console.Write("Выберите производимое действие: (с)ложение, (в)ычитание, (у)множение. ");
            string operation = Console.ReadLine();
            Calculator calc = new Calculator();

            switch (operation)
            {
                case "с":
                    calc.Addition(firstNumber, secondNumber);
                    break;
                case "в":
                    calc.Subtraction(firstNumber, secondNumber);
                    break;
                case "у":
                   calc.Multiplication(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Данное действие недопустимо");
                    break;
            }

            Console.ReadLine();
        }
    }
}
