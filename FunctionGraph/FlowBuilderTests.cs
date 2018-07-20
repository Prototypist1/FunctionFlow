
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Prototypist.FunctionGraph
{
    public class FlowBuilderTests
    {

        [Fact]
        public void ContainerTest()
        {
            var container = new TestConainer();
            container.Dictionary[typeof(int)] = 5;

            var res = new FlowBuilder().SetContainer(container).Run<int>();

            Assert.Equal(5, res);
        }
        
        [Fact]
        public void BlanketTest()
        {
            var finalInt = 0;
            var finalStr = "";
            
            Func<int, int> inc = x => x + 1;
            Func<string, string> incStr = x => x + "1";
            
            new FlowBuilder()
                .Then(() => 2)
                .Then((int i) => i + "")
                .Then(inc)
                .Then(inc)
                .Then(inc)
                .Then(inc)
                .Then(incStr)
                .Then(incStr)
                .Then(incStr)
                .Then(incStr)
                .Then((int x) => finalInt =x)
                .Then((string x) => finalStr =x)
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
            Action<int> setInt = x => finalInt = x;
            Func<int, int> inc = x => x + 1;

            Action<int> getFinalInt = x => setInt(x);
            new FlowBuilder().Then(inc).Then(getFinalInt).Run(10);

            Assert.Equal(11, finalInt);
        }

        [Fact]
        public void ReturnTest()
        {
            Func<int, int> inc = x => x + 1;

            var res = new FlowBuilder().Then(inc).Run<int>(10);

            Assert.Equal(11, res);
        }

        [Fact]
        public void SetTest()
        {
            var res = new FlowBuilder().SetParameter(5).Run<int>();

            Assert.Equal(5, res);
        }

        [Fact]
        public void ReturnString()
        {
            Func<string> test = () => "test";
            var res = new FlowBuilder().Then(test).Run<string>();

            Assert.Equal("test", res);
        }

        [Fact]
        public void SourceTest()
        {
            var res = new FlowBuilder().SetParameterSource<Func<int,string>>(x=>5+"").Run<string>(5);

            Assert.Equal("5", res);
        }

        [Fact]
        public void UnpackTest()
        {
            Func<(int, string)> getPair = () => (2, "test");

            var (myInt, myStr) = new FlowBuilder().ThenUnpack(getPair).Run<int, string>();

            Assert.Equal(2, myInt);
            Assert.Equal("test", myStr);

        }

        [Fact]
        public void CompileFuncTest()
        {
            Func<int, int> inc = x => x + 1;

            var addOne = new FlowBuilder().Then(inc).Build<Func<int, int>>();

            Assert.Equal(11, addOne(10));
            Assert.Equal(0, addOne(-1));
        }

        [Fact]
        public void CompileActionTest()
        {
            var finalInt = 0;
            Action<int> setInt = x => finalInt = x;

            Action<int> getFinalInt = x => setInt(x);
            var action = new FlowBuilder().Then(getFinalInt).Build<Action<int>>();

            action(10);
            Assert.Equal(10, finalInt);
            action(0);
            Assert.Equal(0, finalInt);
        }

        [Fact]
        public void ParallelTest()
        {
            Action wait = () => Task.Delay(100).Wait();

            var start = DateTime.Now.Ticks;

            new FlowBuilder()
                .Then(wait)
                .Then(wait)
                .Then(wait)
                .Then(wait)
                .Run();

            var end = DateTime.Now.Ticks;

            Assert.InRange(TimeSpan.FromTicks(end - start), TimeSpan.FromSeconds(.1), TimeSpan.FromSeconds(.2));

        }

        [Fact]
        public void NoParallelTest()
        {
            Action wait = () => Task.Delay(100).Wait();

            var start = DateTime.Now.Ticks;

            new FlowBuilder()
                .RunInSeries()
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
