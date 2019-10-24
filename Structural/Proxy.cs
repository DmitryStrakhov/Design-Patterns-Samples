using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class Subject {
        public abstract Data OperationA();
        public abstract void OperationB();
    }

    public sealed class RealSubject : Subject {
        public override Data OperationA() {
            return new Data();
        }
        public override void OperationB() {
        }
    }

    public sealed class Proxy : Subject {
        readonly Data data;
        RealSubject realSubject;

        public Proxy(Data data) {
            this.data = data;
            this.realSubject = null;
        }

        public override Data OperationA() {
            if(realSubject != null)
                return realSubject.OperationA();
            return data;
        }
        public override void OperationB() {
            if(realSubject == null)
                realSubject = new RealSubject();
            realSubject.OperationB();
        }
    }


    public sealed class Data {
    }
}
