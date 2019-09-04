using System;
using System.Collections.Generic;
using System.Text;

namespace legos.minifigures.Parts
{
    class PirateTorso
    {
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }
        public HandType HandType { get; set; }
        public bool ChestHair => true;

        public PirateTorso(HandType handType)
        {
            HandType = handType;
            Shirt = "Froofy with ruffles";
        }

        public void Flex()
        {
            Console.WriteLine("The pirate torso flexed swashbuckingly");
        }

        public void Fight()
        {
            Console.WriteLine("Waves a sword around");
        }

    }

    enum HandType
    {
        Regular,
        Hook,
        None
    }
}
