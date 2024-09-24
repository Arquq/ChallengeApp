using System.Formats.Asn1;

var myAge = 100;
int newAge = myAge + 5;

//liczby całkowite

int maxInt = int.MaxValue;
Console.WriteLine(maxInt);

int minInt = int.MinValue;
Console.WriteLine(minInt);


uint minUint = uint.MinValue;
uint maxUint = uint.MaxValue;

//liczby zmiennoprzecinkowe

float minFloat = float.MinValue;
float maxFloat = float.MaxValue;

double minDouble = double.MinValue;
double maxDouble = double.MaxValue;

decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;

Console.WriteLine(minUint);
Console.WriteLine(maxUint);
Console.WriteLine(minFloat);
Console.WriteLine(maxFloat);
Console.WriteLine(minDouble);
Console.WriteLine(maxDouble);
Console.WriteLine(minDecimal);
Console.WriteLine(maxDecimal);

//zmienne tekstowe

string name = "imie";
string surname = "nazwisko";
string fullName = name + surname + myAge;

Console.WriteLine($"{name} {surname}");

var cutName = name.ToArray();
Console.WriteLine(cutName);

var isValid = 5 > 6;
Console.WriteLine(isValid);

char symbol = 'a';

var number1 = 10;
var number2 = 20;

if (number1 < number2)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}