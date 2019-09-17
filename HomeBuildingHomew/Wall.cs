using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class Wall : IPart
    {
        const int BuildComplete = 100;

        public string Type { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int PercentCompletion { get; set; }

        public Wall()
        {
            Type = "Кирпичная стена";
            Price = 410000;
            Manufacturer = "ТОО Level г. Астана ул. Кеменгерулы 17";
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
