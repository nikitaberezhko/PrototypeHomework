namespace ConsoleApp.Classes;

/// <summary>
/// Человек
/// </summary>
public class Person : IMyCloneable<Person>, ICloneable
{
    public string Name { get; set; }
    
    public int Age { get; set; }
    
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    protected Person(Person source)
    {
        Name = source.Name;
        Age = source.Age;
    }
    
    public Person CloneThisObj()
    {
        return new Person(this);
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
    
    public override string ToString()
    {
        return $"Person — Name: {Name}, Age: {Age}";
    }
}