using lesson2._7.DataAccess.Enum;
using System.Reflection.Metadata.Ecma335;

namespace lesson2._7.DataAccess.Enteties;

public class Student
{
    public  Guid Id { get; set; }
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Gender Gender { get; set; }
    public DegreeStatus Degree { get; set; }
}
