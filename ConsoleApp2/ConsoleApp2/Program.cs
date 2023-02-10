using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("숫자 두개를 입력하세요.");
			Console.Write("첫 번째 숫자 입력 : ");
			string str1 = Console.ReadLine();
			Console.Write("두번째 숫자 입력 : ");
			string str2 = Console.ReadLine();
			int n1 = Convert.ToInt32(str1);
			int n2 = Convert.ToInt32(str2);
			if (n1 + n2 <= 10) Console.WriteLine("두 숫자의 합은 10 이하 입니다.");
			else if (n1 + n2 <= 20) Console.WriteLine("두 숫자의 합은 20 이하 입니다.");
			else if (n1 + n2 <= 30) Console.WriteLine("두 숫자의 합은 30 이하 입니다.");
			else					Console.WriteLine("두 숫자의 합은 최소 30 이상 입니다.");
			if (n1 % 2 == 0) Console.Write("짝");
			else			 Console.Write("홀");
			if (n2 % 2 == 0) Console.WriteLine("짝");
			else			 Console.WriteLine("홀");
			Console.Write("반복할 숫자 입력 : ");
			string str3 = Console.ReadLine();
			int n3 = Convert.ToInt32(str3);
			for (; n3 > 0; n3--)
			{
				Console.WriteLine("남은 반복 횟수 : " + n3); 
			}
			Console.Write("반복할 숫자 입력 : ");
			str3 = Console.ReadLine();
			n3 = Convert.ToInt32(str3);
			while (n3 > 0)
			{
				Console.WriteLine("남은 반복 횟수 : " + n3);
				n3--;
			}
		}
	}
}
