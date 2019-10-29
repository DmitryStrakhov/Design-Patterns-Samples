#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class ObserverTests {
        [TestMethod]
        public void SimpleTest() {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver(subject);
            ConcreteObserver observer2 = new ConcreteObserver(subject);
            ConcreteObserver observer3 = new ConcreteObserver(subject);
            subject.Action();
        }
    }
}
#endif