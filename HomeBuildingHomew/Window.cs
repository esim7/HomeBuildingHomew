using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class Window : IPart
    {
        const int BuildComplete = 100;

        public string Type { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int PercentCompletion { get; set; }

        public Window()
        {
            Type = "Пластиковое окно";
            Price = 250000;
            Manufacturer = "ТОО ЛИК. г. Астана ул Ташенова 18";
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
