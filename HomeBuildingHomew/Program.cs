using System;

namespace HomeBuildingHomew
{
    class Program
    {
        static void Main(string[] args)
        {
            const int zero = 0;
            House house = new House();
            Team team = new Team();
            bool limitInitTeam = false;
            bool isActive = true;
            string key;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Инициализировать бригаду \n2. Начать постройку дома \n3. Отчет от прораба" +
                    " \n4. Список бригады\n5. Выход");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        {
                            if(!limitInitTeam)
                            {
                                Console.WriteLine("Сколько рабочих в вашей бригаде?");
                                int workerCount; int.TryParse(Console.ReadLine(), out workerCount);
                                for(int i = 0; i < workerCount; i++)
                                {
                                    Console.WriteLine("Введите имя " + (i + 1) + " рабочего");
                                    string name = Console.ReadLine();
                                    Worker worker = new Worker(name);
                                    team.Workers.Add(worker);
                                }
                                TeamLeader leader = new TeamLeader();
                                team.Leader = leader;
                                limitInitTeam = true;
                            }
                            else if(limitInitTeam)
                            {
                                Console.WriteLine("Бригада уже инициализирована");
                            }
                        }
                        break;
                    case "2":
                        {
                            team.Building(house);
                        }
                        break;
                    case "3":
                        {
                            team.Leader.ShowReports(house);
                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine(team.Leader.FullName + " - " + team.Leader.Position);
                            for (int i = 0; i < team.Workers.Count; i++)
                            {
                                Console.WriteLine(team.Workers[i].FullName + " - " + team.Workers[i].Position);
                            }
                        }
                        break;
                    case "5":
                        {
                            isActive = false;
                        }
                        break;
                }
                Console.ReadLine();
            } while (isActive != false);
        }
    }
}
