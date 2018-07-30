
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Prototypist.FunctionFlow
{
    public partial class FlowBuilder
    {
        private class ExpressionInfo
        {
            public readonly Expression backing;
            public readonly Expression[] Inputs;
            public Expression Result = null;
            public ParameterExpression task = null;
            public readonly List<ExpressionInfo> waitsOn = new List<ExpressionInfo>();
            public readonly Type[] returnTypes;
            public readonly Type[] ParameterTypes;

            public ExpressionInfo(WorkItem workItem)
            {
                this.backing = Expression.Constant(workItem.todo) ?? throw new ArgumentNullException(nameof(workItem));
                this.returnTypes = workItem.returnTypes;
                this.ParameterTypes = workItem.todo.GetType().Parameters();
                this.Inputs = new Expression[ParameterTypes.Count()];
            }


            /// <param name="expressionInfo">returnTypes must not be null</param>
            internal bool SameOutput(ExpressionInfo expressionInfo) =>
                returnTypes?.SequenceEqual(expressionInfo.returnTypes) ?? false;
            internal bool WillWaitFor(ExpressionInfo sourceExpressionInfo) {
                if (sourceExpressionInfo == this) {
                    return true;
                }
                return waitsOn?.Any(x => x.WillWaitFor(sourceExpressionInfo)) ?? false;
            }
        }
    }
}
