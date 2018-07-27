# Function Graph

Function Graph is a library that takes a set algorithms and wires them up together in to a single composite algorithm. 

For example, take a composite algorithm that makes enchiladas. It naturally breaks down in to sub algorithms: chop onions, make the sauce, grate the cheese, etc.

![Enchilada Algorithm](https://raw.githubusercontent.com/Prototypist1/FunctionGraph/master/EnchiladaAlgorithm.png)

The thing is, given the sub-algorithms it is pretty easy to wire things togther using their inputs and output types. 

Explicitly wired the code might look like this:

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

A few less characters, a little less mental strain and slightly more readable code. 


They are a directed graph where nodes are functions and edges are the output of one function used as the input of another. 




To be specific fg builds a delegate the executes collection of delegates.  