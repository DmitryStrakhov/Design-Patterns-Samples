#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class CompositeTests {
        [TestMethod]
        public void SimpleTest() {
            Composite composite = new Composite();
            composite.Add(new Leaf());
            composite.Add(new Leaf());

            Composite childComposite = new Composite();
            composite.Add(childComposite);
            childComposite.Add(new Leaf());
        }
    }
}
#endif