
using System;
using Prototypist.FunctionFlow;

namespace Prototypist.FunctionFlow.Strong
{

    public class Holder : HolderBase, IHolder
    {
        public Holder(HolderBase backing):base(backing)
        {
        }
        public Holder() : base(new FlowBuilder())
        {
        }
    }

    public interface IHack<T1, T2>: IHold
    {
    }

    public interface IHolder : IHack<Holder, Holder>{}

    public abstract class HolderBase : IHold
    {
        public HolderBase(HolderBase backing)
        {
            this.FlowBuilder = backing?.FlowBuilder ?? throw new ArgumentNullException(nameof(backing));
        }

        public HolderBase(FlowBuilder flowBuilder)
        {
            this.FlowBuilder = flowBuilder ?? throw new ArgumentNullException(nameof(flowBuilder));
        }

        protected FlowBuilder FlowBuilder { get; }

        public T Run<T>() {
            return FlowBuilder.Run<T>();
        }

        public (T1,T2) Run<T1, T2>()
        {
            return FlowBuilder.Run<T1, T2>();
        }

        public (T1, T2, T3) Run<T1, T2, T3>()
        {
            return FlowBuilder.Run<T1, T2, T3>();
        }
        public (T1, T2, T3, T4) Run<T1, T2, T3, T4>()
        {
            return FlowBuilder.Run<T1, T2, T3, T4>();
        }
        public (T1, T2, T3, T4, T5) Run<T1, T2, T3, T4, T5>()
        {
            return FlowBuilder.Run<T1, T2, T3, T4, T5>();
        }
        public (T1, T2, T3, T4, T5, T6) Run<T1, T2, T3, T4, T5, T6>()
        {
            return FlowBuilder.Run<T1, T2, T3, T4, T5, T6>();
        }
        public (T1, T2, T3, T4, T5, T6, T7) Run<T1, T2, T3, T4, T5, T6, T7>()
        {
            return FlowBuilder.Run<T1, T2, T3, T4, T5, T6, T7>();
        }

        public void AddStep(Delegate @delegate) {
            FlowBuilder.AddStep(@delegate);
        }

        public void AddStepPacked<T1, T2>(Delegate @delegate)
        {
            FlowBuilder.AddStepPacked<T1, T2>(@delegate);
        }
        public void AddStepPacked<T1, T2, T3>(Delegate @delegate)
        {
            FlowBuilder.AddStepPacked<T1, T2, T3>(@delegate);
        }
        public void AddStepPacked<T1, T2, T3, T4>(Delegate @delegate)
        {
            FlowBuilder.AddStepPacked<T1, T2, T3, T4>(@delegate);
        }
        public void AddStepPacked<T1, T2, T3, T4, T5>(Delegate @delegate)
        {
            FlowBuilder.AddStepPacked<T1, T2, T3, T4, T5>(@delegate);
        }
        public void AddStepPacked<T1, T2, T3, T4, T5, T6>(Delegate @delegate)
        {
            FlowBuilder.AddStepPacked<T1, T2, T3, T4, T5, T6>(@delegate);
        }
        public void AddStepPacked<T1, T2, T3, T4, T5, T6, T7>(Delegate @delegate)
        {
            FlowBuilder.AddStepPacked<T1, T2, T3, T4, T5, T6, T7>(@delegate);
        }
        public void SetConstant<T>(T t)
        {
            FlowBuilder.SetConstant<T>(t);
        }
    }

    public interface IHold {
        T Run<T>();
        (T1, T2) Run<T1, T2>();
        (T1, T2, T3) Run<T1, T2, T3>();
        (T1, T2, T3, T4) Run<T1, T2, T3, T4>();
        (T1, T2, T3, T4, T5) Run<T1, T2, T3, T4, T5>();
        (T1, T2, T3, T4, T5, T6) Run<T1, T2, T3, T4, T5, T6>();
        (T1, T2, T3, T4, T5, T6, T7) Run<T1, T2, T3, T4, T5, T6, T7>();

        void AddStep(Delegate @delegate);

        void AddStepPacked<T1, T2>(Delegate @delegate);
        void AddStepPacked<T1, T2, T3>(Delegate @delegate);
        void AddStepPacked<T1, T2, T3, T4>(Delegate @delegate);
        void AddStepPacked<T1, T2, T3, T4, T5>(Delegate @delegate);
        void AddStepPacked<T1, T2, T3, T4, T5, T6>(Delegate @delegate);
        void AddStepPacked<T1, T2, T3, T4, T5, T6, T7>(Delegate @delegate);
    }
}
