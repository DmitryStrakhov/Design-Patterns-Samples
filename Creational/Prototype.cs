using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class AbstractPrototype {
        public abstract AbstractPrototype Clone();
    }

    public sealed class PrototypeClient {
        readonly AbstractPrototype prototype;

        public PrototypeClient(AbstractPrototype prototype) {
            this.prototype = prototype;
        }
        public AbstractPrototype Start() {
            AbstractPrototype obj = prototype.Clone();
            return obj;
        }
    }


    public sealed class ConcretePrototypeX : AbstractPrototype {
        readonly int value;

        public ConcretePrototypeX(int value) {
            this.value = value;
        }
        public override AbstractPrototype Clone() {
            return new ConcretePrototypeX(Value);
        }
        public int Value { get { return value; } }
    }


    public sealed class ConcretePrototypeY : AbstractPrototype {
        readonly string value;

        public ConcretePrototypeY(string value) {
            this.value = value;
        }
        public override AbstractPrototype Clone() {
            return new ConcretePrototypeY(Value);
        }
        public string Value { get { return value; } }
    }
}
