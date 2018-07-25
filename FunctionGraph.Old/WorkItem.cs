
using System;

namespace Prototypist.FunctionGraph
{
    
    public partial class FlowBuilder
    {
        private class WorkItem
        {
            public readonly Delegate todo;
            public readonly Type[] returnTypes;

            public WorkItem(Delegate todo, Type[] types)
            {
                this.todo = todo ?? throw new ArgumentNullException(nameof(todo));
                this.returnTypes = types;
            }
        }
    }
    
}
