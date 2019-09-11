using System;
using System.Collections.Generic;
using System.Text;

namespace legos.minifigures
{
    interface ITalker
    {
        void Talk();
        

    }

    interface IShouter
    {
        void Shout(int numberOfDecibels);
    }
}
