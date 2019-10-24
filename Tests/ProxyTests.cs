#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class ProxyTests {
        [TestMethod]
        public void SimpleTest() {
            Data proxyData = new Data();
            Proxy proxy = new Proxy(proxyData);

            Data resultData = DoOperationA(proxy);
            Assert.AreEqual(proxyData, resultData);
            DoOperationB(proxy);
            resultData = DoOperationA(proxy);
            Assert.AreNotEqual(proxyData, resultData);
        }

        private Data DoOperationA(Subject subject) {
            return subject.OperationA();
        }
        private void DoOperationB(Subject subject) {
            subject.OperationB();
        }
    }
}
#endif