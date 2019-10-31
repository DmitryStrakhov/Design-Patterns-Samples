using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Visitor {
        public abstract void VisitConcreteElementA(ConcreteElementA element);
        public abstract void VisitConcreteElementB(ConcreteElementB element);
        public abstract void VisitConcreteElementC(ConcreteElementC element);
    }

    public abstract class Element {
        public abstract void Accept(Visitor visitor);
    }


    #region Concrete Elements

    public sealed class ConcreteElementA : Element {
        public override void Accept(Visitor visitor) {
            visitor.VisitConcreteElementA(this);
        }
    }

    public sealed class ConcreteElementB : Element {
        public override void Accept(Visitor visitor) {
            visitor.VisitConcreteElementB(this);
        }
    }

    public sealed class ConcreteElementC : Element {
        readonly List<Element> childList;

        public ConcreteElementC() {
            this.childList = new List<Element>();
        }
        public ConcreteElementC AddElement(Element element) {
            childList.Add(element);
            return this;
        }
        public override void Accept(Visitor visitor) {
            visitor.VisitConcreteElementC(this);
            childList.ForEach(x => x.Accept(visitor));
        }
    }

    #endregion

    #region Concrete Visitors

    public sealed class ConcreteVisitorA : Visitor {
        int visitCount;

        public ConcreteVisitorA() {
            this.visitCount = 0;
        }
        public override void VisitConcreteElementA(ConcreteElementA element) => visitCount++;
        public override void VisitConcreteElementB(ConcreteElementB element) => visitCount++;
        public override void VisitConcreteElementC(ConcreteElementC element) => visitCount++;
        public int VisitCount { get { return visitCount; } }
    }

    public sealed class ConcreteVisitorB : Visitor {
        readonly StringBuilder stringBuilder;

        public ConcreteVisitorB() {
            this.stringBuilder = new StringBuilder();
        }

        public override void VisitConcreteElementA(ConcreteElementA element) {
            stringBuilder.Append("ElementA;");
        }
        public override void VisitConcreteElementB(ConcreteElementB element) {
            stringBuilder.Append("ElementB;");
        }
        public override void VisitConcreteElementC(ConcreteElementC element) {
            stringBuilder.Append("ElementC;");
        }
        public string GetTrace() { return stringBuilder.ToString(); }
    }

    #endregion
}
