using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight_Nulls
{
    public abstract class SpecialDefense
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefense Null { get; } = new NullDefense();

        private class NullDefense : SpecialDefense
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; //no operation / "do nothing" behavior
            }
        }
    }
}
