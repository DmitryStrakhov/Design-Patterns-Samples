#if DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design_Patterns_Samples.Tests {
    [TestClass]
    public sealed class InterpreterTests {
        [TestMethod]
        public void Test1() {
            EvaluationContext context = new EvaluationContext();
            context.AddVariable("X", true);
            context.AddVariable("Y", false);

            BooleanExpression expression = BuildExpression();
            Assert.IsTrue(expression.Evaluate(context));
        }
        [TestMethod]
        public void Test2() {
            EvaluationContext context = new EvaluationContext();
            context.AddVariable("X", false);
            context.AddVariable("Y", false);

            BooleanExpression expression = BuildExpression();
            Assert.IsFalse(expression.Evaluate(context));
        }

        private BooleanExpression BuildExpression() {
            VariableExpression xExp = new VariableExpression("X");
            VariableExpression yExp = new VariableExpression("Y");

            return new OrExpression(
                new AndExpression(new ConstantExpression(true), xExp),
                new AndExpression(yExp, new NotExpression(xExp))
            );
        }
    }
}
#endif