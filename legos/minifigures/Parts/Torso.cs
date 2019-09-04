using System;
using System.Collections.Generic;
using System.Text;

namespace legos.minifigures.Parts
{
    abstract class Torso
    {
        public HandType HandType { get; set; }
        public abstract bool ChestHair { get;  }
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }
    }
}
