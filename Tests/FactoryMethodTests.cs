#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class FactoryMethodTests {
        [TestMethod]
        public void ConcreteCreatorTest() {
            ConcreteCreator creator = new ConcreteCreator();
            Assert.IsNotNull(creator.Product);
            Assert.IsInstanceOfType(creator.Product, typeof(ConcreteProduct));
        }
    }
}
#endif