#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class SingletonTests {
        [TestMethod]
        public void SimpleTest() {
            Singleton obj1 = Singleton.Instance;
            Singleton obj2 = Singleton.Instance;
            Assert.AreSame(obj1, obj2);
            Singleton.Instance.Start();
        }
    }
}
#endif