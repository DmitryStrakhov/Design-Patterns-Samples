#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class StrategyTests {
        [TestMethod]
        public void ConcreteStrategyATest() {
            DoTest(new ConcreteStrategyA());
        }
        [TestMethod]
        public void ConcreteStrategyBTest() {
            DoTest(new ConcreteStrategyB());
        }
        [TestMethod]
        public void ConcreteStrategyCTest() {
            DoTest(new ConcreteStrategyC());
        }

        private void DoTest(StrategyBase strategy) {
            ContextObj context = new ContextObj(strategy);
            context.Request();
        }
    }
}
#endif