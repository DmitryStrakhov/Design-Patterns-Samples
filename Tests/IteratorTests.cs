#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class IteratorTests {
        [TestMethod]
        public void SimpleTest() {
            ConcreteCollection<int> collection = new ConcreteCollection<int>();
            collection.AddValue(1);
            collection.AddValue(2);
            collection.AddValue(3);
            collection.AddValue(40);
            collection.AddValue(50);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 40, 50 }, collection.ToList());
        }
    }
}
#endif