/* Напишите программу, которая на вход принимает 3х значное 
число и на выходе показывает вторую цифру этого числа
*/

// Console.WriteLine("Enter three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SecondDigit(int num)
// {
//     int second = num / 10 % 10;
//     return second;
// }

// if (number > 99 && number < 1000)
// {
// int result = SecondDigit(number);
// Console.WriteLine($"We got: {result}");
// }
// else Console.WriteLine("It supposed to be 3-digit number");

/* Напишите программу, которая принимает на ыход цифру, 
обозначающую день недели, и проверяет, является ли 
этот день выходным
*/

// Console.WriteLine("Enter number from 1 to 7 to check if it's weekend: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0 && number < 6)
// {
//     Console.WriteLine($"{number} -> no");
// }
// else if (number > 5 && number < 8)
// {
//     Console.WriteLine($"{number} -> yes");
// }
// else Console.WriteLine("It supposed to be number betweet 1 to 7");

/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет
*/

int RandomNum()
{
    int num = new Random().Next(0, 100000);
    Console.WriteLine($"Generated number: {num}");
    return num;
}

int number = RandomNum();
if (number < 100)
{
    Console.WriteLine("There is no 3rd digit");
}
else if (number > 99 && number < 1000)
{
    int numOne = number % 100;
    Console.WriteLine($"Third digit is: {numOne}");
}
else if (number > 999 && number < 10000)
{
    int numTwo = number / 10 % 10;
    Console.WriteLine($"Third digit is: {numTwo}");
}
else 
{
    int numThree = number / 100 % 10;
    Console.WriteLine($"Third digit is: {numThree}");
}

