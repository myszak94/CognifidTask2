using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCalculaor
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator();

			calculator.ReadFromUser();
			calculator.CalculateResult();
			calculator.DisplayResult();

			Console.ReadKey();
		}
	}
}
