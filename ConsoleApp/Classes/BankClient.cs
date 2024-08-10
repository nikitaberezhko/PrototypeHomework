namespace ConsoleApp.Classes;

/// <summary>
/// Клиент банка
/// </summary>
public class BankClient : Client, IMyCloneable<BankClient>, ICloneable
{
    public Bank Bank { get; set; }

    public BankClient(string name, int age, string email, Bank bank) 
        : base(name, age, email)
    {
        Bank = bank;
    }
    
    protected BankClient(BankClient source) : base(source) => Bank = new Bank(source.Bank.Name);

    public BankClient CloneThisObj()
    {
        return new BankClient(this);
    }
    
    public object Clone()
    {
        return MemberwiseClone();
    }
    
    public override string ToString()
    {
        return $"BankClient — Name: {Name}, Age: {Age}, Email: {Email}, BankName: {Bank.Name}";
    }
}