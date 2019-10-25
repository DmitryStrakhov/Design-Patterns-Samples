#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class CommandTests {
        [TestMethod]
        public void SimpleTest() {
            Command command = BuildCommand();
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.Run();
        }

        private Command BuildCommand() {
            return new ConcreteCommand(new Receiver());
        }
    }
}
#endif