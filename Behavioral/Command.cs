using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public sealed class Invoker {
        Command command;

        public Invoker() {
            this.command = null;
        }
        public void SetCommand(Command command) {
            this.command = command;
        }
        public void Run() {
            command?.Execute();
        }
    }


    public abstract class Command {
        public abstract void Execute();
    }

    public sealed class ConcreteCommand : Command {
        readonly Receiver receiver;

        public ConcreteCommand(Receiver receiver) {
            this.receiver = receiver;
        }
        public override void Execute() {
            receiver.Action1();
            receiver.Action2();
        }
    }


    public sealed class Receiver {
        public void Action1() { }
        public void Action2() { }
    }
}
