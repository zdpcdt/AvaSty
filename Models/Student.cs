namespace AvaSty.Models;

public class Student
{
    public Student()
    {
        FirstName = "Xi";
        LastName = "Li";
    }

    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}