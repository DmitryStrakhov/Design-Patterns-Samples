using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public sealed class Director {
        readonly ProductBuilderBase builder;

        public Director(ProductBuilderBase builder) {
            this.builder = builder;
        }
        public void Action() {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }
    }


    public class ProductBuilderBase {
        public virtual void BuildPart1() { }
        public virtual void BuildPart2() { }
        public virtual void BuildPart3() { }
    }

    public sealed class ProductABuilder : ProductBuilderBase {
        ProductA product = null;

        public override void BuildPart1() {
            product = new ProductA();
        }
        public ProductA GetProduct() { return product; }
    }

    public sealed class ProductBBuilder : ProductBuilderBase {
        ProductB product = null;

        public override void BuildPart2() {
            product = new ProductB();
        }
        public ProductB GetProduct() { return product; }
    }


    #region Builder Products

    public sealed class ProductA {
    }

    public sealed class ProductB {
    }

    #endregion
}
