using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

// --------------------------------------------------------------------------------------

/*
A+B
It will be necessary to calculate the sum of integers A and B.

*/

// string A = Console.ReadLine();
// int firstNumber = Convert.ToInt32(A);

// string B = Console.ReadLine();
// int secondNumber = Convert.ToInt32(B);

// Console.WriteLine(GetSumTwoNumbers(firstNumber,secondNumber));

// static int GetSumTwoNumbers(int firstNumber,int secondNumber)
// {
//     return firstNumber + secondNumber;
// }

// --------------------------------------------------------------------------------------

/*
A rectangle:
The sides a and b of the rectangle are given. find its perimeter

*/
// Console.WriteLine("Enter first side of rectangle : ");
// string userInputsideA = Console.ReadLine();
// int sideA = Convert.ToInt32(userInputsideA);

// Console.WriteLine("Enter second side of rectangle : ");
// string userInputsideB = Console.ReadLine();
// int sideB = Convert.ToInt32(userInputsideB);

// Console.WriteLine($"Result : {GetParameterRectangle(sideA,sideB)}");

// static int GetParameterRectangle(int sideA,int sideB)
// {
//     return (sideA + sideB) * 2;
// }

// --------------------------------------------------------------------------------------

/*
A rectangle:
The sides a and b of the rectangle are given. find its surface area

*/
// Console.WriteLine("Enter first side of rectangle : ");
// string userInputsideA = Console.ReadLine();
// int sideA = Convert.ToInt32(userInputsideA);

// Console.WriteLine("Enter second side of rectangle : ");
// string userInputsideB = Console.ReadLine();
// int sideB = Convert.ToInt32(userInputsideB);

// Console.WriteLine($"Result : {GetSurfaceRectangle(sideA,sideB)}");

// static int GetSurfaceRectangle(int sideA,int sideB)
// {
//     return sideA * sideB;
// }

// --------------------------------------------------------------------------------------

/*
Determine the length of the circle given its diameter d

*/

// const double PI = 3.14;

// Console.WriteLine("Enter the diameter of circle");
// string userInputDiameter = Console.ReadLine();
// double diameter = Convert.ToDouble(userInputDiameter);

// Console.WriteLine($"result :{ GetLengthCircle(diameter)}");

// static double GetLengthCircle(double diameter)
// {
//     return PI * diameter;
// }

// --------------------------------------------------------------------------------------

/*
Find the volume and total surface area of ​​a cube given side a

*/

// Console.WriteLine("Enter the side of cube :");

// string userInputSideA = Console.ReadLine();
// double sideA = Convert.ToDouble(userInputSideA);

// Console.WriteLine($"The Volume : {GetVolume(sideA)}");
// Console.WriteLine($"The total surface area : {GetTotalSurfaceArea(sideA)}");

// static double GetVolume(double sideA)
// {
//     return Math.Pow(sideA,3);
// }

// static double GetTotalSurfaceArea(double sideA)
// {
//     return 6 * (sideA * sideA);
// }

// --------------------------------------------------------------------------------------

/*

The sides of a parallelepiped are a, b, c, given.
 Determine its volume and total surface area

*/

// Console.WriteLine("Enter the first roof of the parallelepiped: ");
// string userInputParalOne = Console.ReadLine();
// int sideParalOne = Convert.ToInt32(userInputParalOne);

// Console.WriteLine("Enter the second roof of the parallelepiped: ");
// string userInputParalTwo = Console.ReadLine();
// int sideParalTwo = Convert.ToInt32(userInputParalTwo);

// Console.WriteLine("Enter the tree roof of the parallelepiped: ");
// string userInputParalThree = Console.ReadLine();
// int sideParalThree = Convert.ToInt32(userInputParalThree);

// Console.WriteLine($"Volume parallelepipe: {GetVolumeParallelepiped(sideParalOne, sideParalTwo, sideParalThree)}");
// Console.WriteLine($"Full surface parallelepipe: {GetFullSurfaceParallelepiped(sideParalOne, sideParalTwo, sideParalThree)}");


// static int GetVolumeParallelepiped(int sideParalOne, int sideParalTwo, int sideParalThree)
// {
//     return sideParalOne * sideParalTwo * sideParalThree;
// }

// static int GetFullSurfaceParallelepiped(int sideParalOne, int sideParalTwo, int sideParalThree) 
// {
//     return 2 * (sideParalOne * sideParalTwo + sideParalTwo * sideParalThree + sideParalOne * sideParalThree); 
// }

// --------------------------------------------------------------------------------------

/*
Check and determine the radius of the circle
*/

// const double PI = 3.14;

// Console.WriteLine("enter the radius of the circle");
// string userInput = Console.ReadLine();
// double radius = Convert.ToDouble(userInput);

// Console.WriteLine($"the Length of the Circle {GetLengthCircle(radius)}");
// Console.WriteLine($"the surface of the Circle {GetSurfaceCircle(radius)}");

// static double GetLengthCircle(double radius)

// {
//     return 2*PI*radius;
// }

// static double GetSurfaceCircle(double radius)
// {
//     return PI*(radius*radius);
// }

// --------------------------------------------------------------------------------------

/*
Determine the arithmetic mean of given numbers A and B
*/
Console.WriteLine("Enter the first number : ");
string userInputOne = Console.ReadLine();
double firstNumber = Convert.ToDouble(userInputOne);

Console.WriteLine("Enter the second number : ");
string userInputTwo = Console.ReadLine();
double secondNumber = Convert.ToDouble(userInputTwo);

Console.WriteLine($"the arithmetic mean of given numbers A and B : {GetArithmeticMean(firstNumber,secondNumber)}");

static double GetArithmeticMean(double firstNumber,double secondNumber)
{
    return (firstNumber+secondNumber)/2;
}