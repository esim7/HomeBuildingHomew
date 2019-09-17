using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class Worker : IWorker
    {
        public static Random random;

        public string FullName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Wage { get; set; }
        public int WorkerSkill { get; set; }

        static Worker()
        {
            random = new Random();
        }

        public Worker(string fullName)
        {
            FullName = fullName;
            Age = random.Next(18, 38);
            Position = "строитель";
            Wage = random.Next(100000, 200000);
            WorkerSkill = random.Next(5, 10);
        }

        public void Work(IPart obj)
        {
            obj.PercentCompletion += this.WorkerSkill;
        }
    }
}
