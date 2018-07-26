using Prototypist.FunctionGraph.Strong;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototypist.FunctionGraph.Strong.CodeGen
{

    class Program
    {
        private const string _FlowBuilderProp = nameof(Prototypist.FunctionGraph.Strong.Holder.FlowBuilder);
        private const string _Holder = nameof(Prototypist.FunctionGraph.Strong.Holder);
        private const string _HolderBase = nameof(Prototypist.FunctionGraph.Strong.HolderBase);
        private const string _FlowBuilderType = nameof(Prototypist.FunctionGraph.FlowBuilder);
        private const string _Set = nameof(Prototypist.FunctionGraph.FlowBuilder.SetConstant);
        private const string _Do = nameof(Prototypist.FunctionGraph.FlowBuilder.AddStep);
        private const string _IHold = nameof(Prototypist.FunctionGraph.Strong.IHold);
        private const string _IHolder = nameof(Prototypist.FunctionGraph.Strong.IHolder);
        private static readonly string _IHack = Name(typeof(Prototypist.FunctionGraph.Strong.IHack<,>));
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

        #region MyRegion

        #endregion

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
            File.WriteAllText("../../../../FunctionGraph.Strong/Generated-HolderExtensions.cs", extensionsText);
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

            holders += "#endregion" + Environment.NewLine;
            holders += Environment.NewLine;
            holders += $"#region  {nameof(Class)}" + Environment.NewLine;

            for (int classSize = 1; classSize <= MaxClassSize; classSize++)
            {
                holders += Class(classSize);
            }

            holders += "#endregion" + Environment.NewLine;
            holders += Environment.NewLine;
            holders += $"#region {nameof(Interface)}" + Environment.NewLine;

            for (int classSize = 1; classSize <= MaxClassSize; classSize++)
            {
                holders += Interface(classSize);
            }

            holders += "#endregion" + Environment.NewLine;

            var holdersText = WrapNameSpace(holders);
            File.WriteAllText("../../../../FunctionGraph.Strong/Generated-Holders.cs", holdersText);
        }

        private static string WrapExtensions(string inner)
        {
            return $@"
    public static class HolderExtensions
    {{
{inner}
    }}";
        }

        private static string WrapNameSpace(string inner)
        {
            return $@"
using System;
using Prototypist.FunctionGraph;

namespace Prototypist.FunctionGraph.Strong
{{
{inner}
}}";
        }

        static string Interface(int n) {
            return $@"
    public interface {_IHolder}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")} : {_IHack}<{_Holder}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}, {_Holder}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}>
    {{
    }}
";
        }

        static string BaseClass(int n)
        {
            var typeName = $"{_HolderBase}<{GenericTs(n)}>";

            return $@"
    public class {typeName} : {_HolderBase}{(n - 1 > 0 ? "<" : "")}{GenericTs(n - 1)}{(n - 1 > 0 ? ">" : "")}, {_IHold}<T{n}>
    {{
    }}
";
        }

        static string Class(int n) {
            var baseName = $"{_HolderBase}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}";
            var typeName = $"{_Holder}{(n > 0 ? "<" : "")}{GenericTs(n)}{(n > 0 ? ">" : "")}";
            
            return $@"
    public class {typeName} : {baseName}, {_IHolder}<{GenericTs(n)}>
    {{
        public {_FlowBuilderType} {_FlowBuilderProp} {{ get; }}
        public {_Holder}({_FlowBuilderType} backing) {{
            {_FlowBuilderProp} = backing;
        }}
        public {_Holder}({Parameters(n)}) {{
            {_FlowBuilderProp} = new {_FlowBuilderType}();
{Set(n)}
        }}
    }}
";

        }


        public static string Add(int n, int funcIn) {
            return $@"
        public static {_IHolder}<{GenericTs(n)}{(n == 0 ? "" : ", ")}TOut> {nameof(Add)}<T{_Holder}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ",")}{GenericTIns(funcIn)}, TOut>(this {_IHack}<{_Holder}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_Holder}> self, Func<{GenericTIns(funcIn) + (funcIn == 0? "":", ") }TOut> func)
            where T{_Holder} : {_Holder}{(n != 0 ? "<":"")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)}
        {{
            self.{_FlowBuilderProp}.{_Do}(func);
            return new {_Holder}<{GenericTs(n)}{(n == 0 ? "" : ", ")}TOut>(self.{_FlowBuilderProp});
        }}
";
        }

        public static string Update(int n, int funcIn)
        {
            return $@"
        public static {_IHolder}<{GenericTs(n)}> {nameof(Update)}<T{_Holder}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ",")}{GenericTIns(funcIn)}, TOut>(this {_IHack}<{_Holder}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_Holder}> self, Func<{GenericTIns(funcIn) + (funcIn == 0 ? "" : ", ") }TOut> func)
            where T{_Holder} : {_Holder}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)}, {_IHold}<TOut>
        {{
            self.{_FlowBuilderProp}.{_Do}(func);
            return new {_Holder}<{GenericTs(n)}>(self.{_FlowBuilderProp});
        }}
";
        }

        public static string PackedAdd(int n, int funcIn, int funcOut)
        {
            return $@"
        public static {_IHolder}<{GenericTs(n)}{(n == 0 ? "" : ", ")}{GenericTOuts(funcOut)}> {nameof(PackedAdd)}<T{_Holder}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ", ")}{GenericTIns(funcIn)}{(funcOut == 0 ? "" : ", ")}{GenericTOuts(funcOut)}>(this {_IHack}<{_Holder}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_Holder}> self, Func<{GenericTIns(funcIn)}{(funcIn == 0 ? "" : ", ")}({GenericTOuts(funcOut)})> func)
            where T{_Holder} : {_Holder}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)}
        {{
            self.{_FlowBuilderProp}.{_Do}(func);
            return new {_Holder}<{GenericTs(n)}{(n == 0 ? "" : ", ")}{GenericTOuts(funcOut)}>(self.{_FlowBuilderProp});
        }}
";
        }

        public static string PackedUpdate(int n, int funcIn, int funcOut)
        {
            return $@"
        public static {_IHolder}<{GenericTs(n)}> {nameof(PackedUpdate)}<T{_Holder}{(n == 0 ? "" : ", ")}{GenericTs(n)}{(funcIn == 0 ? "" : ", ")}{GenericTIns(funcIn)}{(funcOut == 0 ? "" : ", ")}{GenericTOuts(funcOut)}>(this {_IHack}<{_Holder}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")}, T{_Holder}> self, Func<{GenericTIns(funcIn)}{(funcIn == 0 ? "" : ", ")}({GenericTOuts(funcOut)})> func)
            where T{_Holder} : {_Holder}{(n != 0 ? "<" : "")}{GenericTs(n)}{(n != 0 ? ">" : "")} {Holds(funcIn)} {HoldsOut(funcOut)}
        {{
            self.{_FlowBuilderProp}.{_Do}(func);
            return new {_Holder}<{GenericTs(n)}>(self.{_FlowBuilderProp});
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
                res += $"            {_FlowBuilderProp}.{_Set}(t{i + 1});" + (i != n-1?Environment.NewLine:"");
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

