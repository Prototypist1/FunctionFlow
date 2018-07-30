
using System;
using Prototypist.FunctionFlow;

namespace Prototypist.FunctionFlow.Strong
{

#region  BaseClass

    public class StrongFlowBase<T1> : StrongFlowBase, IHold<T1>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2> : StrongFlowBase<T1>, IHold<T2>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3> : StrongFlowBase<T1, T2>, IHold<T3>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4> : StrongFlowBase<T1, T2, T3>, IHold<T4>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5> : StrongFlowBase<T1, T2, T3, T4>, IHold<T5>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5, T6> : StrongFlowBase<T1, T2, T3, T4, T5>, IHold<T6>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5, T6, T7> : StrongFlowBase<T1, T2, T3, T4, T5, T6>, IHold<T7>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7>, IHold<T8>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8>, IHold<T9>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IHold<T10>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IHold<T11>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IHold<T12>
    {
        public StrongFlowBase(StrongFlowBase backing) : base(backing)
        {
        }

        protected StrongFlowBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }
#endregion

#region  Class

    public class StrongFlow<T1> : StrongFlowBase<T1>, IStrongFlow<T1>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1): base(new FlowBuilder()) {
            SetConstant(t1);
        }
    }

    public class StrongFlow<T1, T2> : StrongFlowBase<T1, T2>, IStrongFlow<T1, T2>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
        }
    }

    public class StrongFlow<T1, T2, T3> : StrongFlowBase<T1, T2, T3>, IStrongFlow<T1, T2, T3>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
        }
    }

    public class StrongFlow<T1, T2, T3, T4> : StrongFlowBase<T1, T2, T3, T4>, IStrongFlow<T1, T2, T3, T4>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5> : StrongFlowBase<T1, T2, T3, T4, T5>, IStrongFlow<T1, T2, T3, T4, T5>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5, T6> : StrongFlowBase<T1, T2, T3, T4, T5, T6>, IStrongFlow<T1, T2, T3, T4, T5, T6>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5, T6, T7> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7>, IStrongFlow<T1, T2, T3, T4, T5, T6, T7>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
            SetConstant(t7);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8>, IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
            SetConstant(t7);
            SetConstant(t8);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
            SetConstant(t7);
            SetConstant(t8);
            SetConstant(t9);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
            SetConstant(t7);
            SetConstant(t8);
            SetConstant(t9);
            SetConstant(t10);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
            SetConstant(t7);
            SetConstant(t8);
            SetConstant(t9);
            SetConstant(t10);
            SetConstant(t11);
        }
    }

    public class StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : StrongFlowBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public StrongFlow(StrongFlowBase backing): base(backing) {
        }
        public StrongFlow(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
            SetConstant(t7);
            SetConstant(t8);
            SetConstant(t9);
            SetConstant(t10);
            SetConstant(t11);
            SetConstant(t12);
        }
    }
#endregion

#region Interface

    public interface IStrongFlow<T1> : IHack<StrongFlow<T1>, StrongFlow<T1>>
    {
    }

    public interface IStrongFlow<T1, T2> : IHack<StrongFlow<T1, T2>, StrongFlow<T1, T2>>
    {
    }

    public interface IStrongFlow<T1, T2, T3> : IHack<StrongFlow<T1, T2, T3>, StrongFlow<T1, T2, T3>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4> : IHack<StrongFlow<T1, T2, T3, T4>, StrongFlow<T1, T2, T3, T4>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5> : IHack<StrongFlow<T1, T2, T3, T4, T5>, StrongFlow<T1, T2, T3, T4, T5>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5, T6> : IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, StrongFlow<T1, T2, T3, T4, T5, T6>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5, T6, T7> : IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, StrongFlow<T1, T2, T3, T4, T5, T6, T7>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> : IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
    {
    }

    public interface IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
    {
    }
#endregion

}