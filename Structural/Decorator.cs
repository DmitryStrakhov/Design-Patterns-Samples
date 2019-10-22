using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class BaseComponent {
        public abstract void Operation();
    }

    public sealed class ConcreteComponent : BaseComponent {
        public override void Operation() {
        }
    }


    public abstract class Decorator : BaseComponent {
        readonly BaseComponent component;

        public Decorator(BaseComponent component) {
            this.component = component;
        }
        public override void Operation() {
            component.Operation();
        }
    }

    public sealed class ConcreteDecoratorA : Decorator {
        public ConcreteDecoratorA(BaseComponent component)
            : base(component) {
        }
        public override void Operation() {
            base.Operation();
        }
    }

    public sealed class ConcreteDecoratorB : Decorator {
        public ConcreteDecoratorB(BaseComponent component)
            : base(component) {
        }
        public override void Operation() {
            base.Operation();
        }
    }
}
