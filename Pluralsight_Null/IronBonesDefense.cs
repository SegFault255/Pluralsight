using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight_Nulls
{
    public class IronBonesDefense : SpecialDefense
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
