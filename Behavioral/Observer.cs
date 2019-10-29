using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class SubjectBase {
        readonly List<ObserverBase> observerList;

        public SubjectBase() {
            this.observerList = new List<ObserverBase>();
        }

        public void Attach(ObserverBase observer) {
            observerList.Add(observer);
        }
        public void Detach(ObserverBase observer) {
            observerList.Remove(observer);
        }
        protected void OnChanged() {
            observerList.ForEach(x => x.Update(this));
        }
    }

    public abstract class ObserverBase {
        public abstract void Update(SubjectBase subject);
    }


    public sealed class ConcreteSubject : SubjectBase {
        public ConcreteSubject() {
        }
        public void Action() {
            // some action
            OnChanged();
        }
        public int GetValue() { return 1; }
    }

    public sealed class ConcreteObserver : ObserverBase {
        readonly ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject) {
            this.subject = subject;
            subject.Attach(this);
        }
        public override void Update(SubjectBase source) {
            if(!ReferenceEquals(subject, source)) return;
            int value = subject.GetValue();
        }
    }
}
