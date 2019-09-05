using legos.minifigures;
using legos.Minifigures.Parts;
using System;

namespace legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var minifigure = new Minifigure();
            minifigure.Head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 4
            };

            var fatHead = new FatHead();

            fatHead.Talk();
            minifigure.Head.Think();
        }
    }
}
