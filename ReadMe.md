# About

*Function Flow* is a library that takes a set of algorithms and wires them together in to a single composite algorithm. 

For example, say your sub algorithms are: chop onions, mix sauce, grate cheese, fry tortillas, assemble, bake, and garnish, and your composite algorithm is making enchiladas. 

![Enchilada Algorithm](https://raw.githubusercontent.com/Prototypist1/FunctionGraph/master/EnchiladaAlgorithm.png)

Explicitly composed, the code might look like this:

```C#
public Enchilada MakeEnchilada(Oil oil, Spices spices, Flour flour, Broth broth, Tortillas tortillas, Cheese cheese, Onion onion){
    var sauce = Mix(oil, spices, flour, broth);
    var browned = Fry(oil, tortillas);
    var grated = Grate(cheese);
    var assembled = Assemble(sauce, browned, grated);
    var almost = Bake(assembled);
    var chopped = Chop(onion);
    return Garnish(almost, sauce, chopped);
}
```

The thing is, it is pretty easy to wire the sub-algorithms together by matching their input types to output types. An algorithm can determine that the result of `Assemble` must be fed into `Bake` because `Bake` requires an `Assembled` and that is what `Assemble` produces. This generalizes. Run the sub-algorithms in order. For each of the sub-algorithm's inputs, find the youngest item of matching type that was output from one of the previous sub-algorithms or provided as a parameter. This is exactly what Function Flow does.

Using Function Flow the same code looks like:

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

So, fewer characters, a little less mental strain, and slightly more readable code, at the cost of some performance and control.

## Features

### Parallelism 

Function Flow can automatically parallelize your flow. Much like automatic wiring, automatic parallelization is pretty simple. Each sub-algorithm is run as soon as all the sub-algorithms that produce its inputs are finished.

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

Function Flow pairs very well with dependency injection. It allows you to not worry about feeding your flow with the right inputs. Instead, the flow just pulls whatever it needs from the container. 

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

Function Flow uses tuples to handle multiple returns. `PackedThen` takes a function that returns multiple items 'packed' as a tuple. All the returned tuple's members are available to subsequent steps, but the tuple as a whole is not. (If you want the tuple to be available, use `Then`.) 

To return multiple items from the flow, add generic parameters to `Run`. The youngest items of the types requested are returned in a tuple.

```C#
var (name, value) = new FlowBuilder()
    .PackedThen(() => ("Time", 1282368345))
    .Then((string s)=> "Current "+ s)
    .Run<string, int>();
```
### Strong Typing

One of the down sides of function flow is, the flow is not verified at compile time. If one of your steps requires something that is not in the flow you will be blissfully unware until runtime. I have make an attempt to rectify this using generics and extension methods. The "strongly typed" form of `FlowBuilder` is `IStrongFlow<...items...>`. Instead of `Then` it uses `Add` and `Update`. A `StrongFlow` simulates strong typing by only having extension methods for functions whose inputs it contains. For example, `StrongFlow<int,string>` only has extension methods for methods of the form `(int i) => ...`, `(string s) => ...`, `(int i, string s) => ...` and, `(string s, int i)=> ...`.

```C#
var year = new StrongFlow()
    .Add(()=>5)                             // now a IStrongFlow<int>
    .Update((int i) => i +1)                // still IStrongFlow<int>
    .Add(()=>"177")                         // now a IStrongFlow<int,string>
    .Update((string s, int i) => s + i)     // still IStrongFlow<int,string>
    .Run<string>();
}
```

#### Strong Typing Limitations

- No support for containers
- `Add` and `Update` must be specifically specified
- Can only track up to 12 items

