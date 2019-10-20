using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Target {
        public abstract void Operation();
    }

    public sealed class Adapter : Target {
        readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee) {
            this.adaptee = adaptee;
        }
        public override void Operation() {
            adaptee.SpecificOperation();
        }
    }


    public sealed class Adaptee {
        public Adaptee() {
        }
        public void SpecificOperation() {
        }
    }
}
