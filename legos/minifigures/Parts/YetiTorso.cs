using System;
using System.Collections.Generic;
using System.Text;

namespace legos.minifigures.Parts
{
    class YetiTorso : Torso
    {
     
        public override bool ChestHair => true;


        public YetiTorso()
        {
            HandType = HandType.None;
            Shirt = "None";
            NumberOfArms = 2;
           
        }

        public void Flex()
        {
            Console.WriteLine("The Yeti torso flexes menacingly with no hands");
        }

        public void Fight()
        {
            Console.WriteLine("The yeti smacks you with his nubs...");
        }
    }
}
