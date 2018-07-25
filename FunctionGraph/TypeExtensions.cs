
using System;
using System.Linq;

namespace Prototypist.FunctionGraph
{
    internal static class TypeExtensions
    {

        public static bool IsAction(this Type funcType)
        {
            return funcType == typeof(Action) || actionsArray.Value.Contains(funcType.GetGenericTypeDefinition());
        }

        public static bool IsFunc(this Type funcType)
        {
            return funcType.IsGenericType && functionsArray.Value.Contains(funcType.GetGenericTypeDefinition());
        }
        
        public static Type FuncReturnOrNull(this Type funcType)
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

        private static readonly Lazy<Type[]> functionsArray = new Lazy<Type[]>(() => new Type[] {
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
        });

        private static readonly Lazy<Type[]> actionsArray = new Lazy<Type[]>(() => new Type[] {
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
        });

    }


}
