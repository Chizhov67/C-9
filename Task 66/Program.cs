namespace ConsoleAppTask66
{
	internal class Program
	{
		public static int printNumber(int N, int M, int sum)
		{
			if (M > N)
			{
				return sum;
			}

			else
			{
				return printNumber(N, M + 1, sum += M);
			}
		}
		static void Main(string[] args)
		{
			int N, M;

			Console.Write("Введите натуральное число M (больше 1): ");

			while ((!int.TryParse(Console.ReadLine(), out M) || M < 1))
			{
				Console.Write("Неверный ввод, Введите натуральное число M (больше 1): ");
			}
			
			Console.Write("Введите натуральное числ N (больше 1): ");

			while ((!int.TryParse(Console.ReadLine(), out N) || N < 1))
			{
				Console.Write("Неверный ввод, Введите натуральное число N (больше 1): ");
			}

			Console.WriteLine($"\nСумма натуральных элементов в промежутке от {M} до {N}: {printNumber(N, M, 0)}");
			Console.ReadLine();
		}
	}
}

