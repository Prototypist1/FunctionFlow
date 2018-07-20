
using System;

namespace Prototypist.FunctionGraph
{
    public static partial class FlowBuilderExtensions
    {
        private static class DontParallel
        {
            public static void Invoke(Action[] actions)
            {
                foreach (var action in actions)
                {
                    action();
                }
            }
        }

    }
}
