
using System;
using Prototypist.FunctionFlow;

namespace Prototypist.FunctionFlow.Strong
{

#region  BaseClass

    public class HolderBase<T1> : HolderBase, IHold<T1>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2> : HolderBase<T1>, IHold<T2>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3> : HolderBase<T1, T2>, IHold<T3>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4> : HolderBase<T1, T2, T3>, IHold<T4>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5> : HolderBase<T1, T2, T3, T4>, IHold<T5>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6> : HolderBase<T1, T2, T3, T4, T5>, IHold<T6>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7> : HolderBase<T1, T2, T3, T4, T5, T6>, IHold<T7>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8> : HolderBase<T1, T2, T3, T4, T5, T6, T7>, IHold<T8>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8>, IHold<T9>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IHold<T10>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IHold<T11>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IHold<T12>
    {
        public HolderBase(HolderBase backing) : base(backing)
        {
        }

        protected HolderBase(FlowBuilder flowBuilder) : base(flowBuilder)
        {
        }
    }
#endregion

#region  Class

    public class Holder<T1> : HolderBase<T1>, IHolder<T1>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1): base(new FlowBuilder()) {
            SetConstant(t1);
        }
    }

    public class Holder<T1, T2> : HolderBase<T1, T2>, IHolder<T1, T2>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
        }
    }

    public class Holder<T1, T2, T3> : HolderBase<T1, T2, T3>, IHolder<T1, T2, T3>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
        }
    }

    public class Holder<T1, T2, T3, T4> : HolderBase<T1, T2, T3, T4>, IHolder<T1, T2, T3, T4>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
        }
    }

    public class Holder<T1, T2, T3, T4, T5> : HolderBase<T1, T2, T3, T4, T5>, IHolder<T1, T2, T3, T4, T5>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6> : HolderBase<T1, T2, T3, T4, T5, T6>, IHolder<T1, T2, T3, T4, T5, T6>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7> : HolderBase<T1, T2, T3, T4, T5, T6, T7>, IHolder<T1, T2, T3, T4, T5, T6, T7>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7): base(new FlowBuilder()) {
            SetConstant(t1);
            SetConstant(t2);
            SetConstant(t3);
            SetConstant(t4);
            SetConstant(t5);
            SetConstant(t6);
            SetConstant(t7);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8): base(new FlowBuilder()) {
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

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9): base(new FlowBuilder()) {
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

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10): base(new FlowBuilder()) {
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

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11): base(new FlowBuilder()) {
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

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public Holder(HolderBase backing): base(backing) {
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12): base(new FlowBuilder()) {
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

    public interface IHolder<T1> : IHack<Holder<T1>, Holder<T1>>
    {
    }

    public interface IHolder<T1, T2> : IHack<Holder<T1, T2>, Holder<T1, T2>>
    {
    }

    public interface IHolder<T1, T2, T3> : IHack<Holder<T1, T2, T3>, Holder<T1, T2, T3>>
    {
    }

    public interface IHolder<T1, T2, T3, T4> : IHack<Holder<T1, T2, T3, T4>, Holder<T1, T2, T3, T4>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5> : IHack<Holder<T1, T2, T3, T4, T5>, Holder<T1, T2, T3, T4, T5>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5, T6> : IHack<Holder<T1, T2, T3, T4, T5, T6>, Holder<T1, T2, T3, T4, T5, T6>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5, T6, T7> : IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, Holder<T1, T2, T3, T4, T5, T6, T7>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5, T6, T7, T8> : IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, Holder<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
    {
    }

    public interface IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
    {
    }
#endregion

}