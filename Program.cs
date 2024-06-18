﻿using System;
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

Console.WriteLine("Enter the side of cube :");

string userInputSideA = Console.ReadLine();
double sideA = Convert.ToDouble(userInputSideA);

Console.WriteLine($"The Volume : {GetVolume(sideA)}");
Console.WriteLine($"The total surface area : {GetTotalSurfaceArea(sideA)}");

static double GetVolume(double sideA)
{
    return Math.Pow(sideA,3);
}

static double GetTotalSurfaceArea(double sideA)
{
    return 6 * (sideA * sideA);
}
