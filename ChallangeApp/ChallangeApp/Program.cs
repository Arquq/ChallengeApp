var number = 2456743535;

string NumberToString = number.ToString();
char[] TabOfDigits = NumberToString.ToArray();

List<int> counter = new List<int>();

counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);

foreach (char digit in TabOfDigits)
{
    if (digit == '0')
        counter[0]++;

    if (digit == '1')
        counter[1]++;

    if (digit == '2')
        counter[2]++;

    if (digit == '3')
        counter[3]++;

    if (digit == '4')
        counter[4]++;

    if (digit == '5')
        counter[5]++;

    if (digit == '6')
        counter[6]++;

    if (digit == '7')
        counter[7]++;

    if (digit == '8')
        counter[8]++;

    if (digit == '9')
        counter[9]++;
}

for (int i = 0; i<counter.Count; i++)
{
    Console.WriteLine(i + " => " + counter[i]);
}

