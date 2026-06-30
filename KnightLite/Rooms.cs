using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KnightLite
{
    public abstract class Rooms()
    {
        private bool _hasEntered = false;
        public Rooms(bool hasEntered)
        {
            _hasEntered = hasEntered;  
        }

        private bool _hasSpawnedBefore = false;

        public void Tavern()
        {
            if(_hasSpawnedBefore == false)
            {
                Console.WriteLine("");
            }
            _hasSpawnedBefore = true;
        }
    }
}
