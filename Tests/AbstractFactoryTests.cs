#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class AbstractFactoryTests {
        [TestMethod]
        public void ConcreteFactory1Test() {
            AbstractFactory factory = new ConcreteFactory1();
            Assert.IsInstanceOfType(factory.CreateProductA(), typeof(ProductA1));
            Assert.IsInstanceOfType(factory.CreateProductB(), typeof(ProductB1));
        }
        [TestMethod]
        public void ConcreteFactory2Test() {
            AbstractFactory factory = new ConcreteFactory2();
            Assert.IsInstanceOfType(factory.CreateProductA(), typeof(ProductA2));
            Assert.IsInstanceOfType(factory.CreateProductB(), typeof(ProductB2));
        }
    }
}
#endif