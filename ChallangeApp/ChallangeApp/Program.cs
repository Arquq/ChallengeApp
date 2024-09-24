string name = "Ewa";
char sex = 'f';
int age = 30;

if (sex == 'f' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}

if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}