#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class ChainOfResponsibilityTests {
        [TestMethod]
        public void SimpleTest() {
            Handler handler = BuildChainOfHandlers();
            handler.HandleRequest();
        }

        private Handler BuildChainOfHandlers() {
            ConcreteHandlerA obj4 = new ConcreteHandlerA();
            ConcreteHandlerB obj3 = new ConcreteHandlerB(obj4);
            ConcreteHandlerA obj2 = new ConcreteHandlerA(obj3);
            return new ConcreteHandlerA(obj2);
        }
    }
}
#endif