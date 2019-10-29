using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {
    public sealed class Singleton {
        private Singleton() {
        }
        public void Action() {
        }
        public static readonly Singleton Instance = new Singleton();
    }
}
