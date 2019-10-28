#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class MediatorTests {
        [TestMethod]
        public void SimpleTest() {
            ConcreteMediator mediator = new ConcreteMediator();
            mediator.CreateColleagues();
            mediator.ColleagueA.Action();
            mediator.ColleagueB.Action();
        }
    }
}
#endif