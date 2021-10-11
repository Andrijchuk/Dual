using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        static void Task1()
        {
            int countA = 0, 
                countO = 0, 
                countI = 0, 
                countE = 0;
            Console.WriteLine("Enter text: ");
            string Text = Console.ReadLine();
            for (int j = 0; j < Text.Length; j++)
            {
                if (Text[j] == 'a')
                {
                    countA++;
                }
                if (Text[j] == 'o')
                {
                    countO++;
                }
                if (Text[j] == 'i')
                {
                    countI++;
                }
                if (Text[j] == 'e')
                {
                    countE++;
                }
            }
            int countLetters = countA + countO + countI + countE;
            Console.WriteLine("Letters: {0}\nA: {1}\nO: {2}\nI: {3}\nE: {4}", countLetters, countA, countO, countI, countE);
        }
        static void Task2()
        {
            Console.WriteLine("Enter number of month: ");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                int Mdays = System.DateTime.DaysInMonth(2021, number);
                Console.WriteLine("Days in month: {0}", Mdays);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error month!");
            }
            Console.ReadLine();
        }
        static void Task3()
        {
            Console.WriteLine("Enter 10 numbers: ");
            int number, first = 0, last = 1;
            bool check = false;
            for (int i = 0; i < 10; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (i < 5)
                {
                    if (number < 0)
                    {
                        check = true;
                    }
                    first += number;
                }
                else
                {
                    last *= number;
                }
            }
            string output = (check) ? Convert.ToString(last) : Convert.ToString(first);
            Console.WriteLine("Result: {0}.", output);
        }
    }
}
