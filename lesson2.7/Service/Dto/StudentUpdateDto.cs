namespace lesson2._7.Service.Dto;

public class StudentUpdateDto : BaseStudentDto 
{
    public Guid Id { get; set; }
    public string Password { get; set; }
}
