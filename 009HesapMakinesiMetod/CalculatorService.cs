using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009HesapMakinesiMetod
{
    public class CalculatorService
    {
        public void StartScreen()
        {
            Console.WriteLine("** Metod ile Hesap Makinesi **");
        }
        public double Number1()
        {
            Console.Write("1.Sayıyı giriniz: ");
            double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public char Operation()
        {
            Console.Write("Yapmak istediğiniz işlemi seçiniz: \"+\",\"-\",\"*\",\"/\" \t");
            char c = Convert.ToChar(Console.ReadLine());
            return c;
        }
        public double Number2()
        {
            Console.Write("2.Sayıyı giriniz: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return y;
        }
        public void Sum(double x,double y)
        {
            double result = x + y;
            Console.WriteLine("Sonuç: " + x + " + " + y + "= " + result);
        }
        public void Sub(double x, double y)
        {
            double result = x - y;
            Console.WriteLine("Sonuç: " + x + " - " + y + "= " + result);
        }
        public void Mul(double x, double y)
        {
            double result = x * y;
            Console.WriteLine("Sonuç: " + x + " * " + y + "= " + result);
        }
        public void Div(double x, double y)
        {
            double result = x / y;
            Console.WriteLine("Sonuç: " + x + " / " + y + "= " + result);
        }
        public void Process(char c,double x,double y)
        {
            if (c == '+')
                Sum(x, y);
            else if (c == '-')
                Sub(x, y);
            else if (c == '*')
                Mul(x, y);
            else
                Div(x, y);
        }
    }
}
