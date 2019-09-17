using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class Basement : IPart
    {
        public const int BuildComplete = 100;

        public string Type { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int PercentCompletion { get; set; }

        public Basement()
        {
            Type = "Бетонный фундамент";
            Price = 2250000;
            Manufacturer = "ТОО Фундамент. г. Астана м-он Коктал 18";
            PercentCompletion = 0;
        }

        public bool IsBuildComplete()
        {
            if (PercentCompletion >= BuildComplete)
                return true;
            else
                return false;
        }
    }
}
