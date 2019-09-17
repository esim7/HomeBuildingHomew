using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class Team
    {
        const int zero = 0;

        public TeamLeader Leader { get; set; }
        public List<Worker> Workers { get; set; }

        public Team()
        {
            Leader = new TeamLeader();
            Workers = new List<Worker>();
        }

        public void Building(House obj)
        {
            if (obj.Basement.PercentCompletion == zero)
            {
                Basement basement = new Basement();
                int i = 0;
                while (!basement.IsBuildComplete())
                {
                    if (i > Workers.Count)
                        i = 0;
                    Workers[i].Work(basement);
                }
                obj.Basement = basement;
                Leader.Work(basement);
            }
            else if (obj.Walls.Count < obj.WallsMaxCount)
            {
                Wall wall = new Wall();
                int i = 0;
                while (!wall.IsBuildComplete())
                {
                    if (i > Workers.Count)
                        i = 0;
                    Workers[i].Work(wall);
                }
                obj.Walls.Add(wall);
                Leader.Work(wall);
            }
            else if (obj.Door.PercentCompletion == zero)
            {
                Door door = new Door();
                int i = 0;
                while (!door.IsBuildComplete())
                {
                    if (i > Workers.Count)
                        i = 0;
                    Workers[i].Work(door);
                }
                obj.Door = door;
                Leader.Work(door);
            }
            else if (obj.Windows.Count < obj.WindowsMaxCount)
            {
                Window window = new Window();
                int i = 0;
                while (!window.IsBuildComplete())
                {
                    if (i > Workers.Count)
                        i = 0;
                    Workers[i].Work(window);
                }
                obj.Windows.Add(window);
                Leader.Work(window);
            }
            else if (obj.Roof.PercentCompletion == zero)
            {
                Roof roof = new Roof();
                int i = 0;
                while (!roof.IsBuildComplete())
                {
                    if (i > Workers.Count)
                        i = 0;
                    Workers[i].Work(roof);
                }
                obj.Roof = roof;
                Leader.Work(roof);
                obj.isBuildHouseCompleted = true;
            }
        }
    }
}
