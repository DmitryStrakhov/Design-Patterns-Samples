using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Samples {

    public abstract class BooleanExpression {
        public abstract bool Evaluate(EvaluationContext context);
    }

    public sealed class EvaluationContext {
        readonly Dictionary<string, bool> values;

        public EvaluationContext() {
            this.values = new Dictionary<string, bool>();
        }
        public void AddVariable(string name, bool value) {
            values[name] = value;
        }
        public bool GetVariableValue(string name) => values[name];
    }


    public sealed class AndExpression : BooleanExpression {
        readonly BooleanExpression lExp;
        readonly BooleanExpression rExp;

        public AndExpression(BooleanExpression lExp, BooleanExpression rExp) {
            this.lExp = lExp;
            this.rExp = rExp;
        }
        public override bool Evaluate(EvaluationContext context) {
            return lExp.Evaluate(context) && rExp.Evaluate(context);
        }
    }

    public sealed class OrExpression : BooleanExpression {
        readonly BooleanExpression lExp;
        readonly BooleanExpression rExp;

        public OrExpression(BooleanExpression lExp, BooleanExpression rExp) {
            this.lExp = lExp;
            this.rExp = rExp;
        }
        public override bool Evaluate(EvaluationContext context) {
            return lExp.Evaluate(context) || rExp.Evaluate(context);
        }
    }

    public sealed class NotExpression : BooleanExpression {
        readonly BooleanExpression exp;

        public NotExpression(BooleanExpression exp) {
            this.exp = exp;
        }
        public override bool Evaluate(EvaluationContext context) {
            return !exp.Evaluate(context);
        }
    }

    public sealed class VariableExpression : BooleanExpression {
        readonly string name;

        public VariableExpression(string name) {
            this.name = name;
        }
        public override bool Evaluate(EvaluationContext context) {
            return context.GetVariableValue(name);
        }
    }

    public sealed class ConstantExpression : BooleanExpression {
        readonly bool value;

        public ConstantExpression(bool value) {
            this.value = value;
        }
        public override bool Evaluate(EvaluationContext context) => value;
    }
}
