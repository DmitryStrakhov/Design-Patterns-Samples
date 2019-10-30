#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class TemplateMethodTests {
        [TestMethod]
        public void SimpleTest() {
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.TemplateMethod();
        }
    }
}
#endif