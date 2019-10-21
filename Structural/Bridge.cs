using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Abstraction {
        readonly AbstractImplementor imp;

        public Abstraction(AbstractImplementor imp) {
            this.imp = imp;
        }
        public int Operation() {
            return imp.OperationImp();
        }
    }

    public sealed class RefinedAbstraction : Abstraction {
        public RefinedAbstraction(AbstractImplementor imp)
            : base(imp) {
        }
    }


    public abstract class AbstractImplementor {
        public abstract int OperationImp();
    }

    public sealed class ConcreteImplementorA : AbstractImplementor {
        public override int OperationImp() { return 1; }
    }

    public sealed class ConcreteImplementorB : AbstractImplementor {
        public override int OperationImp() { return 2; }
    }
}
