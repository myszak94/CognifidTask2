using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCalculaor
{
	public class Calculator
	{
		private List<int> lines;
		private int finalResult;

		public Calculator()
		{
			lines = new List<int>();
		}
		public int ReadAndCalculateLine(string line)
		{
			var numbers = line.Split(',');
			var sum = 0;

			foreach (var number in numbers)
			{
				if (int.TryParse(number, out var temp))
				{
					sum += temp;
				}
			}

			return sum;
		}

		public void ReadFromUser()
		{
			Console.WriteLine(@"Jako dane wejściowe, aplikacja
przyjmuje ciąg znaków będących liczbami oddzielonymi separatorami (,).
Znak nowej linii reprezentuje operację odejmowania/dodawania
kolejnego wprowadzonego bloku danych. Wiersze parzyste będą posiadały na początku znak
odejmowania z kolei wiersze nieparzyste znak dodawania.
Podwójny znak nowej linii powoduje wyświetlenie wyniku operacj.

Zacznij wprowadzanie danych:");

			while (true)
			{
				var line = Console.ReadLine();
				if (string.IsNullOrEmpty(line))
				{
					break;
				}

				var sum = ReadAndCalculateLine(line);
				lines.Add(sum);
			}
		}

		public void CalculateResult()
		{
			var result = 0;
			var odd = true;
			foreach (var line in lines)
			{
				if (odd)
				{
					result += line;
				}
				else
				{
					result -= line;
				}

				odd = !odd;
			}

			finalResult = result;
		}

		public void DisplayResult()
		{
			Console.WriteLine($"Wynik wykonanych operacji to: {finalResult}");
		}
	}
}
