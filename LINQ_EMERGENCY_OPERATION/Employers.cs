namespace LINQ_EMERGENCY_OPERATION
{
    class Employers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Age { get; set; }
        public Employers(string id, string name, string family, string age)
        {
            Id = id;
            Name = name;
            Family = family;
            Age = age;
        }
        public static Employers[] getEmployers()
        {
            Employers[] emp =
            {
                new Employers ( "1", "Vasya", "Petrov", "22"),
                new Employers ( "2", "Vasya", "Sidorov", "66"),
                new Employers ( "3", "Vasya", "Ivanov", "36"),
                new Employers ( "4", "Vasya", "Determ", "66"),
                new Employers ( "5", "Vasya", "Halib", "45")
                            };
            return emp;
        }
    }
}
