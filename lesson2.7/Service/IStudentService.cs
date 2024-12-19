using lesson2._7.Service.Dto;
using lesson2._7.Service.Enums;

namespace lesson2._7.Service
{
    public interface IStudentService
    {
        Guid AddStudent(StudentCreateDto studentCreateDto);
        bool DeleteStudent(Guid studentId);
        StudentGetDto GetStudentById(Guid studentId);
        List<StudentGetDto> GetStudents();
        bool UpdateStudent(StudentUpdateDto studentUpdateDto);
        List<StudentGetDto> GetStudentsByDegree(DegreeStatusDto degreeStatusDto);
        List<StudentGetDto> GetStudentsByGender(GenderDto genderDto);


    }
}