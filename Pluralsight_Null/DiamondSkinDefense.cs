using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight_Nulls
{
    public class DiamondSkinDefense : SpecialDefense
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
