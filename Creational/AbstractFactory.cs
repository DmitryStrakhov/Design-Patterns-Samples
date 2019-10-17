using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class AbstractFactory {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public sealed class ConcreteFactory1 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB() {
            return new ProductB1();
        }
    }

    public sealed class ConcreteFactory2 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB() {
            return new ProductB2();
        }
    }


    #region Abstract Products

    public abstract class AbstractProductA {
    }

    public abstract class AbstractProductB {
    }

    #endregion


    #region Concrete Products

    public sealed class ProductA1 : AbstractProductA {
    }

    public sealed class ProductA2 : AbstractProductA {
    }

    public sealed class ProductB1 : AbstractProductB {
    }

    public sealed class ProductB2 : AbstractProductB {
    }

    #endregion
}
