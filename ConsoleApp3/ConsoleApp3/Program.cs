using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("더할 두 숫자를 입력하세요.");
            Console.Write("첫번째 숫자 : ");
            string str1 = Console.ReadLine();
            Console.Write("두번째 숫자 : ");
            string str2 = Console.ReadLine();
            int n1 = Convert.ToInt32(str1);
            int n2 = Convert.ToInt32(str2);
            Plus(n1, n2);
            for (int i = 1; i < 6; i++)
            {
                int j = 0;
                while(j<i)
                {
                    Console.Write("@");
                    j++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i = 5; i > 0; i--)
            {
                int j = 0;
                while(j<i)
                {
                    Console.Write("@");
                    j++;
                }
                Console.WriteLine();
            }
        }
        static int Plus(int number1, int number2)
        {
            int NewNumeber = number1 + number2;
            return NewNumeber;
        }
    }
}
