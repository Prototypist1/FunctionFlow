
using System;
using Prototypist.FunctionGraph;

namespace Prototypist.FunctionGraph.Strong
{

    public static class HolderExtensions
    {

#region Add

        public static IHolder<TOut> Add<THolder, TOut>(this IHack<Holder, THolder> self, Func<TOut> func)
            where THolder : Holder 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, TOut> Add<THolder, T1, TOut>(this IHack<Holder<T1>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, TOut> Add<THolder, T1,TIn1, TOut>(this IHack<Holder<T1>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, TOut> Add<THolder, T1, T2, TOut>(this IHack<Holder<T1, T2>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, TOut> Add<THolder, T1, T2,TIn1, TOut>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, TOut> Add<THolder, T1, T2,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut> Add<THolder, T1, T2, T3, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut> Add<THolder, T1, T2, T3,TIn1, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut> Add<THolder, T1, T2, T3,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut> Add<THolder, T1, T2, T3,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut> Add<THolder, T1, T2, T3, T4, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut> Add<THolder, T1, T2, T3, T4,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut> Add<THolder, T1, T2, T3, T4,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut> Add<THolder, T1, T2, T3, T4,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut> Add<THolder, T1, T2, T3, T4,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut> Add<THolder, T1, T2, T3, T4, T5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut> Add<THolder, T1, T2, T3, T4, T5,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut> Add<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut> Add<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut> Add<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut> Add<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut> Add<THolder, T1, T2, T3, T4, T5, T6,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut> Add<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut> Add<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut> Add<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut> Add<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut> Add<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(self.FlowBuilder);
        }
#endregion

#region Update

        public static IHolder<T1> Update<THolder, T1, TOut>(this IHack<Holder<T1>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1>(self.FlowBuilder);
        }

        public static IHolder<T1> Update<THolder, T1,TIn1, TOut>(this IHack<Holder<T1>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1>(self.FlowBuilder);
        }

        public static IHolder<T1, T2> Update<THolder, T1, T2, TOut>(this IHack<Holder<T1, T2>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2> Update<THolder, T1, T2,TIn1, TOut>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2> Update<THolder, T1, T2,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> Update<THolder, T1, T2, T3, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> Update<THolder, T1, T2, T3,TIn1, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> Update<THolder, T1, T2, T3,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> Update<THolder, T1, T2, T3,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> Update<THolder, T1, T2, T3, T4, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> Update<THolder, T1, T2, T3, T4,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> Update<THolder, T1, T2, T3, T4,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> Update<THolder, T1, T2, T3, T4,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> Update<THolder, T1, T2, T3, T4,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> Update<THolder, T1, T2, T3, T4, T5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> Update<THolder, T1, T2, T3, T4, T5,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> Update<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> Update<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> Update<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> Update<THolder, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> Update<THolder, T1, T2, T3, T4, T5, T6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> Update<THolder, T1, T2, T3, T4, T5, T6,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> Update<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> Update<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> Update<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> Update<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> Update<THolder, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> Update<THolder, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TIn12>, IHold<TOut>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }
#endregion

#region PackedAdd

        public static IHolder<TOut1, TOut2> PackedAdd<THolder, TOut1, TOut2>(this IHack<Holder, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, TOut1, TOut2> PackedAdd<THolder, T1, TOut1, TOut2>(this IHack<Holder<T1>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, TOut1, TOut2> PackedAdd<THolder, T1, TIn1, TOut1, TOut2>(this IHack<Holder<T1>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, TOut1, TOut2> PackedAdd<THolder, T1, T2, TOut1, TOut2>(this IHack<Holder<T1, T2>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, TOut1, TOut2> PackedAdd<THolder, T1, T2, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, TOut1, TOut2> PackedAdd<THolder, T1, T2, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> 
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(self.FlowBuilder);
        }
#endregion

#region PackedUpdate

        public static IHolder<T1, T2> PackedUpdate<THolder, T1, T2, TOut1, TOut2>(this IHack<Holder<T1, T2>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2> PackedUpdate<THolder, T1, T2, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2> PackedUpdate<THolder, T1, T2, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> PackedUpdate<THolder, T1, T2, T3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> PackedUpdate<THolder, T1, T2, T3, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> PackedUpdate<THolder, T1, T2, T3, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3> PackedUpdate<THolder, T1, T2, T3, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> PackedUpdate<THolder, T1, T2, T3, T4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> PackedUpdate<THolder, T1, T2, T3, T4, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> PackedUpdate<THolder, T1, T2, T3, T4, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> PackedUpdate<THolder, T1, T2, T3, T4, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4> PackedUpdate<THolder, T1, T2, T3, T4, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> PackedUpdate<THolder, T1, T2, T3, T4, T5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> PackedUpdate<THolder, T1, T2, T3, T4, T5, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> PackedUpdate<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> PackedUpdate<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> PackedUpdate<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5> PackedUpdate<THolder, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<(TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>  , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }

        public static IHolder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<THolder, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(this IHack<Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, THolder> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, (TOut1, TOut2)> func)
            where THolder : Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TIn12> , IHold<TOut1>, IHold<TOut2>
        {
            self.FlowBuilder.AddStep(func);
            return new Holder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(self.FlowBuilder);
        }
#endregion

    }
}