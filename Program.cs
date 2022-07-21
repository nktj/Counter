namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int rangeBiggin, rangeEnd;
                uint evenCount = 0, oddCount = 0;
                long evenSum = 0, oddSum = 0;

                List<int> evenNumbers = new List<int>();
                List<int> oddNumbers = new List<int>();

                try
                {
                    Console.WriteLine("Введите начало диапозона");
                    rangeBiggin = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите конец диапозона");
                    rangeEnd = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не корректный ввод");
                    Console.WriteLine("Нажмите Enter, чтобы продолжить...");
                    Console.ReadLine();
                    continue;
                }

                for (int i = rangeBiggin; i <= rangeEnd; ++i)
                {
                    if(i % 2 == 0)
                    {
                        evenNumbers.Add(i);
                        evenCount++;
                        evenSum += i;
                    }
                    else
                    {
                        oddNumbers.Add(i);
                        oddCount++;
                        oddSum += i;

                    }
                }

                Console.WriteLine(new String('-', 25));

                Console.WriteLine("Четные числа:");
                Console.WriteLine(string.Join(" ", evenNumbers));
                Console.WriteLine("Колличество = " + evenCount);
                Console.WriteLine("Сумма = " + evenSum);

                Console.WriteLine(new String('-', 25));

                Console.WriteLine("Нечетные числа:");
                Console.WriteLine(string.Join(" ", oddNumbers));
                Console.WriteLine("Колличество = " + oddCount);
                Console.WriteLine("Сумма = " + oddSum);

                Console.WriteLine(new String('-', 25));

                Console.WriteLine("Нажмите Enter, чтобы продолжить...");
                Console.ReadLine();

            } 
        }
    }
}