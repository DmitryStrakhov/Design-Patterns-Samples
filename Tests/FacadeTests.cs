#if DEBUG

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class FacadeTests {
        [TestMethod]
        public void SimpleTest() {
            Facade facade = new Facade();

            MemoryStream iStream = new MemoryStream();
            MemoryStream oStream = new MemoryStream();

            try {
                facade.Compile(iStream, oStream);
            }
            finally {
                iStream?.Dispose();
                oStream?.Dispose();
            }
        }
    }
}
#endif