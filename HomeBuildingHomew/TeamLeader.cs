using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class TeamLeader : IWorker
    {
        const int zero = 0;

        public string FullName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Wage { get; set; }
        List<string> Reports;

        public TeamLeader()
        {
            FullName = "Пупкин Борис Борисыч";
            Age = 45;
            Position = "Прораб";
            Wage = 348000;
            Reports = new List<string>();
        }

        public void Work(IPart obj)
        {
            if (obj.IsBuildComplete())
                Reports.Add(obj.Type);      
        }

        public void ShowReports(House obj)
        {
            if (Reports.Count == zero)
                Console.WriteLine("Бригада еще ничего не достроила");
            else if(Reports.Count > zero && !obj.isBuildHouseCompleted)
            {
                for(int i = 0; i < Reports.Count; i++)
                {
                    Console.WriteLine("Обьект " + Reports[i] + " успешно построен");
                }
            }
            else if(obj.isBuildHouseCompleted)
            {
                Console.WriteLine("Постройка дома успешно завершена!!!");
                Console.WriteLine(obj.HousePhoto);
            }
        }

    }
}
