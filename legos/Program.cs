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
                EyeColor = "Green",
                HairColor = "Aqua",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 8
            };

            var Torso = new torso();

            var fatHead = new FatHead();

            fatHead.Talk();
            minifigure.Head.Think();
        }
    }

    internal class torso
    {
        public torso()
        {
        }
    }
}
