using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи");
            int p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    {
                        Console.WriteLine("Введите колтчество дней");
                        int n = int.Parse(Console.ReadLine());
                        DateTime date = new DateTime(2000, 1, 1).AddDays(n);
                        Console.WriteLine($"Текущий месяц: {date.ToString("MMMM")} "); 
                    }

                    break;

                case 2:
                    {
                        int[,] goals = new int[7, 3] { { 1, 2, 0 }, { 0, 2, 0 }, { 1, 3, 0 }, { 2, 1, 0 }, { 1, 1, 0 }, { 2, 3, 0 }, { 2, 3, 1 } };
                        int count = CountPlayersWithTwoOrMoreGoals(goals);
                        Console.WriteLine("Количесто игроков забивших 2 гола: "+ count);
                        int CountPlayersWithTwoOrMoreGoals(int [,] goals)
                        {
                             int count = goals.Length / goals.Rank;
                            int PlayersWithTwoOrMoreGoals = count;
                            for (int i = count - 1; i >= 0; i--)
                            {
                                for (int j = goals.GetLength(1) -1; j>=0; j-- )
                                {
                                    if (goals[i, j] < 2)
                                    {
                                        PlayersWithTwoOrMoreGoals--;
                                        break;
                                    }
                                }
                            }
                            return PlayersWithTwoOrMoreGoals;
                        }
                    }

                    break;

                case 3:
                    {
                        Console.WriteLine("");
                        
                            
                    }
                    break;

            }
            Console.ReadKey();
        }
    }
}
