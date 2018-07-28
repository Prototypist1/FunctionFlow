# About

Function Graph is a library that takes a set algorithms and wires them up together in to a single composite algorithm. 

For example, take a composite algorithm that makes enchiladas. It naturally breaks down in to sub algorithms: chop onions, make the sauce, grate the cheese, etc.

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

The thing is, given the sub-algorithms it is pretty easy to automatically wire things togther using their inputs and output types. Just go through all the the sub-algorthms in order. For each of the sub-algorithm's inputs find the youngest item of matching type that was output from one of the pervious sub-algorithms or provided as a parameter. This is exactly what function graph does.

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

So, a few less characters, a little less mental strain and slightly more readable code. At the cost of a some preformance and a little black magic.

## Features

### Parallelism 

Function Graph can automatically parallelize your graph. Much like automatic wiring, automatic parallize is pretty simple. Each sub-algorithm is run as soon as all the sub-algorithms that produce it's inputs have ran.

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

Function Graph, pairs very well with dependency injection. A `FlowBuilder` can be used as a fallback when wiring functions together. the container will be used it to find inputs that are not produced by any sub algorithms or included in the input.

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

To return multiple times from the flow, add generic parameters to `Run`.


```C#
var (name, value) = new FlowBuilder()
	.PackedThen(() => ("Time", 1282368345))
	.Run<string, int>();`
```
### Strong Typing

Function Graph largely abandons strong typing. I have made an attempt to add it back using generics and extensions methods. When using the strong typing a `Holder<...items...>` replaces the `FlowBuilder` and `Add`, `Update` replace `Then`. A `Holder` is built using extension methods, a `Holder` only has extension methods for functions whose inputs it contains. 

```C#
var year = new Holder()
	.Add(()=>5)
	.Update((int i) => i +1)
	.Add(()=>"177")
	.Update((string s, int i) => s + i)
	.FlowBuilder.Run<string>()
}
```

#### Strong Typing Limitations

- Plays poorly with containers. 
- `Add` and `Update` must be specifically specified
- Can only track up to 12 items
- 



