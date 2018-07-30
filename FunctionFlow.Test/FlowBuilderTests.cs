
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;

namespace Prototypist.FunctionFlow.Test
{
    public class FlowBuilderTests
    {

        [Fact]
        public void ContainerTest()
        {
            var container = new TestConainer();
            container.Dictionary[typeof(int)] = 5;

            var res = new FlowBuilder().Container(container).Run<int>();

            Assert.Equal(5, res);
        }

        [Fact]
        public void BlanketTest()
        {
            var finalInt = 0;
            var finalStr = "";

            int inc(int x) => x + 1;
            string incStr(string x) => x + "1";

            new FlowBuilder()
                .Then(() => 2)
                .Then((int i) => i + "")
                .Then<int, int>(inc)
                .Then<int, int>(inc)
                .Then<int, int>(inc)
                .Then<int, int>(inc)
                .Then<string, string>(incStr)
                .Then<string, string>(incStr)
                .Then<string, string>(incStr)
                .Then<string, string>(incStr)
                .Then((int x) => finalInt = x)
                .Then((string x) => finalStr = x)
                .Run();

            Assert.Equal(6, finalInt);
            Assert.Equal("21111", finalStr);
        }

        [Fact]
        public void MultiReturn()
        {

            var (finalInt, finalStr) = new FlowBuilder()
                .Then(() => 2)
                .Then((int i) => i + "")
                .Then((int x) => x + 1)
                .Then((int x) => x + 1)
                .Then((int x) => x + 1)
                .Then((int x) => x + 1)
                .Then((string x) => x + "1")
                .Then((string x) => x + "1")
                .Then((string x) => x + "1")
                .Then((string x) => x + "1")
                .Run<int, string>();

            Assert.Equal(6, finalInt);
            Assert.Equal("21111", finalStr);
        }

        [Fact]
        public void ParameterTest()
        {
            var finalInt = 0;

            new FlowBuilder().Then<int, int>(x => x + 1).Then<int>(x => finalInt = x).Run(10);

            Assert.Equal(11, finalInt);
        }

        [Fact]
        public void PassThroughTest()
        {
            Assert.Equal(10, new FlowBuilder().Run<int>(10));
        }

        [Fact]
        public void SimpleTest()
        {
            Assert.Equal(1, new FlowBuilder().Then(() => 1).Run<int>());
        }

        [Fact]
        public void ReturnTest()
        {
            var res = new FlowBuilder().Then<int, int>(x =>
             x + 1
            ).Run<int>(10);

            Assert.Equal(11, res);
        }

        [Fact]
        public void PackedThen()
        {
            var (name, value) = new FlowBuilder()
                .PackedThen(() => ("Time", 1282368345))
                .Run<string, int>();

            Assert.Equal("Time", name);
            Assert.Equal(1282368345, value);
        }

        [Fact]
        public void SetTest()
        {
            var res = new FlowBuilder().Set(5).Run<int>();

            Assert.Equal(5, res);
        }

        [Fact]
        public void ReturnString()
        {

            var res = new FlowBuilder().Then(() => "test").Run<string>();

            Assert.Equal("test", res);
        }

        [Fact]
        public void SourceTest()
        {
            var res = new FlowBuilder().Source(() => 5 + "").Run<string>(5);

            Assert.Equal("5", res);
        }

        [Fact]
        public void UnpackTest()
        {
            var (myInt, myStr) = new FlowBuilder().PackedThen(() => (2, "test")).Run<int, string>();

            Assert.Equal(2, myInt);
            Assert.Equal("test", myStr);

        }

        [Fact]
        public void CompileFuncTest()
        {
            var addOne = new FlowBuilder().Then<int, int>(x => x + 1).Build<Func<int, int>>();

            Assert.Equal(11, addOne(10));
            Assert.Equal(0, addOne(-1));
        }

        [Fact]
        public void CompileActionTest()
        {
            var finalInt = 0;

            var action = new FlowBuilder().Then<int>(x => finalInt = x).Build<Action<int>>();

            action(10);
            Assert.Equal(10, finalInt);
            action(0);
            Assert.Equal(0, finalInt);
        }

        [Fact]
        public void ParallelCompileActionTest()
        {
            var function = new FlowBuilder()
                .Then((int x) => x + 1)
                .Then((int x) => x + 1)
                .Then((int x) => x + 1)
                .Then((int x) => x + 1).Build<Func<int, int>>();

            Parallel.For(0, 1000, (i) =>
            {
                Assert.Equal(i + 4, function(i));
            });
        }

        [Fact]
        public void OutputOrdering()
        {
            var flow = new FlowBuilder().RunInParallel();
            for (int j = 0; j < 100; j++)
            {
                var i = j;
                flow.Then(() => i);
            }
            Assert.Equal(99, flow.Run<int>());
        }

        [Fact]
        public void ParallelTest()
        {
            void wait() => Task.Delay(100).Wait();

            var start = DateTime.Now.Ticks;

            new FlowBuilder()
                .RunInParallel()
                .Then(wait)
                .Then(wait)
                .Then(wait)
                .Then(wait)
                .Run();

            var end = DateTime.Now.Ticks;

            Assert.InRange(TimeSpan.FromTicks(end - start), TimeSpan.FromSeconds(.1), TimeSpan.FromSeconds(.2));

        }

        [Fact]
        public void ParallelPairs() {

            Func<int,int> waitInt= i => {
                Task.Delay(100).Wait();
                return i + 1;
            };

            Func<string, string> waitString = s => {
                Task.Delay(100).Wait();
                return s + "1";
            };

            var start = DateTime.Now.Ticks;

            var (resInt,resStr)= new FlowBuilder()
                .RunInParallel()
                .Then(waitInt)
                .Then(waitInt)
                .Then(waitInt)
                .Then(waitString)
                .Then(waitString)
                .Then(waitString)
                .Run<int,string>(0,"");

            var end = DateTime.Now.Ticks;

            Assert.Equal(3, resInt);
            Assert.Equal("111", resStr);
            Assert.InRange(TimeSpan.FromTicks(end - start), TimeSpan.FromSeconds(.3), TimeSpan.FromSeconds(.4));
        }

        [Fact]
        public void ParallelPairsLongShort()
        {

            Func<int, int> waitIntLong = i => {
                Task.Delay(100).Wait();
                return i + 1;
            };

            Func<int, int> waitIntShort = i => {
                return i + 1;
            };

            Func<string, string> waitStringLong = s => {
                Task.Delay(100).Wait();
                return s + "1";
            };

            Func<string, string> waitStringShort = i => {
                return i + "1";
            };

            var start = DateTime.Now.Ticks;

            var (resInt, resStr) = new FlowBuilder()
                .RunInParallel()
                .Then(waitIntLong)
                .Then(waitIntShort)
                .Then(waitIntLong)
                .Then(waitIntShort)
                .Then(waitStringShort)
                .Then(waitStringLong)
                .Then(waitStringShort)
                .Then(waitStringLong)
                .Run<int, string>(0, "");

            var end = DateTime.Now.Ticks;

            Assert.Equal(4, resInt);
            Assert.Equal("1111", resStr);
            Assert.InRange(TimeSpan.FromTicks(end - start), TimeSpan.FromSeconds(.2), TimeSpan.FromSeconds(.3));
        }

        [Fact]
        public void NoParallelTest()
        {
            void wait() => Task.Delay(100).Wait();

            var start = DateTime.Now.Ticks;

            new FlowBuilder()
                .Then(wait)
                .Then(wait)
                .Then(wait)
                .Run();

            var end = DateTime.Now.Ticks;

            Assert.InRange(TimeSpan.FromTicks(end - start), TimeSpan.FromSeconds(.2), TimeSpan.FromSeconds(.4));

        }



    }


    #region Help

    internal class TestConainer : IContainer
    {
        public Dictionary<Type, object> Dictionary = new Dictionary<Type, object>();
        public T Get<T>()
        {
            return (T)Dictionary[typeof(T)];
        }
    }

    #endregion

}
