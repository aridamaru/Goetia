using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Goetia.CharacterDetails;

namespace Goetia.CharacterDetails
{
    public static class PlayerAttributes
    {
        //HP == Health Point
        //WalkingSkeleton version of the method
        public static int GetMaxHPAmount(int level, Profession playerProfession)
        {
            return 100;
        }

        //MP == Mana Points
        //WalkingSkeleton version of the method
        public static int GetMaxMPAmount(int level , Profession playerProfession)
        {
            return 100;
        }
        //
        //WalkingSkeleton version of the method
        public static int GetNativeDamage(int level, Profession playerProfession)
        {
            return 0;
        }
    }
}
