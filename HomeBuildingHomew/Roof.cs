using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class Roof : IPart
    {
        const int BuildComplete = 100;

        public string Type { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int PercentCompletion { get; set; }

        public Roof()
        {
            Type = "Черепичная крыша";
            Price = 498000;
            Manufacturer = "ТОО Строитель. г. Астана пр Женис 1/1";
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
