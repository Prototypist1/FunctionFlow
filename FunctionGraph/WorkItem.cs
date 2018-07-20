
using System;

namespace Prototypist.FunctionGraph
{
    
    public partial class FlowBuilder
    {
        private class WorkItem
        {
            public readonly Delegate todo;
            public readonly bool unpack;

            public WorkItem(Delegate todo, bool unpack)
            {
                this.todo = todo ?? throw new ArgumentNullException(nameof(todo));
                this.unpack = unpack;
            }
        }
    }
    
}
