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
You are given the sides a and b of a rectangle, 
you need to find its area and perimeter and check the following condition.
*/
Console.WriteLine("Enter first side of rectangle : ");
string userInputsideA = Console.ReadLine();
int sideA = Convert.ToInt32(userInputsideA);

Console.WriteLine("Enter second side of rectangle : ");
string userInputsideB = Console.ReadLine();
int sideB = Convert.ToInt32(userInputsideB);

Console.WriteLine($"Result : {GetParameterRectangle(sideA,sideB)}");

static int GetParameterRectangle(int sideA,int sideB)
{
    return sideA * sideB;
}
