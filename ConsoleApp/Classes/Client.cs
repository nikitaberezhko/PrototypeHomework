namespace ConsoleApp.Classes;

/// <summary>
/// Клиент
/// </summary>
public class Client : Person, IMyCloneable<Client>, ICloneable
{
    public string Email { get; set; }
    
    public Client(string name, int age, string email) : base(name, age)
    {
        Email = email;
    }
    
    protected Client(Client source) : base(source) => 
        Email = source.Email;

    public Client CloneThisObj()
    {
        return new Client(this);
    }
    
    public object Clone()
    {
        return MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Client — Name: {Name}, Age: {Age}, Email: {Email}";
    }
}