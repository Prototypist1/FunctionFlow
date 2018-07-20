
using System;

namespace Prototypist.FunctionGraph.Strong
{

    public class HolderBase<T1> : HolderBase, IHold<T1>
    {
    }

    public class HolderBase<T1, T2> : HolderBase<T1>, IHold<T2>
    {
    }

    public class HolderBase<T1, T2, T3> : HolderBase<T1, T2>, IHold<T3>
    {
    }

    public class HolderBase<T1, T2, T3, T4> : HolderBase<T1, T2, T3>, IHold<T4>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5> : HolderBase<T1, T2, T3, T4>, IHold<T5>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6> : HolderBase<T1, T2, T3, T4, T5>, IHold<T6>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7> : HolderBase<T1, T2, T3, T4, T5, T6>, IHold<T7>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8> : HolderBase<T1, T2, T3, T4, T5, T6, T7>, IHold<T8>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8>, IHold<T9>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IHold<T10>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IHold<T11>
    {
    }

    public class HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IHold<T12>
    {
    }

    public class Holder<T1> : HolderBase<T1>, IHolder<T1>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
        }
    }

    public class Holder<T1, T2> : HolderBase<T1, T2>, IHolder<T1, T2>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
        }
    }

    public class Holder<T1, T2, T3> : HolderBase<T1, T2, T3>, IHolder<T1, T2, T3>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
        }
    }

    public class Holder<T1, T2, T3, T4> : HolderBase<T1, T2, T3, T4>, IHolder<T1, T2, T3, T4>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
        }
    }

    public class Holder<T1, T2, T3, T4, T5> : HolderBase<T1, T2, T3, T4, T5>, IHolder<T1, T2, T3, T4, T5>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6> : HolderBase<T1, T2, T3, T4, T5, T6>, IHolder<T1, T2, T3, T4, T5, T6>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
            FlowBuilder.SetParameter(t6);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7> : HolderBase<T1, T2, T3, T4, T5, T6, T7>, IHolder<T1, T2, T3, T4, T5, T6, T7>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
            FlowBuilder.SetParameter(t6);
            FlowBuilder.SetParameter(t7);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
            FlowBuilder.SetParameter(t6);
            FlowBuilder.SetParameter(t7);
            FlowBuilder.SetParameter(t8);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
            FlowBuilder.SetParameter(t6);
            FlowBuilder.SetParameter(t7);
            FlowBuilder.SetParameter(t8);
            FlowBuilder.SetParameter(t9);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
            FlowBuilder.SetParameter(t6);
            FlowBuilder.SetParameter(t7);
            FlowBuilder.SetParameter(t8);
            FlowBuilder.SetParameter(t9);
            FlowBuilder.SetParameter(t10);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
            FlowBuilder.SetParameter(t6);
            FlowBuilder.SetParameter(t7);
            FlowBuilder.SetParameter(t8);
            FlowBuilder.SetParameter(t9);
            FlowBuilder.SetParameter(t10);
            FlowBuilder.SetParameter(t11);
        }
    }

    public class Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : HolderBase<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public FlowBuilder FlowBuilder { get; }
        public Holder(FlowBuilder backing) {
            FlowBuilder = backing;
        }
        public Holder(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) {
            FlowBuilder = new FlowBuilder();
            FlowBuilder.SetParameter(t1);
            FlowBuilder.SetParameter(t2);
            FlowBuilder.SetParameter(t3);
            FlowBuilder.SetParameter(t4);
            FlowBuilder.SetParameter(t5);
            FlowBuilder.SetParameter(t6);
            FlowBuilder.SetParameter(t7);
            FlowBuilder.SetParameter(t8);
            FlowBuilder.SetParameter(t9);
            FlowBuilder.SetParameter(t10);
            FlowBuilder.SetParameter(t11);
            FlowBuilder.SetParameter(t12);
        }
    }

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

}