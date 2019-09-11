using legos.minifigures;
using System;
using System.Collections.Generic;
using System.Text;

namespace legos.Minifigures.Parts
{
    class YodaHead : Head, ITalker
    {
        public bool HasEars { get; private set; }
        public YodaHead()
        {

            Size = HeadSize.Small;
            HasEars = true;
        }

        public override void Talk()
        {
            Console.WriteLine("Talking head I am.");
        }

        public void Battle()
        {
            HasEars = false;
        }

        public override void Think()
        {
            throw new NotImplementedException();
        }
    }
}
