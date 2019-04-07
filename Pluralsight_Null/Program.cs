using Pluralsight_Nulls;
using System;

namespace Pluralsight_Null
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter
            {
                Name = "",
                //DaysSinceLastLogin = 42
            };


            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
