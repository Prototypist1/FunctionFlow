
using System;
using Prototypist.FunctionFlow;

namespace Prototypist.FunctionFlow.Strong
{

    public static class StrongFlowExtensions
    {

#region Add

        public static IStrongFlow<TOut> Add<TStrongFlow, TOut>(this IHack<StrongFlow, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow 
        {
            self.AddStep(func);
            return new StrongFlow<TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, TOut> Add<TStrongFlow, T1, TOut>(this IHack<StrongFlow<T1>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, TOut> Add<TStrongFlow, T1,TIn1, TOut>(this IHack<StrongFlow<T1>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, TOut> Add<TStrongFlow, T1, T2, TOut>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, TOut> Add<TStrongFlow, T1, T2,TIn1, TOut>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, TOut> Add<TStrongFlow, T1, T2,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut> Add<TStrongFlow, T1, T2, T3, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut> Add<TStrongFlow, T1, T2, T3,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut> Add<TStrongFlow, T1, T2, T3,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut> Add<TStrongFlow, T1, T2, T3,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut> Add<TStrongFlow, T1, T2, T3, T4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut> Add<TStrongFlow, T1, T2, T3, T4,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut> Add<TStrongFlow, T1, T2, T3, T4,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut> Add<TStrongFlow, T1, T2, T3, T4,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut> Add<TStrongFlow, T1, T2, T3, T4,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> 
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut> Add<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>((StrongFlowBase)self);
        }
#endregion

#region Update

        public static IStrongFlow<T1> Update<TStrongFlow, T1, TOut>(this IHack<StrongFlow<T1>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1> Update<TStrongFlow, T1,TIn1, TOut>(this IHack<StrongFlow<T1>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2> Update<TStrongFlow, T1, T2, TOut>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2> Update<TStrongFlow, T1, T2,TIn1, TOut>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2> Update<TStrongFlow, T1, T2,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> Update<TStrongFlow, T1, T2, T3, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> Update<TStrongFlow, T1, T2, T3,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> Update<TStrongFlow, T1, T2, T3,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> Update<TStrongFlow, T1, T2, T3,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> Update<TStrongFlow, T1, T2, T3, T4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> Update<TStrongFlow, T1, T2, T3, T4,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> Update<TStrongFlow, T1, T2, T3, T4,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> Update<TStrongFlow, T1, T2, T3, T4,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> Update<TStrongFlow, T1, T2, T3, T4,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> Update<TStrongFlow, T1, T2, T3, T4, T5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> Update<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> Update<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> Update<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> Update<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> Update<TStrongFlow, T1, T2, T3, T4, T5,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> Update<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> Update<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> Update<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> Update<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> Update<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> Update<TStrongFlow, T1, T2, T3, T4, T5, T6,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Update<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TIn12>, IHold<TOut>
        {
            self.AddStep(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }
#endregion

#region PackedAdd

        public static IStrongFlow<TOut1, TOut2> PackedAdd<TStrongFlow, TOut1, TOut2>(this IHack<StrongFlow, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, TOut1, TOut2> PackedAdd<TStrongFlow, T1, TOut1, TOut2>(this IHack<StrongFlow<T1>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, TOut1, TOut2> PackedAdd<TStrongFlow, T1, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> 
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2> PackedAdd<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>((StrongFlowBase)self);
        }
#endregion

#region PackedUpdate

        public static IStrongFlow<T1, T2> PackedUpdate<TStrongFlow, T1, T2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2> PackedUpdate<TStrongFlow, T1, T2, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2> PackedUpdate<TStrongFlow, T1, T2, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> PackedUpdate<TStrongFlow, T1, T2, T3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> PackedUpdate<TStrongFlow, T1, T2, T3, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> PackedUpdate<TStrongFlow, T1, T2, T3, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3> PackedUpdate<TStrongFlow, T1, T2, T3, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> PackedUpdate<TStrongFlow, T1, T2, T3, T4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> PackedUpdate<TStrongFlow, T1, T2, T3, T4, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> PackedUpdate<TStrongFlow, T1, T2, T3, T4, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> PackedUpdate<TStrongFlow, T1, T2, T3, T4, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4> PackedUpdate<TStrongFlow, T1, T2, T3, T4, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<(TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>  , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }

        public static IStrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> PackedUpdate<TStrongFlow, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(this IHack<StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, TStrongFlow> self, Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, (TOut1, TOut2)> func)
            where TStrongFlow : StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> , IHold<TIn1>, IHold<TIn2>, IHold<TIn3>, IHold<TIn4>, IHold<TIn5>, IHold<TIn6>, IHold<TIn7>, IHold<TIn8>, IHold<TIn9>, IHold<TIn10>, IHold<TIn11>, IHold<TIn12> , IHold<TOut1>, IHold<TOut2>
        {
            self.AddStepPacked<TOut1, TOut2>(func);
            return new StrongFlow<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((StrongFlowBase)self);
        }
#endregion

    }
}