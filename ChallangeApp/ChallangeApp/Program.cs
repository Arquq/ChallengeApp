var number = 2456743535;

string NumberToString = number.ToString();
char[] TabOfNumbers = NumberToString.ToArray();

for (int i=0; i<TabOfNumbers.Length; i++)
{
    Console.WriteLine(TabOfNumbers[i]);
}