

namespace Studentmanager;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual string Info()
    {
        return $"Person: {Name}";
    }
}
