#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class MementoTests {
        [TestMethod]
        public void SimpleTest() {
            Originator obj = new Originator();

            IMemento memento = obj.CreateMemento();
            obj.Action();
            obj.SetMemento(memento);
        }
    }
}
#endif