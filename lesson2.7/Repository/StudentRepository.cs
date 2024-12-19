using lesson2._7.DataAccess.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson2._7.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly string _path;
    private List<Student> _students;
    public StudentRepository()
    {
        _path = "../../../DataAccess/Data/Students.json";
        _students = new List<Student>();

        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }

    }
    public Student GetStudentById(Guid studentId)
    {
        foreach (var student in _students)
        {
            if (student.Id == studentId)
            {
                return student;
            }
        }
        return null;
    }

    public List<Student> ReadAllStudents()
    {
        var studentsJson = File.ReadAllText(_path);
        var students = JsonSerializer.Deserialize<List<Student>>(studentsJson);

        return students;
    }

    public bool RemoveStudent(Guid studentId)
    {
        var student = GetStudentById(studentId);
        
        if (student is null)
        {
            return false;
        }
        _students.Remove(student);
        SaveData();
        return true;
    }
    public bool UpdateStudent(Student student)
    {
        var updatingStudent = GetStudentById(student.Id);

        if (updatingStudent is null)
        {
            return false;
        }
        var index = _students.IndexOf(student);
        _students[index] = student;
        return true;
    }

    public Guid WriteStudent(Student student)
    {
        _students.Add(student);
        SaveData();
        return student.Id;
    }
    private void SaveData()
    { 
        var studentJson = JsonSerializer.Serialize(_students);
        File.WriteAllText(_path, studentJson);  

    }
}
