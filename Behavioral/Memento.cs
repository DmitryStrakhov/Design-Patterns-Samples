using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public interface IMemento {
    }


    public sealed class Originator {
        InternalState state;

        public Originator() {
            this.state = new InternalState();
        }
        public void Action() {
            // change state somehow
        }
        public IMemento CreateMemento() {
            return new Memento(state);
        }
        public void SetMemento(IMemento memento) {
            state = ((Memento)memento).GetState();
        }

        #region Memento

        private sealed class Memento : IMemento {
            readonly InternalState state;

            public Memento(InternalState state) {
                this.state = state;
            }
            public InternalState GetState() => state;
        }

        #endregion
    }


    sealed class InternalState {
    }
}
