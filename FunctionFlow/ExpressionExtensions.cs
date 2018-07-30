using System.Linq.Expressions;
using System.Reflection;

namespace Prototypist.FunctionFlow
{
    internal static class  ExpressionExtensions{
        public static string GetDebugView(this Expression exp)
        {
            if (exp == null)
                return null;

            var propertyInfo = typeof(Expression).GetProperty("DebugView", BindingFlags.Instance | BindingFlags.NonPublic);
            return propertyInfo.GetValue(exp) as string;
        }
    }
}
