using CareBears.Bears;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareBears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var definitions = new Dictionary<string, List<string>>();
            definitions.Add()

            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Crystal");
                bear.Stare();
            }

            var namesThatStartWIthT = careBears.Where(bear => bear.Name.StartsWith('T'));

            var careBearNames = careBears.Select(bear => bear.Name);

            var careBearNamesThatStartWithT = careBears
                    .Where(bear => bear.Name.StartsWith('T'))
                    .Select(bear => bear.Name);

            // any returns if any one matches - returns true - as soon as it finds a match it stops
            var anyTinderHearts = careBears.Any(bear => bear is TinderHeart);

            // all only returns true if every bear is a tinderheart
            var allTinderHearts = careBears.All(bear => bear is TinderHeart);

            var otherList = new List<CareBearBase>();

            var firstBear = careBears.First();
            var firstBearStartingWithT = careBears.First(bear => bear.Name.StartsWith('T'));

            //var blowsUp = careBears.First(bear => bear.Name.StartsWith('W'));
            // below will just return "null"
            var works = careBears.FirstOrDefault(bear => bear.Name.StartsWith('W'));

            var skippedGrumpy = careBears.Skip(1).Take(2);

            var numberOfCharacters = careBears.Max(bear => bear.Name.Length);

            var orderedBears = careBears.OrderBy(bear => bear.BellyBadge);
            var orderedBears2 = careBears.OrderByDescending(bear => bear.BellyBadge);

        }
    }
}
