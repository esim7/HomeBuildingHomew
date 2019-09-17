using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public interface IPart
    {
        string Type { get; set; }
        int Price { get; set; }
        string Manufacturer { get; set; }
        int PercentCompletion { get; set; }

        bool IsBuildComplete();
    }
}
