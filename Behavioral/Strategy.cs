using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public sealed class ContextObj {
        readonly StrategyBase strategy;

        public ContextObj(StrategyBase strategy) {
            this.strategy = strategy;
        }
        public void Request() => strategy.Action();
    }

    public abstract class StrategyBase {
        public abstract void Action();
    }


    public sealed class ConcreteStrategyA : StrategyBase {
        public override void Action() {
            // do action
        }
    }

    public sealed class ConcreteStrategyB : StrategyBase {
        public override void Action() {
            // do action
        }
    }

    public sealed class ConcreteStrategyC : StrategyBase {
        public override void Action() {
            // do action
        }
    }
}
