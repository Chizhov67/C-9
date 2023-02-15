namespace ConsoleAppTask68
{
	internal class Program
	{
		static int AkkermanFunction(int N, int M)
		{
			if (N == 0)
			{
				return M + 1;
			}

			else if (N != 0 && M == 0)
			{
				return AkkermanFunction(N - 1, 1);
			}

			else
			{
				return AkkermanFunction(N - 1, AkkermanFunction(N, M - 1));
			}
		}

		static void Main(string[] args)
		{
			int N, M;

			Console.Write("Введите положительно число N: ");

			while ((!int.TryParse(Console.ReadLine(), out N) || N < 0))
			{
				Console.Write("Неверный ввод, Введите положительно число N: ");
			}

			Console.Write("Введите положительно число M: ");

			while ((!int.TryParse(Console.ReadLine(), out M) || M < 0))
			{
				Console.Write("Неверный ввод, Введите положительно число M: ");
			}

			Console.WriteLine("\nЗначение функции Аккермана: " + AkkermanFunction(N, M));

			Console.ReadLine();
		}
	}
}


