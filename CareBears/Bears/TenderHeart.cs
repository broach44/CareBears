using System;
using System.Collections.Generic;
using System.Text;

namespace CareBears.Bears
{
    class TenderHeart : CareBearBase
    {
        public TenderHeart()
        {
            Name = "Tender Heart";
            BellyBadge = "Heart";
            Color = BearColor.Brown;
        }

        public override void Stare()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} shoots hearts from his belly.❤️❤️❤️❤️❤️❤️❤️❤️❤️");
        }
    }
}
