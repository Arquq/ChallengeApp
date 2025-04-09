using ChallangeApp;

List<Employee>  employees = new List<Employee>();

employees.Add(new Employee("Marta", "Janik", 20));
employees.Add(new Employee("Jan", "Toperz", 21));
employees.Add(new Employee("Ornakdus", "Zitgard", 120));

employees[0].AddGrade(5);
employees[1].AddGrade(2);
employees[2].AddGrade(8);

employees[0].AddGrade(9);
employees[1].AddGrade(10);
employees[2].AddGrade(10);

employees[0].AddGrade(2);
employees[1].AddGrade(6);
employees[2].AddGrade(7);

employees[0].AddGrade(6);
employees[1].AddGrade(9);
employees[2].AddGrade(4);

employees[0].AddGrade(10);
employees[1].AddGrade(1);
employees[2].AddGrade(3);

int Score =0;
int TopRated = 0;

for (int i = 0; i < employees.Count; i++)
{
    if (employees[i].ScoreSum >= Score)
    {
        Score= employees[i].ScoreSum;
        TopRated = i;
    }
}

List<int> remis = new List<int>();
var RemisFlag = false;

for (int i=0; i<employees.Count; i++)
{
    if (employees[i].ScoreSum == Score && i!=TopRated)
    {
        RemisFlag = true;
        remis.Add(i);
    }

}

if (!RemisFlag)
{
    Console.WriteLine("wygrywa pracownik nr: " + TopRated + " z wynikiem " + Score + " punktów");
    Console.WriteLine("Dane pracownika z najwyższym wynikiem:");
    Console.WriteLine("Name: " + employees[TopRated].Name);
    Console.WriteLine("Last Name: " + employees[TopRated].LastName);
    Console.WriteLine("Age: " + employees[TopRated].Age);
}

if (RemisFlag)
{
    remis.Add(TopRated);
    Console.WriteLine("z wynkiem " + Score + " punktów, wygrywają remisem pracownicy:");
    foreach (var i in remis)
    {
        Console.WriteLine("Dane pracownika nr " + i + " z najwyższym wynikiem:");
        Console.WriteLine("Name: " + employees[i].Name);
        Console.WriteLine("Last Name: " + employees[i].LastName);
        Console.WriteLine("Age: " + employees[i].Age);
    }
}