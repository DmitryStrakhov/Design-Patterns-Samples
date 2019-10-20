#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class AdapterTests {
        [TestMethod]
        public void SimpleTest() {
            Adapter adapter = new Adapter(new Adaptee());
            TestTarget(adapter);
        }

        private void TestTarget(Target target) {
            target.Operation();
        }
    }
}
#endif