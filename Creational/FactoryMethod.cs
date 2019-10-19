using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class AbstractCreator {
        AbstractProduct product;

        public AbstractCreator() {
            this.product = null;
        }

        internal AbstractProduct Product {
            get { return product ?? (product = CreateProduct()); }
        }
        protected abstract AbstractProduct CreateProduct();
    }

    public abstract class AbstractProduct {
    }


    public sealed class ConcreteCreator : AbstractCreator {
        protected override AbstractProduct CreateProduct() {
            return new ConcreteProduct();
        }
    }

    public sealed class ConcreteProduct : AbstractProduct {
    }
}
