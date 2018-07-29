# About

*Function Graph* is a library that takes a set of algorithms and wires them together in to a single composite algorithm. 

For example, say your sub algorithms are chop onions, make sauce, grate cheese, brown tortillas, assemble, bake, and garnish, and your composite algorithm is making enchiladas. 

![Enchilada Algorithm](https://raw.githubusercontent.com/Prototypist1/FunctionGraph/master/EnchiladaAlgorithm.png)

Explicitly composed the code might look like this:

```C#
public Enchilada MakeEnchilada(Oil oil, Spices spices, Flour flour, Broth broth, Tortillas tortillas, Cheese cheese, Onion onion){
    var sauce = Mix(oil, spices, flour, borth);
    var browned = Fry(oil, tortillas);
    var grated = Grate(cheese);
    var assembled = Assemble(sauce, browned, grated);
    var almost = Bake(assembled);
    var chopped = Chop(onion);
    return Garnish(almost, sauce, chopped);
}
```

The thing is, given the sub-algorithms it is pretty easy to automatically wire them togther using their inputs and output types. An algorithm can determine that, the result of `Assemble` must be fed in to `Bake` because `Bake` requires an `Assembled` and that is what `Assemble` produces. This generalizes, just go through all the the sub-algorthms in order. For each of the sub-algorithm's inputs find the youngest item of matching type that was output from one of the pervious sub-algorithms or provided as a parameter. This is exactly what function graph does.

Using Function Graph the same code looks like:

```C#
public Enchilada MakeEnchilada(Oil oil, Spices spices, Flour flour, Broth broth, Tortillas tortillas, Cheese cheese, Onion onion){
    return new FlowBuilder()
        .Then(Mix)
        .Then(Fry)
        .Then(Grate)
        .Then(Assemble)
        .Then(Bake)
        .Then(Chop)
        .Then(Garnish)
        .Run(oil, spices, flour, broth, tortillas, cheese, onion);
}
```

So, a few less characters, a little less mental strain and slightly more readable code. At the cost of a some preformance, and a little less control over your code.

## Features

### Parallelism 

Function Graph can automatically parallelize your graph. Much like automatic wiring, automatic parallization is pretty simple. Each sub-algorithm is run as soon as all the sub-algorithms that produce it's inputs are finished.

To make a flow parallel, just use the `RunInParallel` method. 

```C#
public Enchilada MakeEnchilada(Oil oil, Spices spices, Flour flour, Broth broth, Tortillas tortillas, Cheese cheese, Onion onion){
    return new FlowBuilder()
        .RunInParallel()
        .Then(Mix)
        .Then(Fry)
        .Then(Grate)
        .Then(Assemble)
        .Then(Bake)
        .Then(Chop)
        .Then(Garnish)
        .Run(oil, spices, flour, broth, tortillas, cheese, onion);
}
```

### Dependency Injection Support

Function Graph, pairs very well with dependency injection. It allows you not worry about feeding your graph with the right inputs. Instead the graph just pulls whatever it needs from the container. 

The container is used as a fallback when wiring functions together. Required inputs that are not produced by any sub algorithms or included as parameters are pulled from the container.

To add a container, wrap your container of choice in the `IContainer` interface and pass it in with the `Container` method.

```C#
public Enchilada MakeEnchilada(IContainer pantry){
    return new FlowBuilder()
        .Container(pantry)
        .Then(Mix)
        .Then(Fry)
        .Then(Grate)
        .Then(Assemble)
        .Then(Bake)
        .Then(Chop)
        .Then(Garnish)
        .Run();
}
```

### Multiple Returns

Function Graph uses tuples to handle multiple returns. `PackedThen` takes a function that return mutliple items 'packed' as a tuple. All the returned tuple's members are avalible to subiquent steps, but the tuple as a whole is not. (if you want the tuple to be avaible, use `Then`.) 

To return multiple times from the flow, add generic parameters to `Run`. The youngest items of the types requested are returned in a tuple.

```C#
var (name, value) = new FlowBuilder()
	.PackedThen(() => ("Time", 1282368345))
	.Run<string, int>();
```
### Strong Typing

Function Graph largely abandons strong typing. I have made an attempt to add it back using generics and extensions methods. The "strongly typed" form of `FlowBuilder` is `Holder<...items...>`, likewise, `Then` is replaced by `Add` and `Update`. A `Holder`s simulate strong typing using extension methods, a `Holder` only has extension methods for functions whose inputs it contains. 

```C#
var year = new Holder()
	.Add(()=>5)                             // now a IHolder<int>
	.Update((int i) => i +1)                // still IHolder<int>
	.Add(()=>"177")                         // now a IHolder<int,string>
	.Update((string s, int i) => s + i)     // still IHolder<int,string>
	.Run<string>();
}
```

#### Strong Typing Limitations

- No support for containers. 
- `Add` and `Update` must be specifically specified
- Can only track up to 12 items



