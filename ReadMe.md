# Function Graph

Function Graph is a library that takes a set algorithms and wires them up together in to a single composite algorithm. 

For example, take a composite algorithm that makes enchiladas. It naturally breaks down in to sub algorithms: chop onions, make the sauce, grate the cheese, etc.

![Enchilada Algorithm](https://raw.github.com/Prototypist1/FunctionGraph/master/FunctionGraph.sln)

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
        .Run(oil, spices, flour, broth, tortillas, cheese, onion)
}
```

So, a few less characters, a little less mental strain and slightly more readable code. At the cost of a little preformance and a little black magic.