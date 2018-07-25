
using System;
using Prototypist.FunctionGraph;

namespace Prototypist.FunctionGraph.Strong
{

    public class Holder : HolderBase, IHolder
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing)
        {
            this.FlowBuilder = backing ?? throw new ArgumentNullException(nameof(backing));
        }
        public Holder()
        {
            this.FlowBuilder = new FlowBuilder();
        }

    }

    public interface IHolder : IHack<Holder, Holder>
    {
    }

    public interface IHack<T1, T2>
    {
        FlowBuilder FlowBuilder { get; }
    }
    
    public class HolderBase: IHold
    {

    }


    public interface IHold
    {

    }
}
