#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class BridgeTests {
        [TestMethod]
        public void RefinedAbstractionATest() {
            DoTest(new ConcreteImplementorA(), 1);
        }
        [TestMethod]
        public void RefinedAbstractionBTest() {
            DoTest(new ConcreteImplementorB(), 2);
        }

        private void DoTest(AbstractImplementor imp, int expectedResult) {
            RefinedAbstraction obj = new RefinedAbstraction(imp);
            Assert.AreEqual(expectedResult, obj.Operation());
        }
    }
}
#endif