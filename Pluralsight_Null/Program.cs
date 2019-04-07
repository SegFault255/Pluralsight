using Pluralsight_Nulls;
using System;

namespace Pluralsight_Null
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter
            {
                DaysSinceLastLogin = 42
            };

            int days = player?.DaysSinceLastLogin ?? -1;

            
            //int days = player.DaysSinceLastLogin.Value;

            Console.WriteLine(days);


            Console.ReadLine();
        }
    }
}
