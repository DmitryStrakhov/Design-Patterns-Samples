using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Flyweight {
        public abstract void Operation(ExtrinsicState extrinsicState);
    }

    public sealed class SharedConcreteFlyweight : Flyweight {
        readonly IntrinsicState intrinsicState;

        public SharedConcreteFlyweight() {
            this.intrinsicState = new IntrinsicState();
        }
        public override void Operation(ExtrinsicState extrinsicState) {
        }
    }

    public sealed class NonsharedConcreteFlyweight : Flyweight {
        readonly FullState fullState;

        public NonsharedConcreteFlyweight() {
            this.fullState = new FullState();
        }
        public override void Operation(ExtrinsicState extrinsicState) {
        }
    }


    #region Factory

    public abstract class FlyweightFactory {
        public abstract Flyweight GetFlyweight(char code);
    }

    public sealed class DefaultFlyweightFactory : FlyweightFactory {
        readonly FlyweightCache cache;

        public DefaultFlyweightFactory() {
            this.cache = new FlyweightCache();
        }
        public override Flyweight GetFlyweight(char code) {
            return cache.GetOrAdd(code);
        }
    }

    sealed class FlyweightCache : Dictionary<char, Flyweight> {
        public Flyweight GetOrAdd(char code) {
            Flyweight flyweight;

            if(!TryGetValue(code, out flyweight)) {
                this[code] = flyweight = new SharedConcreteFlyweight();
            }
            return flyweight;
        }
    }

    #endregion


    #region States

    public sealed class IntrinsicState {
    }

    public sealed class ExtrinsicState {
    }

    public sealed class FullState {
    }

    #endregion
}
