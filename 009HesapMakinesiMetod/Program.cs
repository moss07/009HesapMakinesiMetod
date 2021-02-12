using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009HesapMakinesiMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService calculatorService = new CalculatorService();
            calculatorService.StartScreen();
            double x = calculatorService.Number1();
            char c = calculatorService.Operation();
            double y = calculatorService.Number2();
            calculatorService.Process(c, x, y);

            Console.ReadLine();
        }
    }
}
