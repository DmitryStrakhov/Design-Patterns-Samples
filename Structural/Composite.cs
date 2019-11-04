using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Component {
        public virtual void Operation() {
        }

        public virtual void Add(Component component) {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component component) {
            throw new NotImplementedException();
        }
    }


    public sealed class Leaf : Component {
        public override void Operation() {
        }
    }


    public sealed class Composite : Component {
        public override void Operation() {
        }
        public override void Add(Component component) {
            // add child component
        }
        public override void Remove(Component component) {
            // remove child component
        }
    }
}
