
namespace ChallangeApp
{
    class Employee
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        private List<int> Score = new List<int>();

        public void AddGrade(int grade)
        {
            Score.Add(grade);
        }

        public int ScoreSum 
        {
            get
            {
                return Score.Sum();
            }
        }
        

        public Employee(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
}
