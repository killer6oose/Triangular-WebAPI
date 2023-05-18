# Triangular

My friend received this as a technical test to be developed as a C# Web API endpoint with an optional JavaScript front end and I fancied having a crack. 

This is my first dive into C# and the .NET environment.

## Tech Used

### Backend

* C#
* .NET Core 2.2
* NuGet

### Frontend

* Node & NPM
* Laravel Mix
* Vue
* SCSS

### Testing

* XUnit
* Moq

## The Test

1.A - The task, calculate the triangle coordinates for an image with right triangles such that for a given
row (A-F) and column (1-12) you can produce any of the triangles in the layout below:

![Grid](https://i.ibb.co/YWFhGKP/Triangular-1.png)

Each non-hypotenuse side of the triangle is as follows:

![Triangle Sizes](https://i.ibb.co/dLHckcJ/Triangular-2.png)

1.B - Lastly, given the vertex coordinates, calculate the row and column for the triangle:

![Vertices](https://i.ibb.co/72P5S1x/Triangular-3.png)