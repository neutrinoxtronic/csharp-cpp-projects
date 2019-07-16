# Project - Floorplan Cost Calculator

A commandline c# calculator that calculates area of a floorplan and returns its cost. This application:

- Accepts the number of rectangles, ellipses and triangles in a floorplan and their associated sizes in meters to calculate the total area in square meters.
- Accepts a user-defined cost per unit area when calculating the costs.
- Accepts a user-defined currency and calculates the cost in that currency.

> Note: This programme uses C#'s Regex Engine (**regular expressions**) to parse the input command.

## Usage

1. Divide up the floorplan into rectangles, triangles and ellipses(or circles).
2. `cd` into the `Floorplan Cost Calculator` folder.
3. Create a new console dotnet project using `dotnet new console`. Make sure you have the latest version of `.net` installed.
4. Delete the default entry file `Program.cs`.
5. Start the programme in your terminal using `dotnet run`.
6. Define your area in the following input format when prompted: 

`R(x1,y1) -R(x2,y2) ... T(b1, h1) -T(b2,h2) ... E(r1, r1) -E(r2, r2)`.

7. Define your currency.
8. Define the price of the property per square meter.

## Application Input Format

The command in step #3 is broken down as follows:

- `R(x, y)` calculates an area of a rectangle with edge sizes of `x` and `y`, then adds it to the total area.
- `T(b, h)` calculates an area of a triangle with the base size of `b` and height of `h`, then adds it to the total area.
- `E(r1, r2)` calculates an area of an ellipse with the radii size of `r1` and `r2`, then adds it to the total area.
- `-` indicates substraction of the calculated area from the total area.

> Note: If `r1=r2`, the ellipse becomes a circle.

## Sample Output

```
$ dotnet run

Starting Area Calculator...

How many rectangles (R), Trianges (T) and Ellipses (E) does your area have and what are the sizes of each?
Input your answer in the following format: R(x1,y1) -R(x2,y2) ... T(b1, h1) -T(b2,h2) ... E(r1, r1) -E(r2, r2)
Please note all units shall be in meters.

> E(2,3) E(3,3) R(5, 10) T(10, 5)

The total area of your floorplan is 122.12m^2.

Would you like to calculate the associated costs as well? [y/n]
> y

What currency would you like to use to calculate the total cost of the property? [USD/GBP/..]
> GBP

What is the price of the property per square meter?
> 50

The total cost of your floorplan with the area of 122.12m^2 is 6106 GBP.

Would you like to calculate another area? [y/n]
> n
```

```
$ dotnet run

Starting Area Calculator...

How many rectangles (R), Trianges (T) and Ellipses (E) does your area have and what are the sizes of each?
Input your answer in the following format: R(x1,y1) -R(x2,y2) ... T(b1, h1) -T(b2,h2) ... E(r1, r1) -E(r2, r2)
Please note all units shall be in meters.

> R(2,3) -R(2,1)

The total area of your floorplan is 4m^2.

Would you like to calculate the associated costs as well? [y/n]

What currency would you like to use to calculate the total cost of the property? [USD/GBP/..]
> USD

What is the price of the property per square meter?
> 78

The total cost of your floorplan with the area of 4m^2 is 312 USD.

Would you like to calculate another area? [y/n]
> y

Starting Area Calculator...

How many rectangles (R), Trianges (T) and Ellipses (E) does your area have and what are the sizes of each?
Input your answer in the following format: R(x1,y1) -R(x2,y2) ... T(b1, h1) -T(b2,h2) ... E(r1, r1) -E(r2, r2)
Please note all units shall be in meters.

> E(3,4)

The total area of your floorplan is 37.7m^2.

Would you like to calculate the associated costs as well? [y/n]
> N

Would you like to calculate another area? [y/n]
> N 
```
