using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public interface IWorker
    {
        string FullName { get; set; }
        int Age { get; set; }
        string Position { get; set; }
        int Wage { get; set; }

        void Work(IPart obj);
    }
}
