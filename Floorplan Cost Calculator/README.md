# Project - Floorplan Cost Calculator

A commandline c# calculator that calculates area of a floorplan and returns its cost. This application:

- Accepts the number of rectangles, circles and triangles in a floorplan and their associated sizes in meters to calculate the total area in square meters.
- Accepts a user-defined cost per unit area when calculating the costs.
- Accepts a user-defined currency and calculates the cost in that currency.


## Usage

1. Divide up the floorplan into rectangles, triangles and circles.
2. Start the programme using `dotnet run`.
3. Define your area in the following input format when prompted: `R(x1,y1) R(x2,y2) ... T(b1, h1) T(b2,h2) ... C(r1) C(r2)`.
4. Define your currency.
5. Define the price of the property per square meter.

## Application Input Format

The command in step #3 is broken down as follows: 
- `R(x, y)` indicates a rectangle with edge sizes of `x` and `y`.
- `T(b, h)` indicates a triangle with the base size of `b` and height of `h`.
- `C(r)` indicates a circle with the radius size of `r`.

## Sample Output

```
Starting Area Calculator...:
How many rectangles (R), Trianges (T) and Circles (C) does your area have and what are the sizes of each?
Input your answer in the following format: R(x1,y1) R(x2,y2) ... T(b1, h1) T(b2,h2) ... C(r1) C(r2)
Please note all units shall be in meters.

R(10, 10) T(10, 4) C(5) R(5, 5)

The total area of your floorplan is 223.5m^2.

What currency would you like to use to calculate the total cost of the property? [USD/GBP/..]  GBP
What is the price of the property per square meter?  95

The total cost of your floorplan with the area of 223.5m^2 is 21232.5 GBP.
```
