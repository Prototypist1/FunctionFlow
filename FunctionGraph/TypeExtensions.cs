
using System;
using System.Linq;

namespace Prototypist.FunctionGraph
{
    internal static class TypeExtensions
    {

        public static bool IsAction(this Type funcType)
        {
            return funcType == typeof(Action) || new[] {
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
                }.Contains(funcType.GetGenericTypeDefinition());
        }

        public static bool IsFunc(this Type funcType)
        {
            return funcType.IsGenericType && new[] {
                    typeof(Func<>),
                    typeof(Func<,>),
                    typeof(Func<,,>),
                    typeof(Func<,,,>),
                    typeof(Func<,,,,>),
                    typeof(Func<,,,,,>),
                    typeof(Func<,,,,,,>),
                    typeof(Func<,,,,,,,>),
                    typeof(Func<,,,,,,,,>),
                    typeof(Func<,,,,,,,,,>),
                    typeof(Func<,,,,,,,,,,>),
                    typeof(Func<,,,,,,,,,,,>),
                    typeof(Func<,,,,,,,,,,,,>),
                    typeof(Func<,,,,,,,,,,,,,>),
                    typeof(Func<,,,,,,,,,,,,,,>),
                    typeof(Func<,,,,,,,,,,,,,,,>),
                    typeof(Func<,,,,,,,,,,,,,,,,>),
                }.Contains(funcType.GetGenericTypeDefinition());
        }
        
        public static Type FuncReturn(this Type funcType)
        {
            if (funcType.IsFunc())
            {
                return funcType.GetGenericArguments().Last();
            }
            else
            {
                return null;
            }
        }

        public static Type[] Parameters(this Type funcType)
        {
            if (funcType.IsAction())
            {
                return funcType.GetGenericArguments();
            }
            else if (funcType.IsFunc())
            {
                return funcType.GetGenericArguments().Take(funcType.GetGenericArguments().Count() - 1).ToArray();
            }
            throw new Exception($"{funcType} should be an {typeof(Action)} or {typeof(Func<>)}");
        }
        
    }


}
