#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class VisitorTests {
        [TestMethod]
        public void ConcreteVisitorATest() {
            ConcreteVisitorA visitor = new ConcreteVisitorA();
            Element composition = BuildComposition();
            composition.Accept(visitor);
            Assert.AreEqual(5, visitor.VisitCount);
        }
        [TestMethod]
        public void ConcreteVisitorBTest() {
            ConcreteVisitorB visitor = new ConcreteVisitorB();
            Element composition = BuildComposition();
            composition.Accept(visitor);
            Assert.AreEqual("ElementC;ElementA;ElementC;ElementA;ElementB;", visitor.GetTrace());
        }

        private Element BuildComposition() {
            ConcreteElementA a1 = new ConcreteElementA();
            ConcreteElementA a2 = new ConcreteElementA();
            ConcreteElementB b1 = new ConcreteElementB();
            ConcreteElementC c1 = new ConcreteElementC();
            ConcreteElementC c2 = new ConcreteElementC();

            c1.AddElement(a1).AddElement(c2);
            c2.AddElement(a2).AddElement(b1);
            return c1;
        }
    }
}
#endif