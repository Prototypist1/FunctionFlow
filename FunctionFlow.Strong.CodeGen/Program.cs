using Prototypist.FunctionFlow.Strong;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototypist.FunctionFlow.Strong.CodeGen
{

    class Program
    {
        private const string _FunctionFlow = nameof(Prototypist.FunctionFlow);
        private const string _FlowBuilderProp = nameof(Prototypist.FunctionFlow.FlowBuilder);
        private const string _StrongFlow = nameof(Prototypist.FunctionFlow.Strong.StrongFlow);
        private const string _StrongFlowBase = nameof(Prototypist.FunctionFlow.Strong.StrongFlowBase);
        private const string _FlowBuilderType = nameof(Prototypist.FunctionFlow.FlowBuilder);
        private const string _Set = nameof(Prototypist.FunctionFlow.FlowBuilder.SetConstant);
        private const string _AddStep = nameof(Prototypist.FunctionFlow.FlowBuilder.AddStep);
        private const string _AddStepPacked = nameof(Prototypist.FunctionFlow.FlowBuilder.AddStepPacked);
        private const string _IHold = nameof(Prototypist.FunctionFlow.Strong.IHold);
        private const string _IStrongFlow = nameof(Prototypist.FunctionFlow.Strong.IStrongFlow);
        private static readonly string _IHack = Name(typeof(Prototypist.FunctionFlow.Strong.IHack<,>));
        private const int MaxOutputSize = 2;
        private const int MaxClassSize = 12;

        public class Frog {
            public int FlysEaten;

            public Frog(int flysEaten)
            {
                FlysEaten = flysEaten;
            }
        }
        public class Cat {
            public Frog Frog;

            public Cat(Frog frog)
            {
                Frog = frog ?? throw new ArgumentNullException(nameof(frog));
            }
        }
        public class Pig { }
        

        static void Main(string[] args)
        {
            WriteHolders();
            WriteExtensions();
        }

        private static void WriteExtensions()
        {
            var extensions = "";

            extensions += Environment.NewLine;
            extensions += $"#region {nameof(Add)}" + Environment.NewLine;

            for (int classSize = 0; classSize < MaxClassSize; classSize++)
            {
                for (int inputSize = 0; inputSize <= classSize; inputSize++)
                {
                    extensions += Add(classSize, inputSize);
                }
            }

            extensions += Environment.NewLine;
            extensions += "#endregion" + Environment.NewLine;
            extensions += Environment.NewLine;
            extensions += $"#region {nameof(Update)}" + Environment.NewLine;

            for (int classSize = 1; classSize <= MaxClassSize; classSize++)
            {
                for (int inputSize = 0; inputSize <= classSize; inputSize++)
                {
                    extensions += Update(classSize, inputSize);
                }
            }

            extensions += Environment.NewLine;
            extensions += "#endregion" + Environment.NewLine;
            extensions += Environment.NewLine;
            extensions += $"#region {nameof(PackedAdd)}" + Environment.NewLine;

            for (int classSize = 0; classSize < MaxClassSize; classSize++)
            {
                for (int inputSize = 0; inputSize <= classSize; inputSize++)
                {
                    for (int outputSize = 2; outputSize + classSize <= MaxClassSize && outputSize <= MaxOutputSize; outputSize++)
                    {
                        extensions += PackedAdd(classSize, inputSize, outputSize);
                    }
                }
            }

            extensions += Environment.NewLine;
            extensions += "#endregion" + Environment.NewLine;
            extensions += Environment.NewLine;
            extensions += $"#region {nameof(PackedUpdate)}" + Environment.NewLine;

            for (int classSize = 2; classSize <= MaxClassSize; classSize++)
            {
                for (int inputSize = 0; inputSize <= classSize; inputSize++)
                {
                    for (int outputSize = 2; classSize <= MaxClassSize && outputSize <= MaxOutputSize; outputSize++)
                    {
                        extensions += PackedUpdate(classSize, inputSize, outputSize);
                    }
                }
            }

            extensions += "#endregion" + Environment.NewLine;

            var extensionsText = WrapNameSpace(WrapExtensions(extensions));
            File.WriteAllText($"../../../../{_FunctionFlow}.Strong/Generated-{_StrongFlow}Extensions.cs", extensionsText);
        }

        private static void WriteHolders()
        {
            var holders = "";

            holders += Environment.NewLine;
            holders += $"#region  {nameof(BaseClass)}" + Environment.NewLine;

            for (int classSize = 1; classSize <= MaxClassSize; classSize++)
            {
                holders += BaseClass(classSize);
            }

            holders += Environment.NewLine;
            holders += "#endregion" + Environment.NewLine;
            holders += Environment.NewLine;
            holders += $"#region  {nameof(Class)}" + Environment.NewLine;

            for (int classSize = 1; classSize <= MaxClassSize; classSize++)
            {
                holders += Class(classSize);
            }

            holders += Environment.NewLine;
            holders += "#endregion" + Environment.NewLine;
            holders += Environment.NewLine;
            holders += $"#region {nameof(Interface)}" + Environment.NewLine;

            for (int classSize = 1; classSize <= MaxClassSize; classSize++)
            {
                holders += Interface(classSize);
            }

            holders += "#endregion" + Environment.NewLine;

            var holdersText = WrapNameSpace(holders);
            File.WriteAllText($"../../../../{_FunctionFlow}.Strong/Generated-{_StrongFlow}s.cs", holdersText);
        }

        private static string WrapExtensions(string inner)
        {
            return $@"
    public static class {_StrongFlow}Extensions
    {{
{inner}
    }}";
        }

        private static string WrapNameSpace(string inner)
        {
            return $@"
using System;
using Prototypist.{_FunctionFlow};

namespace Prototypist.{_FunctionFlow}.Strong
{{
{inner}
}}";
        }

        static string Interface(int n) {
            return $@"
    public interface {_IStrongFlow}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")} : {_IHack}<{_StrongFlow}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}, {_StrongFlow}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}>
    {{
    }}
";
        }

        static string BaseClass(int n)
        {
            var typeName = $"{_StrongFlowBase}<{GenericTs(n)}>";

            return $@"
    public class {typeName} : {_StrongFlowBase}{(n - 1 > 0 ? "<" : "")}{GenericTs(n - 1)}{(n - 1 > 0 ? ">" : "")}, {_IHold}<T{n}>
    {{
        public {_StrongFlowBase}({_StrongFlowBase} backing) : base(backing)
        {{
        }}

        protected {_StrongFlowBase}({_FlowBuilderType} flowBuilder) : base(flowBuilder)
        {{
        }}
    }}
";
        }

        static string Class(int n) {
            var baseName = $"{_StrongFlowBase}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}";
            var typeName = $"{_StrongFlow}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}";
            
            return $@"
    public class {typeName} : {baseName}, {_IStrongFlow}<{GenericTs(n)}>
    {{
        public {_StrongFlow}({_StrongFlowBase} backing): base(backing) {{
        }}
        public {_StrongFlow}({Parameters(n)}): base(new {_FlowBuilderType}()) {{
{Set(n)}
        }}
    }}
";

        }


        public static string Add(int n, int funcIn) {
            return $@"
        public static {_IStrongFlow}<{GenericTs(n)}{(n == 0 ? "" : ", ")}TOut> {nameof(Add)}<T{_StrongFlow}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ",")}{GenericTIns(funcIn)}, TOut>(this {_IHack}<{_StrongFlow}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_StrongFlow}> self, Func<{GenericTIns(funcIn) + (funcIn == 0? "":", ") }TOut> func)
            where T{_StrongFlow} : {_StrongFlow}{(n != 0 ? "<":"")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)}
        {{
            self.{_AddStep}(func);
            return new {_StrongFlow}<{GenericTs(n)}{(n == 0 ? "" : ", ")}TOut>(({_StrongFlowBase})self);
        }}
";
        }

        public static string Update(int n, int funcIn)
        {
            return $@"
        public static {_IStrongFlow}<{GenericTs(n)}> {nameof(Update)}<T{_StrongFlow}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ",")}{GenericTIns(funcIn)}, TOut>(this {_IHack}<{_StrongFlow}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_StrongFlow}> self, Func<{GenericTIns(funcIn) + (funcIn == 0 ? "" : ", ") }TOut> func)
            where T{_StrongFlow} : {_StrongFlow}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)}, {_IHold}<TOut>
        {{
            self.{_AddStep}(func);
            return new {_StrongFlow}<{GenericTs(n)}>(({_StrongFlowBase})self);
        }}
";
        }

        public static string PackedAdd(int n, int funcIn, int funcOut)
        {
            return $@"
        public static {_IStrongFlow}<{GenericTs(n)}{(n == 0 ? "" : ", ")}{GenericTOuts(funcOut)}> {nameof(PackedAdd)}<T{_StrongFlow}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ", ")}{GenericTIns(funcIn)}{(funcOut == 0 ? "" : ", ")}{GenericTOuts(funcOut)}>(this {_IHack}<{_StrongFlow}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_StrongFlow}> self, Func<{GenericTIns(funcIn)}{(funcIn == 0 ? "" : ", ")}({GenericTOuts(funcOut)})> func)
            where T{_StrongFlow} : {_StrongFlow}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)}
        {{
            self.{_AddStepPacked}<{GenericTOuts(funcOut)}>(func);
            return new {_StrongFlow}<{GenericTs(n)}{(n == 0 ? "" : ", ")}{GenericTOuts(funcOut)}>(({_StrongFlowBase})self);
        }}
";
        }

        public static string PackedUpdate(int n, int funcIn, int funcOut)
        {
            return $@"
        public static {_IStrongFlow}<{GenericTs(n)}> {nameof(PackedUpdate)}<T{_StrongFlow}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ", ")}{GenericTIns(funcIn)}{(funcOut == 0 ? "" : ", ")}{GenericTOuts(funcOut)}>(this {_IHack}<{_StrongFlow}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_StrongFlow}> self, Func<{GenericTIns(funcIn)}{(funcIn == 0 ? "" : ", ")}({GenericTOuts(funcOut)})> func)
            where T{_StrongFlow} : {_StrongFlow}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)} {HoldsOut(funcOut)}
        {{
            self.{_AddStepPacked}<{GenericTOuts(funcOut)}>(func);
            return new {_StrongFlow}<{GenericTs(n)}>(({_StrongFlowBase})self);
        }}
";
        }

        private static string Name(Type type)
        {
            return type.Name.Substring(0, type.Name.LastIndexOf('`'));
        }
        
        private static string Set(int n)
        {
            var res = "";
            for (int i = 0; i < n; i++)
            {
                res += $"            {_Set}(t{i + 1});" + (i != n-1?Environment.NewLine:"");
            }
            return res;
        }

        static string Holds(int n)
        {
            if (n == 0) { return ""; }
            var res = "";

            for (int i = 0; i < n; i++)
            {
                res += $", {_IHold}<TIn{i+1}>";
            }
            return res;
        }

        static string HoldsOut(int n)
        {
            if (n == 0) { return ""; }
            var res = "";

            for (int i = 0; i < n; i++)
            {
                res += $", {_IHold}<TOut{i + 1}>";
            }
            return res;
        }

        static string GenericTOuts(int n)
        {
            var res = "";

            for (int i = 0; i < n; i++)
            {
                res += $"TOut{i + 1}";
                if (i != n - 1)
                {
                    res += ", ";
                }
            }
            return res;
        }

        static string GenericTIns(int n)
        {
            var res = "";

            for (int i = 0; i < n; i++)
            {
                res += $"TIn{i+1}";
                if (i != n -1) {
                    res += ", ";
                }
            }
            return res;
        }

        static string GenericTs(int n) {
            var res = "";

            for (int i = 0; i < n; i++)
            {
                res += $"T{i + 1}";
                if (i != n - 1)
                {
                    res += ", ";
                }
            }
            return res;
        }

        static string Parameters(int n)
        {
            var res = "";

            for (int i = 0; i < n; i++)
            {
                res += $"T{i + 1} t{i+1}";
                if (i != n - 1)
                {
                    res += ", ";
                }
            }
            return res;
        }

        static string BaseInput(int n)
        {
            var res = "";

            for (int i = 0; i < n; i++)
            {
                res += $"t{i + 1}";
                if (i != n - 1)
                {
                    res += ", ";
                }
            }
            return res;
        }
    }
}

