using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class AbstractClass {
        public void TemplateMethod() {
            int value = GetValue();
            PrimitiveOperation(value);
            SetValue(value);
            HookOperation(value);
        }

        #region Concrete Operations

        private int GetValue() {
            return 0;
        }
        private void SetValue(int value) {
            // do something
        }

        #endregion

        #region Hooks

        protected virtual void HookOperation(int value) {
        }

        #endregion

        protected abstract void PrimitiveOperation(int value);
    }

    public sealed class ConcreteClass : AbstractClass {
        protected override void PrimitiveOperation(int value) {
            // do something
        }
        protected override void HookOperation(int value) {
            // hook here
        }
    }
}
