#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class DecoratorTests {
        [TestMethod]
        public void SimpleTest() {
            BaseComponent component = new ConcreteComponent();
            DoOperation(new ConcreteDecoratorA(new ConcreteDecoratorB(component)));
        }

        private void DoOperation(BaseComponent component) {
            component.Operation();
        }
    }
}
#endif