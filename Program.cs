using System;

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
Console.WriteLine("Enter first side of rectangle : ");
string userInputsideA = Console.ReadLine();
int sideA = Convert.ToInt32(userInputsideA);

Console.WriteLine("Enter second side of rectangle : ");
string userInputsideB = Console.ReadLine();
int sideB = Convert.ToInt32(userInputsideB);

Console.WriteLine($"Result : {GetSurfaceRectangle(sideA,sideB)}");

static int GetSurfaceRectangle(int sideA,int sideB)
{
    return sideA * sideB;
}

