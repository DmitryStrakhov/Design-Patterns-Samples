using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Handler {
        readonly Handler successor;

        public Handler(Handler successor) {
            this.successor = successor;
        }
        public virtual void HandleRequest() {
            successor?.HandleRequest();
        }
    }

    public sealed class ConcreteHandlerA : Handler {
        public ConcreteHandlerA() : this(null) {
        }
        public ConcreteHandlerA(Handler successor)
            : base(successor) {
        }
    }

    public sealed class ConcreteHandlerB : Handler {
        public ConcreteHandlerB() : this(null) {
        }
        public ConcreteHandlerB(Handler successor)
            : base(successor) {
        }
        public override void HandleRequest() {
            // handling code
        }
    }
}
