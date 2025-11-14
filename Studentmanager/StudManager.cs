using Studentmanager;
namespace Studentmanager;

public class StudManager
{
    private List<Student> students = new List<Student>();

    public bool AddStudent(Student student)
    {
        // ვამოწმებთ უნიკალურობას
        if (students.Any(s => s.RollNumber == student.RollNumber))
        {
            Console.WriteLine("A list with the number already exists.");
            return false;
        }
        students.Add(student);
        return true;
    }

    public void ListStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("students not found.");
            return;
        }

        foreach (var s in students)
            Console.WriteLine(s.Info());
    }

    public Student FindByRoll(int roll)
    {
        return students.FirstOrDefault(s => s.RollNumber == roll);
    }

    public bool UpdateGrade(int roll, string newGrade)
    {
        var s = FindByRoll(roll);
        if (s != null)
        {
            s.Grade = newGrade;
            return true;
        }
        return false;
    }
}
}
