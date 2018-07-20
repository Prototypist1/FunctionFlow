using System;
using System.Linq;

namespace Prototypist.FunctionGraph
{
    public static partial class FlowBuilderExtensions {

        public static IFlowBuilder Set<T>(this IFlowBuilder self, T t) {
            self.SetParameter<T>(t);
            return self;
        }

        public static IFlowBuilder Container<T>(this IFlowBuilder self, IContainer container)
        {
            self.SetContainer(container);
            return self;
        }

        public static IFlowBuilder RunInSeries(this IFlowBuilder self)
        {
            self.Parallel = typeof(DontParallel).GetMethods().Where(x => x.Name == "Invoke" && x.GetParameters().Count() == 1).Single();
            return self;
        }

        public static IFlowBuilder Source<TResult>(this IFlowBuilder self, Func<TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, TResult>(this IFlowBuilder self, Func<T1,TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, TResult>(this IFlowBuilder self, Func<T1, T2, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, TResult>(this IFlowBuilder self, Func<T1, T2,T3, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3,T4, TResult>(this IFlowBuilder self, Func<T1, T2, T3,T4, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4,T5, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4,T5, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5,T6, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5,T6, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6,T7, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6,T7, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7,T8, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7,T8, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8,T9, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8,T9, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }

        public static IFlowBuilder Source<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            self.SetParameterSource(func);
            return self;
        }
        
        public static IFlowBuilder Then(this IFlowBuilder self, Action todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1>(this IFlowBuilder self, Action<T1> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1,T2>(this IFlowBuilder self, Action<T1, T2> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1,T2,T3>(this IFlowBuilder self, Action<T1, T2, T3> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1,T2,T3,T4>(this IFlowBuilder self, Action<T1, T2, T3, T4> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5>(this IFlowBuilder self, Action<T1, T2, T3, T4,T5> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6> todo)
        {
            self.AddStep(todo);
            return self;
        }
        
        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> todo)
        {
            self.AddStep(todo);
            return self;
        }
        
        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> todo)
        {
            self.AddStep(todo);
            return self;
        }
        
        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IFlowBuilder self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<TResult>(this IFlowBuilder self, Func<TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, TResult>(this IFlowBuilder self, Func<T1, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, TResult>(this IFlowBuilder self, Func<T1, T2, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, TResult>(this IFlowBuilder self, Func<T1, T2, T3, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

        public static IFlowBuilder Then<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this IFlowBuilder self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> todo)
        {
            self.AddStep(todo);
            return self;
        }

    }
}