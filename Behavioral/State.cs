using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public sealed class Context {
        StateBase currentState;

        public Context() {
            this.currentState = new State1();
        }
        public void Action() {
            currentState.Action(this);
        }
        private void ChangeState(StateBase state) {
            this.currentState = state;
        }

        #region Context States

        abstract class StateBase {
            public abstract void Action(Context context);
        }

        sealed class State1 : StateBase {
            public override void Action(Context context) {
                // do action
                context.ChangeState(new State2());
            }
        }

        sealed class State2 : StateBase {
            public override void Action(Context context) {
                // do action
                context.ChangeState(new State3());
            }
        }

        sealed class State3 : StateBase {
            public override void Action(Context context) {
                // do action
                context.ChangeState(new State1());
            }
        }

        #endregion
    }
}
