using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EMERGENCY_OPERATION
{
    class Employer
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public Employer(string id, string name, string family, int age)
        {
            Id = id;
            Name = name;
            Family = family;
            Age = age;
        }
        public static Employer[] getEmployer()
        {
            Employer[] emp =
            {
                new Employer ( "1", "Vasya", "Petrov", 22),
                new Employer ( "2", "Vasya", "Sidorov", 66),
                new Employer ( "3", "Vasya", "Ivanov", 36),
                new Employer ( "4", "Vasya", "Determ", 66),
                new Employer ( "5", "Vasya", "Halib", 45)
                            };
            return emp;
        }
    }
}
