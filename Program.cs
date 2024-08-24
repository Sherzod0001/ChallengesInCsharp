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

// Console.WriteLine("Enter the first number : ");
// string userInputOne = Console.ReadLine();
// double firstNumber = Convert.ToDouble(userInputOne);

// Console.WriteLine("Enter the second number : ");
// string userInputTwo = Console.ReadLine();
// double secondNumber = Convert.ToDouble(userInputTwo);

// Console.WriteLine($"the arithmetic mean of given numbers {firstNumber} and {secondNumber} : {GetArithmeticMean(firstNumber,secondNumber)}");

// static double GetArithmeticMean(double firstNumber,double secondNumber)
// {
//     return (firstNumber+secondNumber)/2;
// }

// --------------------------------------------------------------------------------------

/*
Find the geometric mean of 2 non-negative numbers
*/

// Console.WriteLine("Enter a first positive number");
// string userInputOne = Console.ReadLine();
// double firstNumber = Convert.ToDouble(userInputOne);

// Console.WriteLine("Enter a second positive number");
// string userInputTwo = Console.ReadLine();
// double secondNumber = Convert.ToDouble(userInputTwo);

// Console.WriteLine($"the Geometric mean {firstNumber} and {secondNumber} : {GetGeometricMean(firstNumber,secondNumber)}");

// static double GetGeometricMean(double firstNumber,double secondNumber)
// {
//     double geometricMean = 0;
//     if (firstNumber >= 0 && secondNumber >= 0 )
//     {
//         double number = firstNumber * secondNumber;
//         geometricMean = Math.Sqrt(number);

//     }
//     else
//     {
//         Console.WriteLine("Enter the positive number !!!");
//     }
//     return geometricMean;
// }

// --------------------------------------------------------------------------------------

// Console.WriteLine("Enter first positive number");
// string userInputOne = Console.ReadLine();
// int firstNumber = Convert.ToInt32(userInputOne);

// Console.WriteLine("Enter second positive number");
// string userInputTwo = Console.ReadLine();
// int secondNumber = Convert.ToInt32(userInputTwo);

// Console.WriteLine($"Sum of {firstNumber} and {secondNumber} is: {GetSumNumber(firstNumber, secondNumber)}");
// Console.WriteLine($"Multiple of {firstNumber} and {secondNumber} is: {GetMultipleNumber(firstNumber, secondNumber)}");
// Console.WriteLine($"Square of {firstNumber} is: {GetSquareNumberOne(firstNumber)}");
// Console.WriteLine($"Square of {secondNumber} is: {GetSquareNumberTwo(secondNumber)}");

// static int GetSumNumber(int firstNumber, int secondNumber) 
// {
//     int result = 0;

//     if (firstNumber > 0 && secondNumber > 0)
//     {
//         result = firstNumber + secondNumber;
//     }
//     else
//     {
//         Console.WriteLine("Please enter the positive number!!!");
//     }
//     return result;
// }

// static int GetMultipleNumber(int firstNumber, int secondNumber)
// {
//     int result = 0;

//     if (firstNumber > 0 && secondNumber > 0)
//     {
//         result = firstNumber * secondNumber;
//     }
//     else
//     {
//         Console.WriteLine("Please enter the positive number!!!");
//     }
//     return result;
// }

// static int GetSquareNumberOne(int firstNumber)
// {
//     int result = 0;

//     if (firstNumber > 0)
//     {
//         result = firstNumber * firstNumber;
//     }
//     else
//     {
//         Console.WriteLine("Please enter the positive number!!!");
//     }
//     return result;
// }

// static int GetSquareNumberTwo(int secondNumber)
// {
//     int result = 0;

//     if (secondNumber > 0)
//     {
//         result = secondNumber * secondNumber;
//     }
//     else
//     {
//         Console.WriteLine("Please enter the positive number!!!");
//     }
//     return result;
// } 

// --------------------------------------------------------------------------------------

/*
Find its hypotenuse and perimeter of a right triangle given legs a and b
*/

// Console.WriteLine("Enter first number");
// string userInputOne = Console.ReadLine();
// double firstNumber = Convert.ToDouble(userInputOne);

// Console.WriteLine("Enter second number");
// string userInputTwo = Console.ReadLine();
// double secondNumber = Convert.ToDouble(userInputTwo);


// double hypotenuseForPerimeter = GetHypotenuse(firstNumber, secondNumber);
// double perimeter = GetPerimeter(firstNumber, secondNumber, hypotenuseForPerimeter);

// Console.WriteLine($"Hypotenuse : {hypotenuseForPerimeter}");
// Console.WriteLine($"Perimeter : {perimeter}");

// static double GetHypotenuse(double firstNumber, double secondNumber)
// {
//     double hypotenuse = 0;
//     hypotenuse = Math.Sqrt((firstNumber * firstNumber) + (secondNumber * secondNumber));
//     return hypotenuse;

// }
// static double GetPerimeter(double hypotenuse, double firstNumber, double secondNumber)
// {
//     double perimeter = firstNumber + secondNumber + hypotenuse;
//     return perimeter;
// }

Console.Write("3 xonali son kiriting :");
int userInput = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(userInput);

// 1 2 3 
int firstNumber = userInput /100;
int secondNumber = (userInput / 10)%10;
int thirdNumber = ((userInput%100) %10);

if(firstNumber < secondNumber && secondNumber < thirdNumber)
{
    Console.WriteLine("True");
}else
{
    Console.WriteLine("False");
}

