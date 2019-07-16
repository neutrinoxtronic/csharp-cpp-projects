# C# and C++ Projects

Collection of small C# and C++ projects such as calculators, applications and experiments

---

## C# Project - Floorplan Cost Calculator

A commandline c# calculator that calculates area of a floorplan and returns its cost. This application:

- Accepts the number of rectangles, ellipses and triangles in a floorplan and their associated sizes in meters to calculate the total area in square meters.
- Accepts a user-defined cost per unit area when calculating the costs.
- Accepts a user-defined currency and calculates the cost in that currency.

> Note: This programme uses C#'s Regex Engine (**regular expressions**) to parse the input command.

## C# Project - Creature Constructor

A command line c# application that prints ascii creatures by constructing their bodies one piece at the time. The body parts of the creatures can be pieced together randomly or be user-defined. If user does not define a body part, a random body part will be assigned to the creature before printing it.

## C++ Project - Quadratic Root Calculator

A command line c++ application that calculates the roots of a quadratic equation.

## C++ Project - Harry Potter Sorting Hat Quiz

A command line c++ application that asks you a few questions to determine the house you belong to if you were to go to Hogwarts.

## C++ Project - Rock Paper Scissors Lizard Spock

A command line C++ application similar to rock paper scissors game but with lizard and spock added in.
See this video from Big Bang Theory for the rules of the game: [Rock Paper Scissors Lizard Spock (Extended Cut) ~ The Big Bang Theory ~](https://www.youtube.com/watch?v=x5Q6-wMx-K8)

## C++ Project - Anducted Man

A hangman-like game in which players must crack a codeword to stop an alien abduction.

## Setup

1. Clone the repository using `git clone https://github.com/Ali-Parandeh/csharp-projects.git`
2. `cd` into each project folder.
3. For C# projects Open the file using Visual Studio and run `dotnet run`.
4. For c++ projects, download and install the g++ compiler from [Mingw.org](http://mingw.org/). Then add it your `PATH` envrionment variable via `control panel > Edit system envrionment variables` window. You can then compile c++ files from command line and run them as executables.
