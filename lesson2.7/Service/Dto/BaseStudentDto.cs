using lesson2._7.Service.Enums;

namespace lesson2._7.Service.Dto;

public class BaseStudentDto
{
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public GenderDto Gender { get; set; }
    public DegreeStatusDto Degree { get; set; }
}
