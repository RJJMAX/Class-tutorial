using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_tutorial;

internal class Student { 
    // These are properties of Student class
    private static int NextId { get; set; }
    public int Id { get; set; }
    public string Firstname { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }
    public DateTime DateCreated { get; set; }



    // constructors
    public Student() { }

    public Student(string firstname, int age) {
        Id = NextId;
        Firstname = firstname;
        Age = age;
    }
    public void IncrementAge() {
        Age = Age++;
    }
    public void ChangeFirstname(string firstname) //for ease of code could make the paramenter the same as the property just lowercase it
    {
        this.Firstname = firstname;
    }
        public string CalcCreateDatePlus30Days()
    {
        return DateCreated.AddDays(30).ToString("MM/dd/yyyy");
    }
}
