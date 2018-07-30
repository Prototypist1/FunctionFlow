
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototypist.FunctionFlow
{
    public interface IContainer
    {
        T Get<T>();
    }

    public partial class FlowBuilder : IFlowBuilder
    {
        public bool Parallel { get; set; } = false;

        private readonly Dictionary<Type, Delegate> sources = new Dictionary<Type, Delegate>();
        private readonly Dictionary<Type, Expression> constants = new Dictionary<Type, Expression>();
        private Func<Type, Expression> fallbackSource;
        private readonly List<WorkItem> todo = new List<WorkItem>();

        public FlowBuilder()
        {
        }

        #region Configure

        public void SetContainer(IContainer container)
        {
            var containerParameter = Expression.Constant(container);
            var get = typeof(IContainer).GetMethods().Where(x => x.Name == "Get" && x.IsGenericMethod).Single();
            fallbackSource = (type) => Expression.Call(containerParameter, get.MakeGenericMethod(type));
        }

        public void SetConstant<T>(T t)
        {
            var key = typeof(T);
            if (sources.ContainsKey(key)) {
                throw new Exception($"Source already set for {key}");
            }
            constants.Add(key, Expression.Constant(t));
        }

        // you can make sources loop pretty easy
        // A -> B
        // B -> A
        // or just
        // A -> A
        // is it worth reflecting around and blocking loops?
        // probably atleast worth throwing in BuildExpression
        public void SetSource<T>(T t)
            where T : Delegate
        {
            var key = typeof(T).FuncReturnOrNull();
            if (constants.ContainsKey(key))
            {
                throw new Exception($"Constant already set for {key}");
            }
            sources.Add(key, t);
        }

        public void AddStep(Delegate expression)
        {
            var returnType = expression.GetType().FuncReturnOrNull();
            if (returnType == null)
            {
                todo.Add(new WorkItem(expression, new Type[0]));
            }
            else {
                todo.Add(new WorkItem(expression, new[] { returnType }));
            }
        }

        public void AddStepPacked<T1, T2>(Delegate expression)
        {
            todo.Add(new WorkItem(expression, new[] { typeof(T1), typeof(T2) }));
        }

        public void AddStepPacked<T1, T2, T3>(Delegate expression)
        {
            todo.Add(new WorkItem(expression, new[] { typeof(T1), typeof(T2), typeof(T3) }));
        }

        public void AddStepPacked<T1, T2, T3, T4>(Delegate expression)
        {
            todo.Add(new WorkItem(expression, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }));
        }

        public void AddStepPacked<T1, T2, T3, T4, T5>(Delegate expression)
        {
            todo.Add(new WorkItem(expression, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }));
        }

        public void AddStepPacked<T1, T2, T3, T4, T5, T6>(Delegate expression)
        {
            todo.Add(new WorkItem(expression, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) }));
        }

        public void AddStepPacked<T1, T2, T3, T4, T5, T6, T7>(Delegate expression)
        {
            todo.Add(new WorkItem(expression, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7) }));
        }

        #endregion

        #region Build/Run

        public void Run(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new Type[0],
                NoReturn(),
                parameters,
                todo).Compile().DynamicInvoke(inputs);
        }

        public T Run<T>(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            return (T)(BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new[] { typeof(T) },
                SingleReturn(typeof(T)),
                parameters,
                todo).Compile().DynamicInvoke(inputs));
        }

        public (T1, T2) Run<T1, T2>(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            return (ValueTuple<T1, T2>)(BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new[] { typeof(T1), typeof(T2) },
                MultiReturn(typeof(ValueTuple<T1, T2>)),
                parameters,
                todo).Compile().DynamicInvoke(inputs));
        }

        public (T1, T2, T3) Run<T1, T2, T3>(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            return (ValueTuple<T1, T2, T3>)(BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new[] { typeof(T1), typeof(T2), typeof(T3) },
                MultiReturn(typeof(ValueTuple<T1, T2, T3>)),
                parameters,
                todo).Compile().DynamicInvoke(inputs));
        }

        public (T1, T2, T3, T4) Run<T1, T2, T3, T4>(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            return (ValueTuple<T1, T2, T3, T4>)(BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) },
                MultiReturn(typeof(ValueTuple<T1, T2, T3, T4>)),
                parameters,
                todo).Compile().DynamicInvoke(inputs));
        }

        public (T1, T2, T3, T4, T5) Run<T1, T2, T3, T4, T5>(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            return (ValueTuple<T1, T2, T3, T4, T5>)(BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) },
                MultiReturn(typeof(ValueTuple<T1, T2, T3, T4, T5>)),
                parameters,
                todo).Compile().DynamicInvoke(inputs));
        }

        public (T1, T2, T3, T4, T5, T6) Run<T1, T2, T3, T4, T5, T6>(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            return (ValueTuple<T1, T2, T3, T4, T5, T6>)(BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) },
                MultiReturn(typeof(ValueTuple<T1, T2, T3, T4, T5, T6>)),
                parameters,
                todo).Compile().DynamicInvoke(inputs));
        }

        public (T1, T2, T3, T4, T5, T6, T7) Run<T1, T2, T3, T4, T5, T6, T7>(params object[] inputs)
        {
            var parameters = inputs.Select(x => Expression.Parameter(x.GetType())).ToArray();

            return (ValueTuple<T1, T2, T3, T4, T5, T6, T7>)(BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7) },
                MultiReturn(typeof(ValueTuple<T1, T2, T3, T4, T5, T6, T7>)),
                parameters,
                todo).Compile().DynamicInvoke(inputs));
        }

        public T Build<T>() where T : Delegate
        {
            var parameters = typeof(T).Parameters().Select(x => Expression.Parameter(x)).ToArray();

            return (T)BuildExpression(
                FromParams(parameters, FromConstants(FromSources(FromContainer()))),
                Parallel,
                GetReturns(typeof(T)),
                typeof(T).FuncReturnOrNull() != null ? SingleReturn(typeof(T).FuncReturnOrNull()) : NoReturn(),
                parameters,
                todo).Compile();
        }

        #endregion

        #region Build/Run Help

        private Func<Type, Func<Type, Expression>, Expression> FromParams(ParameterExpression[] parameters, Func<Type, Func<Type, Expression>, Expression> fallback)
        {
            return (type, searchCurrentContext) =>
            {
                var res = parameters.SingleOrDefault(x => x.Type == type);
                if (res == null)
                {
                    return fallback(type, searchCurrentContext);
                }
                return res;
            };
        }

        private Func<Type, Func<Type, Expression>, Expression> FromConstants(Func<Type, Func<Type, Expression>, Expression> fallback)
        {
            return (type, searchCurrent) =>
            {
                if (constants.TryGetValue(type, out var cons))
                {
                    return cons;
                }
                return fallback(type, searchCurrent);
            };
        }

        private Func<Type, Func<Type, Expression>, Expression> FromSources(Func<Type, Func<Type, Expression>, Expression> fallback)
        {
            return (type, searchCurrent) =>
            {
                if (sources.TryGetValue(type, out var source))
                {
                    var parms = source.GetType().Parameters().Select(x => searchCurrent(x)).ToArray();
                    var toCall = Expression.Constant(source);
                    return Expression.Invoke(toCall, parms);
                }
                return fallback(type, searchCurrent);
            };
        }

        private Func<Type, Func<Type, Expression>, Expression> FromContainer()
        {
            return (type, searchCurrent) =>
            {
                if (fallbackSource == null)
                {
                    throw new Exception("Parameter not found");
                }

                return fallbackSource(type);
            };
        }

        private static Type[] GetReturns(Type type)
        {

            var returnType = type.FuncReturnOrNull();

            if (returnType == null)
            {
                return new Type[0];
            }
            return new Type[] { returnType };
        }

        private static Func<Expression[], Expression[]> NoReturn()
        {
            return x => new Expression[0];
        }

        private static Func<Expression[], Expression[]> SingleReturn(Type type)
        {
            return x =>
            {
                return new Expression[]{
                     x.Single()
                };
            };
        }

        private Func<Expression[], Expression[]> MultiReturn(Type type)
        {
            return x =>
            {
                var constructor = type.GetConstructor(type.GetGenericArguments());
                return new Expression[] {
                     Expression.New(constructor, x)
                };
            };
        }

        private static Func<Type, Expression> FromInputs(object[] inputs)
        {

            var parameters = inputs.Select(x => Expression.Constant(x, x.GetType())).ToArray();

            return type => parameters.Single(x => x.Type == type);
        }


        #endregion

        private static LambdaExpression BuildExpression(
            Func<Type, Func<Type, Expression>, Expression> getParameter,
            bool parallel,
            Type[] returns,
            Func<Expression[], Expression[]> addReturn,
            ParameterExpression[] parameters,
            List<WorkItem> todo)
        {
            var resultsDict = new Dictionary<Type, ParameterExpression>();

            var expressionInfos = todo.Select(x => new ExpressionInfo(x)).ToList();

            // discover dependency chain
            for (int i = 0; i < expressionInfos.Count; i++)
            {
                var expressionInfo = expressionInfos[i];
                for (var parmIndex = 0; parmIndex < expressionInfo.ParameterTypes.Length; parmIndex++)
                {
                    var parmType = expressionInfo.ParameterTypes[parmIndex];
                    expressionInfo.Inputs[parmIndex] = FindInput(expressionInfo, parmType, i);
                }
                if (expressionInfo.returnTypes != null && expressionInfo.returnTypes.Count() != 0) {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        var otherExpressionInfo = expressionInfos[j];
                        if (otherExpressionInfo.SameOutput(expressionInfo)) {
                            if (!expressionInfo.WillWaitFor(otherExpressionInfo))
                            {
                                expressionInfo.waitsOn.Add(otherExpressionInfo);
                            }
                        }
                    }
                }
            }

            var results = new Expression[returns.Length];

            for (int i = 0; i < returns.Length; i++)
            {
                var type = returns[i];
                results[i] = FindInput(null, type, expressionInfos.Count);
            }
            
            var body = expressionInfos.Select(expressionInfo => {
                if (parallel)
                {

                    expressionInfo.task = Expression.Parameter(typeof(Task));
                    var tasks = expressionInfo.waitsOn.Select(x => x.task).Cast<Expression>().ToArray();
                    if (tasks.Any())
                    {
                        var whenAll = taskWhenAll.Value;
                        var wait = Expression.Call(whenAll, Expression.NewArrayInit(typeof(Task), tasks));

                        var lambda = MakeTaskLambda(expressionInfo);
                        var run = Expression.Call(wait, taskContinueWith.Value, lambda);
                        return Expression.Assign(expressionInfo.task, run);
                    }
                    else {
                        var lambda = MakeLambda(expressionInfo);
                        return Expression.Assign(expressionInfo.task, Expression.Call(taskRun.Value, lambda));
                    }
                }
                return MakeSingle(expressionInfo);
            }).ToList();
            
            if (parallel) {
                var tasks = expressionInfos.Select(x => x.task).ToArray();
                var whenAll = Expression.Call(taskWhenAll.Value, Expression.NewArrayInit(typeof(Task), tasks));
                var wait = Expression.Call(whenAll, taskWait.Value);
                body.Add(wait);
            }

            body.AddRange(addReturn(results));

            var extraParametersBuilder = resultsDict.Select(x => x.Value);
            if (parallel)
            {
                extraParametersBuilder = extraParametersBuilder.Concat(expressionInfos.Select(x => x.task));
            }
            var extraParameters = extraParametersBuilder.ToArray();

            var allParameters = extraParameters.Concat(parameters);

            var inner = Expression.Lambda(Expression.Block(body), allParameters);

            if (!extraParameters.Any()) {
                return inner;
            }

            var agrs = extraParameters.Select(x => Expression.Constant(GetDefault(x.Type),x.Type)).Concat(parameters.Cast<Expression>()).ToArray();
            var final = Expression.Lambda(Expression.Invoke(inner, agrs), parameters);

            return final;

            #region Help

            Expression MakeTaskLambda(ExpressionInfo target) {
                return Expression.Lambda<Action<Task>>(MakeSingle(target), new ParameterExpression[] { Expression.Parameter(typeof(Task)) });
            }


            Expression MakeLambda(ExpressionInfo target)
            {
                var expression = MakeSingle(target);
                
                if (expression is Expression<Action>) {
                    return expression;
                }

                return Expression.Lambda<Action>(expression);
            }

            Expression MakeSingle(ExpressionInfo target)
            {
                var innerParameters = new List<Expression>();
                for (var i = 0; i < target.ParameterTypes.Length; i++)
                {
                    var input = target.Inputs[i];
                    innerParameters.Add(input);
                }
                if (target.Result != null)
                {
                    return Expression.Assign(target.Result, Expression.Invoke(target.backing, innerParameters));
                }
                else
                {
                    return Expression.Invoke(target.backing, innerParameters);
                }
            }
            
            Expression GetVar(Type t)
            {
                if (resultsDict.TryGetValue(t, out var res))
                {
                    return res;
                }
                else {
                    var newVal = Expression.Parameter(t,t.Name.ToLower());
                    resultsDict[t] = newVal;
                    return newVal;
                }
            }

            Expression FindInput(ExpressionInfo expressionOrNull, Type parmType, int startAt)
            {
                Expression input = null;
                for (int j = startAt - 1; j >= 0; j--)
                {
                    var sourceExpressionInfo = expressionInfos[j];
                    if (sourceExpressionInfo.returnTypes.Length > 1)
                    {
                        // sourceExpressionInfo.ReturnType is valueTuple
                        // we need to walk over it's members
                        for (int k = 0; k < sourceExpressionInfo.returnTypes.Length; k++)
                        {
                            if (sourceExpressionInfo.returnTypes[k] == parmType)
                            {
                                if (!(expressionOrNull?.WillWaitFor(sourceExpressionInfo) ?? true))
                                {
                                    expressionOrNull?.waitsOn?.Add(sourceExpressionInfo);
                                }
                                var tupleType = valueTypeArray.Value[sourceExpressionInfo.returnTypes.Length - 1].MakeGenericType(sourceExpressionInfo.returnTypes);
                                if (sourceExpressionInfo.Result == null)
                                {
                                    sourceExpressionInfo.Result = GetVar(tupleType);
                                }
                                if (input == null)
                                {
                                    input = Expression.Field(sourceExpressionInfo.Result, tupleType.GetField("Item" + (k + 1)));
                                }
                            }
                        }
                    }
                    else
                    {
                        if (sourceExpressionInfo.returnTypes[0] == parmType)
                        {
                            if (!(expressionOrNull?.WillWaitFor(sourceExpressionInfo)?? true))
                            {
                                expressionOrNull?.waitsOn?.Add(sourceExpressionInfo);
                            }
                            if (sourceExpressionInfo.Result == null)
                            {
                                sourceExpressionInfo.Result = GetVar(parmType);
                            }
                            if (input == null)
                            {
                                input = sourceExpressionInfo.Result;
                            }
                        }
                    }
                }

                if (input == null)
                {
                    input =  getParameter(parmType, t => FindInput(null, t, startAt));
                }

                return input;

            }

            object GetDefault(Type type)
            {
                if (type.IsValueType)
                {
                    return Activator.CreateInstance(type);
                }
                return null;
            }

            #endregion
        }

        #region Static

        private static Lazy<MethodInfo> taskWait = new Lazy<MethodInfo>(() => typeof(Task)
            .GetMethods()
            .Where(x => 
                x.Name == "Wait" && 
                !x.IsGenericMethod && 
                x.GetParameters().Count() == 0)
            .Single());

        private static Lazy<MethodInfo> taskWhenAll = new Lazy<MethodInfo>(() => typeof(Task)
            .GetMethods()
            .Where(x => 
            x.Name == "WhenAll" && 
                !x.IsGenericMethod && 
                x.GetParameters().Count() == 1 
                && x.GetParameters().Single().ParameterType == typeof(Task[]))
            .Single());

        private static Lazy<MethodInfo> taskContinueWith = new Lazy<MethodInfo>(() => typeof(Task)
            .GetMethods()
            .Where(x => 
                x.Name == "ContinueWith" && 
                !x.IsGenericMethod && 
                x.GetParameters().Count() == 1)
            .Single());
        
        private static Lazy<MethodInfo> taskRun = new Lazy<MethodInfo>(() => typeof(Task)
            .GetMethods()
            .Where(x => 
                x.Name == "Run" && 
                !x.IsGenericMethod && 
                x.GetParameters().Count() == 1 && 
                x.GetParameters().Single().ParameterType == typeof(Action))
            .Single());

        private static readonly Lazy<Type[]> valueTypeArray = new Lazy<Type[]>(() => {
            return new Type[]{
                    typeof(ValueTuple<>),
                    typeof(ValueTuple<,>),
                    typeof(ValueTuple<,,>),
                    typeof(ValueTuple<,,,>),
                    typeof(ValueTuple<,,,,>),
                    typeof(ValueTuple<,,,,,>),
                };
        });

        private static readonly Lazy<Type[]> actionArray = new Lazy<Type[]>(() => {
            return new Type[]{
                    typeof(Action),
                    typeof(Action<>),
                    typeof(Action<,>),
                    typeof(Action<,,>),
                    typeof(Action<,,,>),
                    typeof(Action<,,,,>),
                    typeof(Action<,,,,,>),
                    typeof(Action<,,,,,,>),
                    typeof(Action<,,,,,,,>),
                    typeof(Action<,,,,,,,,>),
                    typeof(Action<,,,,,,,,,>),
                    typeof(Action<,,,,,,,,,,>),
                    typeof(Action<,,,,,,,,,,,>),
                    typeof(Action<,,,,,,,,,,,,>),
                    typeof(Action<,,,,,,,,,,,,,>),
                    typeof(Action<,,,,,,,,,,,,,,>),
                    typeof(Action<,,,,,,,,,,,,,,,>),
                };
        });

        #endregion
    }
}
