using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6 {
    class Matematyka {
        private static double pi = 3.14;

        public static double PoleKola(int r) 
        {
            return pi * r * r;
        }
        public static double ObwodKola(int r) {
            return pi * 2 * r;
        }
    }
}
