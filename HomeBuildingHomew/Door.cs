using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class Door : IPart
    {
        const int BuildComplete = 100;

        public string Type { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int PercentCompletion { get; set; }

        public Door()
        {
            Type = "Входная железная дверь";
            Price = 100000;
            Manufacturer = "ТОО Timber г. Астана ул. Сыгнак 14";
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
