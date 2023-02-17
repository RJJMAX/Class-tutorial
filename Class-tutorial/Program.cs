using Class_tutorial;
/*
Teacher hannah = new Teacher
{
    Id = 5112,
    Firstname = "Hannah",
    Lastname = "Bannana",
    ClassCount = 3,
    ClassType = "History, English, Math",
    IsActive = true
};

    Console.WriteLine($"Id          : = {hannah.Id}");
    Console.WriteLine($"Firstname   : = {hannah.Firstname}");
    Console.WriteLine($"Lastname    : = {hannah.Lastname}");
    Console.WriteLine($"ClassCount  : = {hannah.ClassCount}");
    Console.WriteLine($"ClassType   : = {hannah.ClassType}");
    Console.WriteLine($"IsActive    : = {hannah.IsActive}");
*/
var t = new Test();
var id = t.Id;
var count = t.Count;
t.Count = -30;


Student joe = new Student()
{
    Id = 1,
    Firstname = "Joe",
    Age = 41,
    IsActive = true,
    DateCreated = new DateTime(2023, 2, 10)
};

Student jane = new Student()
{
    Id = 2,
    Firstname = "Jane",
    Age = 31,
    IsActive = false,
    DateCreated = new DateTime(2023, 2, 13)
};

Student pat = new Student(101, "Pat", 22);

Console.WriteLine($"{pat.Id} | {pat.Firstname} | {pat.Age} | {pat.DateCreated}");


Console.WriteLine($"instance joe's name is {joe.Firstname}");
joe.ChangeFirstname("Joseph");
Console.WriteLine($"joes new name is {joe.Firstname}");

Console.WriteLine($"jane's age is {jane.Age}");

jane.IncrementAge();
Console.WriteLine($"janes age is {jane.Age}");
Console.WriteLine($"jane's date created {jane.DateCreated}");
var JaneDateCreatedPlus30Days = jane.CalcCreateDatePlus30Days();
Console.WriteLine($"Jane's instance date plus 30 days is {JaneDateCreatedPlus30Days}");




/*
Console.WriteLine(joe.Id);
Console.WriteLine(joe.Firstname);
Console.WriteLine(joe.Age);
Console.WriteLine(joe.IsActive);
Console.WriteLine(joe.DateCreated);

Console.WriteLine($"Id         : = {joe.Id}");
Console.WriteLine($"Firstname  : = {joe.Firstname}");
Console.WriteLine($"Age        : = {joe.Age}");
Console.WriteLine($"IsActive   : = {joe.IsActive}");
Console.WriteLine($"DateCreated: = {joe.DateCreated}");

Customer customer1 = new Customer();
customer1.AccountNumber = "A001";
customer1.Name = "George";
customer1.Email = "george@george.com";
customer1.Phone = "513-928-1167";

Customer customer2 = new Customer
{
    AccountNumber = "B002",
    Name = "Bill",
    Email = "info@tthne.com",
    Phone = "234 -436-2356"
};
*/
//Console.WriteLine(customer2.Name);
