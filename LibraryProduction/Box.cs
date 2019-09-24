using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProduction
{
    class Box
    {
        private static Random Alea;
        private bool StateBox;

        public Box()
        {
            Alea = new Random();
            StateBox = (Alea.NextDouble() >= 0.01);
        }
    }
}
