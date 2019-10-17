#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class BuilderTests {
        [TestMethod]
        public void ProductABuilderTest() {
            ProductABuilder builder = new ProductABuilder();
            new Director(builder).Start();
            ProductA product = builder.GetProduct();
            AssertProduct(product, typeof(ProductA));
        }
        [TestMethod]
        public void ProductBBuilderTest() {
            ProductBBuilder builder = new ProductBBuilder();
            new Director(builder).Start();
            ProductB product = builder.GetProduct();
            AssertProduct(product, typeof(ProductB));
        }

        private void AssertProduct(object product, Type expectedType) {
            Assert.IsNotNull(product);
            Assert.IsInstanceOfType(product, expectedType);
        }
    }
}
#endif