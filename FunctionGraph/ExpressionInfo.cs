
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Prototypist.FunctionGraph
{
    public partial class FlowBuilder
    {
        private class ExpressionInfo
        {
            public readonly Expression backing;
            public readonly Expression[] Inputs;
            public readonly Type[] ParameterTypes;
            public readonly Type ReturnType;
            public int order = 0;
            public Expression Result = null;
            public readonly List<ExpressionInfo> waitsOn = new List<ExpressionInfo>();
            internal readonly bool Packed;

            public ExpressionInfo(WorkItem workItem)
            {
                this.backing = Expression.Constant(workItem.todo) ?? throw new ArgumentNullException(nameof(workItem));
                var funcType = workItem.todo.GetType();
                this.Packed = workItem.unpack;

                ParameterTypes = funcType.Parameters();
                if (funcType.IsFunc())
                {
                    ReturnType = funcType.FuncReturn();
                }
                this.Inputs = new Expression[ParameterTypes.Count()];
            }

        }
    }
}
