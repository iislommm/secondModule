using lesson2._7.DataAccess.Enteties;
using lesson2._7.Repository;
using lesson2._7.Service.Dto;
using lesson2._7.Service.Enums;

namespace lesson2._7.Service;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService()
    {
        _studentRepository = new StudentRepository();
    }
    public Guid AddStudent(StudentCreateDto studentCreateDto)
    {
        throw new NotImplementedException();
    }

    public bool DeleteStudent(Guid studentId)
    {
        throw new NotImplementedException();
    }

    public StudentGetDto GetStudentById(Guid studentId)
    {
        throw new NotImplementedException();
    }

    public List<StudentGetDto> GetStudents()
    {
        throw new NotImplementedException();
    }

    public List<StudentGetDto> GetStudentsByDegree(DegreeStatusDto degreeStatusDto)
    {
        throw new NotImplementedException();
    }

    public List<StudentGetDto> GetStudentsByGender(GenderDto genderDto)
    {
        throw new NotImplementedException();
    }

    public bool UpdateStudent(StudentUpdateDto studentUpdateDto)
    {
        throw new NotImplementedException();
    }


    private Student ConvertToEntitiy(StudentCreateDto studentCreateDto)
    {
        return new Student
        {
            Id = Guid.NewGuid(),
            FirstName = studentCreateDto.FirstName,
            LastName = studentCreateDto.LastName,
            Age = studentCreateDto.Age,
            Password = studentCreateDto.Password,
            Degree = (DataAccess.Enum.DegreeStatus)studentCreateDto.Degree,
            Gender = (DataAccess.Enum.Gender)studentCreateDto.Gender,
            Email = studentCreateDto.Email
        };

    }

    private Student ConvertToEntitiy(StudentUpdateDto studentUpdateDto)
    {
        return new Student
        {
            Id = studentUpdateDto.Id,
            FirstName = studentUpdateDto.FirstName,
            LastName = studentUpdateDto.LastName,
            Age = studentUpdateDto.Age,
            Password = studentUpdateDto.Password,
            Degree = (DataAccess.Enum.DegreeStatus)studentUpdateDto.Degree,
            Gender = (DataAccess.Enum.Gender)studentUpdateDto.Gender,
            Email = studentUpdateDto.Email
        };

    }
    private StudentGetDto ConvertToDto(Student student)
    {
        return new StudentGetDto
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Age = student.Age,
            Email = student.Email,
            Degree = (DegreeStatusDto)student.Degree,
            Gender = (GenderDto)student.Gender,

        };
    }

    bool ValidadeStudentCreateDto(StudentCreateDto obj)
    {
        if (string.IsNullOrWhiteSpace(obj.FirstName) || obj.FirstName.Length > 50)
        {
            return false;
        }
        if (string.IsNullOrWhiteSpace(obj.LastName) || obj.LastName.Length > 50)
        {
            return false;
        }
        if (obj.Age < 15 || obj.Age > 150)
        {
            return false;
        }

        if (!obj.Email.EndsWith("@gmail.com"))

    }

    
   
}
