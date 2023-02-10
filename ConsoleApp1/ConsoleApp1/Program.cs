using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사칙연산 할 두 숫자를 적으세요.");
            Console.Write("첫 번째 숫자 : ");
            string str1 = Console.ReadLine();
            Console.Write("두번째 숫자 : ");
            string str2 = Console.ReadLine();
            int n1 = Convert.ToInt32(str1);
            int n2 = Convert.ToInt32(str2);
            Console.WriteLine(n1 + n2);
            Console.WriteLine(n1 - n2);
            Console.WriteLine(n1 * n2);
            Console.WriteLine(n1 / n2);
            Console.WriteLine(n1 % n2);
            Console.Write("숫자 하나를 더 추가 입력하세요 : ");
            string str3 = Console.ReadLine();
            int n3 = Convert.ToInt32(str3);
            n3 += n1;
            Console.WriteLine(n3);
            n3 += n2;
            Console.WriteLine(n3);
            n3 -= n1;
            Console.WriteLine(n3);
            n3 -= n2;
            Console.WriteLine(n3);
            n3 *= n1;
            Console.WriteLine(n3); 
            n3 *= n2;
            Console.WriteLine(n3); 
            n3 /= n1;
            Console.WriteLine(n3);
            n3 /= n2;
            Console.WriteLine(n3);
            n3 %= n1;
            Console.WriteLine(n3);
            n3 %= n2;
            Console.WriteLine(n3);
            Console.WriteLine(++n3);
            Console.WriteLine(--n3);
            Console.WriteLine(n3++);
            Console.WriteLine(n3--);
        }
    }
}
