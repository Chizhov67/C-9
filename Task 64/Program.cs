namespace ConsoleAppTask64
{
	internal class Program
	{
		public static void printNumber(int N)
		{
			if (N == 0)
			{
				return;
			}

			else
			{
				Console.Write(N + " ");
				printNumber(N - 1);
			}
		}
		static void Main(string[] args)
		{
			int N;

			Console.Write("Введите натуральное число N (больше 1): ");

			while ((!int.TryParse(Console.ReadLine(), out N) || N < 1))
			{
				Console.Write("Неверный ввод, Введите натуральное число N (больше 1): ");
			}

			printNumber(N);
			Console.ReadLine();
		}
	}
}

