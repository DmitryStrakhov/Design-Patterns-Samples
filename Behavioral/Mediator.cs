using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Mediator {
        public abstract void OnColleagueChanged(Colleague colleague);
        public abstract void CreateColleagues();
    }

    public abstract class Colleague {
        readonly Mediator mediator;

        public Colleague(Mediator mediator) {
            this.mediator = mediator;
        }
        protected void OnChanged() {
            mediator.OnColleagueChanged(this);
        }
    }


    public sealed class ConcreteMediator : Mediator {
        ConcreteColleagueA colleagueA;
        ConcreteColleagueB colleagueB;

        public ConcreteMediator() {
            this.colleagueA = null;
            this.colleagueB = null;
        }
        public override void CreateColleagues() {
            this.colleagueA = new ConcreteColleagueA(this);
            this.colleagueB = new ConcreteColleagueB(this);
        }
        public override void OnColleagueChanged(Colleague colleague) {
            if(ReferenceEquals(colleague, colleagueA)) {
                int value = colleagueA.GetValue();
                colleagueB.SetValue(value);
            }
            else if(ReferenceEquals(colleague, colleagueB)) {
                int value = colleagueB.GetValue();
                colleagueA.SetValue(value);
            }
        }
        internal ConcreteColleagueA ColleagueA { get { return colleagueA; } }
        internal ConcreteColleagueB ColleagueB { get { return colleagueB; } }
    }

    public sealed class ConcreteColleagueA : Colleague {
        public ConcreteColleagueA(Mediator mediator)
            : base(mediator) {
        }
        public int GetValue() { return 0; }
        public void SetValue(int value) { }
        public void Action() { OnChanged(); }
    }

    public sealed class ConcreteColleagueB : Colleague {
        public ConcreteColleagueB(Mediator mediator)
            : base(mediator) {
        }
        public int GetValue() { return 1; }
        public void SetValue(int value) { }
        public void Action() { OnChanged(); }
    }
}
