#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BF = System.Reflection.BindingFlags;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class PrototypeTests {
        [TestMethod]
        public void ConcretePrototypeXTest() {
            TestPrototype(new ConcretePrototypeX(1), 1);
        }
        [TestMethod]
        public void ConcretePrototypeYTest() {
            TestPrototype(new ConcretePrototypeY("Test"), "Test");
        }

        private void TestPrototype(AbstractPrototype prototype, object expectedValue) {
            PrototypeClient client = new PrototypeClient(prototype);
            AbstractPrototype clone = client.Action();
            Assert.IsNotNull(clone);
            Assert.AreNotSame(clone, prototype);

            Assert.AreEqual(clone.GetType(), prototype.GetType());
            PropertyInfo targetProperty = clone.GetType().GetProperty("Value", BF.Instance | BF.Public);
            Assert.AreEqual(expectedValue, targetProperty.GetValue(clone));
        }
    }
}
#endif