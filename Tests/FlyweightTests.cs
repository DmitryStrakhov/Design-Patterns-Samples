#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class FlyweightTests {
        [TestMethod]
        public void SimpleTest1() {
            DefaultFlyweightFactory factory = new DefaultFlyweightFactory();
            Flyweight obj1 = factory.GetFlyweight('x');
            Flyweight obj2 = factory.GetFlyweight('x');
            Flyweight obj3 = factory.GetFlyweight('x');
            Assert.AreSame(obj1, obj2);
            Assert.AreSame(obj2, obj3);
        }
        [TestMethod]
        public void SimpleTest2() {
            DefaultFlyweightFactory factory = new DefaultFlyweightFactory();
            Flyweight obj1 = factory.GetFlyweight('a');
            Flyweight obj2 = factory.GetFlyweight('b');
            Assert.AreNotSame(obj1, obj2);
        }
    }
}
#endif