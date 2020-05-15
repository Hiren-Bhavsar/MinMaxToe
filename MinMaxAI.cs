using System;
using System.Collections.Generic;
using System.Text;

namespace MinMaxToe {
    class MinMaxAI {

        private int testPick;
        public MinMaxAI() {
            testPick = -1;
        }

        public int testMove() {
            testPick++;
            return testPick;
        }

    }
}
