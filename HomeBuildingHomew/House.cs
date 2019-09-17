using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBuildingHomew
{
    public class House
    {
        public int WallsMaxCount = 4;
        public int WindowsMaxCount = 4;

        public Basement Basement { get; set; }
        public List<Wall> Walls { get; set; }
        public Door Door { get; set; }
        public List<Window> Windows { get; set; }
        public Roof Roof { get; set; }
        public bool isBuildHouseCompleted;
        public string HousePhoto = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";


        public House()
        {
            Basement = new Basement();
            Walls = new List<Wall>();
            Door = new Door();
            Windows = new List<Window>();
            Roof = new Roof();
            isBuildHouseCompleted = false;
        }
    }
}




