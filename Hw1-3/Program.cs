// предствьте компьютер может только + и -. вычислить 1. умножение двух целых чисел 2. целочисленно еделение двух целых чисел 3. получение остатка от целочисленного деления целых чисел.
Console.WriteLine("Enter first digit");
string a = Console.ReadLine()!;

Console.WriteLine("Enter second digit");
string b = Console.ReadLine()!;

int firstNumber = Convert.ToInt32(a) ;
int secondNumber = Convert.ToInt32(b);
int multipResult = 0;

for( int i = 0; i < secondNumber; i++)
{

multipResult = multipResult + firstNumber;

}

Console.WriteLine(multipResult);
