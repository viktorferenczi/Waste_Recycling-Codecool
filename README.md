# The Story

It's 2020.
The mentors of Codecool Phnom Pen (capital of Cambodia) are fed up, that despite the strict house rules, no one cares about collecting the waste in a selective way in the school.
They decided to make an automated dustbin, which can detect different types of garbage, and can put them to different containers automatically.

Mentors at Codecool usually have a whole bunch of things to do, and they aren't exceptions either, so they don't have time to implement the dustbin's software.
Luckily it's internal computer is capable of running Java programs...

Have you found out yet???
YES, it's your job to implement it in an Object-Oriented way!

# The task

You're required to implement the following classes

1. `Garbage`
1. `PlasticGarbage`
1. `PaperGarbage`
1. `Dustbin`
1. `Program` (this one is special, read on)

and make the tests pass!

Run the program with `dotnet run` and the tests with `dotnet test`.

**Note**: don't touch the test files!

## The playground, `Program`

In the `Program` class you need to write code the serves as a "movie script" for a little story.

Think of the contents of the main method as series of things (statements) that happen over time in the life of an ordinary dustbin.

A short script could be ...

```
Workers in the cantine

They leave three rotten tomatoes and a plastic milk jug on the floor beside the dustbin.
They leave the scene.

Cleaning lady arrives

She strolls into the cantine and she's furious as she sees this mess.
She throws the three tomatoes -- one-by-one -- into the dustbin.
Picks up the plastic jug.
She checks if it cleans (it's not obviously!).
She cleans it, then throws that too into the bin.
She clears her throat, empties the dustbin.
Finally she leaves the scene.
```

A possible _translation_ of this to code could look like as follows.

**Note**: We only need to create objects that necessary for us for the purposes of the assignment (no need for a cleaning lady class or anything like that).

```
// We create the garbage objects that appear in the script.
Garbage[] rottenTomatoes = new Garbage[3];
for (int i = 0; i < 3; i++)
{
    rottenTomatoes[i] = new Garbage("rotten tomato nr." + (i + 1));
}

// Then we create the plastic milk jug.
PlasticGarbage milkJug = new PlasticGarbage("plastic milk jug", false);

/*
    Note that on the leftside the type is Garbage, but on the right it's PlasticGarbage.
    We can do this, because PlasticGarbage extends Garbage, which in simple terms
    means that every plastic garbage is garbage, but not every garbage is plastic garbage.
*/

// We create the dustbin where the garbages will be thrown.
Dustbin dustbin = new Dustbin("Jenny's handsome");

// Showing the contents of the dustbin for the sake of seeing something on the terminal :)
dustbin.DisplayContents();

// Then the cleaning lady comes and does her thing.
for (int i = 0; i < 3; i++)
{
    /*
        She throws every piece of rotten tomato in the dustbin.
        This doesn't mean the tomato Garbage instance will be destroyed or anything,
        they are just now inside of the Dustbin object.
    */
    dustbin.ThrowOutGarbage(rottenTomatoes[i]);
}

// Then she cleans the milk jug.
if (!milkJug.Cleaned)
{
    milkJug.Clean();
}

// Throws out the milk jug.
dustbin.ThrowOutGarbage(milkJug);

// Empties the contents.
dustbin.EmptyContents();

// Displaying what's in there.
dustbin.DisplayContents();

// Aaaaaaand the scene fades out!
```

Your goal is to _play around_ and create something like this.
Two rules apply

* create lots of instances, pass them around, see what happens, see what compiles, what doesn't,
* whatever you create it should compile and you should be able to run it :)

## Specification

### `Garbage`

This is the file containing a regular garbage's logic.

#### Properties

* `string Name`: stores the custom name of the garbage object (e.g. `"rotten tomatoes"`)

#### Constructors

* `Garbage(string name)`: the class has a single constructor that takes the `name` of the garbage to be created.

#### Methods

### `PaperGarbage`

This is the file containing the logic of a garbage made of paper.
The `PaperGarbage` class inherits the logic of the `Garbage` class.

#### Properties

* `string Name`: stores the name of the garbage (should be inherited from the `Garbage`)
* `bool Squeezed`: stores if the garbage is squeezed (`true`) or not (`false`)

#### Constructors

* `PaperGarbage(string name, boolean squeezed)`: the class has a single constructor that takes two parameters `name` (the name of the paper garbage
and `squeezed` (`true` if the garbage is squeezed from the start or `false` otherwise).

#### Methods

##### `void Squeeze()`

* when called it sets the object's `Squeezed` field to `true`

### `PlasticGarbage`

This is the file containing the logic of a garbage made of plastic.
`PlasticGarbage` class inherits the logic of the `Garbage` class.

#### Properties

* `string Name`: stores the name of the garbage (should be inherited from the `Garbage`)
* `bool Cleaned`: stores if the garbage is clean (`true`) or not (`false`)

#### Constructors

* `PlasticGarbage(string name, bool cleaned)`: the class has a single constructor that takes two parameters `name` (the name of the plastic garbage
and `cleaned` (`true` if the garbage is clean from the start or `false` otherwise).

#### Methods

##### `void Clean()`

* when called, it sets the object's `Cleaned` attribute to `true`

### `Dustbin`

This file should contain all the logic, what our automated dustbin can do.

### Properties

* `string Color`: stores the dustbin's color
* `PaperGarbage[] PaperContent`: an array, stores `PaperGarbage` instances
* `PlasticGarbage[] PlasticContent`: an array, stores `PlasticGarbage` instances
* `Garbage[] HouseWasteContent`: an array, stores `Garbage` instances

#### Methods

##### `void DisplayContents()`

If it's called it prints all the contents of the dustbin in the following format

```
Red Dustbin!

House waste content: 2 item(s)

    Rotten tomato
    Wooden leg

Paper content: 0 item(s)

Plastic content: 1 item(s)

    Milk jug
```

The first line is the dustbin's `color + " Dustbin!"`.

##### `void ThrowOutGarbage(Garbage garbage)`

* Receives an argument.
* If the argument is an instance of the `PlasticGarbage` class, and it's clean, then it puts that into the `PlasticContent` array.
* If the `PlasticGarbage` instance is not clean, it raises a `DustbinContentException`.
* If the argument is an intance of the `PaperGarbage` class, and it's squeezed, then it puts that into the `PaperContent` array.
* If the `PaperGarbage` instance is not squeezed, it raises a `DustbinContentException`.
* If the argument is an instance of the `Garbage` class (but not a `PaperGarbage` or a `PlasticGarbage`), then it puts that into the `HouseWasteContent` array.
* If the argument is not an instance of the classes above, it raises a `DustbinContentException`.

##### `void EmptyContents()`

* If it's called, `PlasticContent`, `PaperContent` and the `HouseWasteContent` array gets emptied.
