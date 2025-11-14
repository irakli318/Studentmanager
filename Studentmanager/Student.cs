

using System.Xml.Linq;

namespace Studentmanager;

public class Student:Person
{
    public int RollNumber { get; set; }
    public string Grade { get; set; }

    public Student(string name, int rollNumber, string grade)
        : base(name)
    {
        RollNumber = rollNumber;
        Grade = grade;
    }

    // პოლიმორფიზმი — ვანაცვლებთ Info() მეთოდს
    public override string Info()
    {
        return $"Student {RollNumber}: {Name} - Grade: {Grade}";
    }
}
