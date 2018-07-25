﻿
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
            public int order = 0;
            public Expression Result = null;
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

        }
    }
}
