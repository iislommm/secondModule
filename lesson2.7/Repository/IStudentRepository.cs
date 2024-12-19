using lesson2._7.DataAccess.Enteties;

namespace lesson2._7.Repository
{
    public interface IStudentRepository
    {
        Guid WriteStudent(Student student);
        List<Student> ReadAllStudents();
        bool RemoveStudent(Guid stuidentId);
        Student GetStudentById(Guid studentId);
        bool UpdateStudent(Student student);
    }
}