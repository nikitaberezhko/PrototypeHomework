using System.Text.Json;
using ConsoleApp.Classes;
using Xunit;

namespace Tests;

public class BankClientTests
{
    [Fact]
    public void MyCloneableTest_MustReturnBankClientWithEqualFields()
    {
        // Arrange
        var bankClient = new BankClient("Maks", 20, "a@a.com", new Bank("Sber"));
        var clone = bankClient.CloneThisObj();
        
        // Act
        
        // Assert
        Assert.Equal(JsonSerializer.Serialize(bankClient), JsonSerializer.Serialize(clone));
    }
    
    [Fact]
    public void MyCloneableTest_MustReturnBankClientWithDifferenceReferencesToFields()
    {
        // Arrange
        var bankClient = new BankClient("Maks", 20, "a@a.com", new Bank("Sber"));
        var clone = bankClient.CloneThisObj();
        
        // Act
        clone.Name = "Maksim";
        clone.Age = 30;
        
        // Assert
        Assert.NotEqual(JsonSerializer.Serialize(bankClient), JsonSerializer.Serialize(clone));
    }
    
    [Fact]
    public void ICloneableTest_MustReturnBankClientWithEqualFields()
    {
        // Arrange
        var bankClient = new BankClient("Maks", 20, "a@a.com", new Bank("Sber"));
        var clone = (BankClient)bankClient.Clone();
        
        // Act
        
        // Assert
        Assert.Equal(JsonSerializer.Serialize(bankClient), JsonSerializer.Serialize(clone));
    }
    
    [Fact]
    public void ICloneableTest_MustReturnBankClientWithDifferenceReferencesToFields()
    {
        // Arrange
        var bankClient = new BankClient("Maks", 20, "a@a.com", new Bank("Sber"));
        var clone = (BankClient)bankClient.Clone();
        
        // Act
        clone.Name = "Maksim";
        clone.Age = 30;
        
        // Assert
        Assert.NotEqual(JsonSerializer.Serialize(bankClient), JsonSerializer.Serialize(clone));
    }
}