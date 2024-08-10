using System.Text.Json;
using ConsoleApp.Classes;
using Xunit;

namespace Tests;

public class ClientTests
{
    [Fact]
    public void MyCloneableTest_MustReturnClientWithEqualFields()
    {
        // Arrange
        var client = new Client("Maks", 20, "a@a.com");
        var clone = client.CloneThisObj();
        
        // Act
        
        // Assert
        Assert.Equal(JsonSerializer.Serialize(client), JsonSerializer.Serialize(clone));
    }
    
    [Fact]
    public void MyCloneableTest_MustReturnClientWithDifferentReferencesToFields()
    {
        // Arrange
        var client = new Client("Maks", 20, "a@a.com");
        var clone = client.CloneThisObj();
        
        // Act
        clone.Name = "Maksim";
        clone.Age = 30;
        
        // Assert
        Assert.NotEqual(JsonSerializer.Serialize(client), JsonSerializer.Serialize(clone));
    }
    
    [Fact]
    public void ICloneableTest_MustReturnClientWithEqualFields()
    {
        // Arrange
        var client = new Client("Maks", 20, "a@a.com");
        var clone = (Client)client.Clone();
        
        // Act
        
        // Assert
        Assert.Equal(JsonSerializer.Serialize(client), JsonSerializer.Serialize(clone));
    }
    
    [Fact]
    public void ICloneableTest_MustReturnClientWithDifferentReferencesToFields()
    {
        // Arrange
        var client = new Client("Maks", 20, "a@a.com");
        var clone = (Client)client.Clone();
        
        // Act
        clone.Name = "Maksim";
        clone.Age = 30;
        
        // Assert
        Assert.NotEqual(JsonSerializer.Serialize(client), JsonSerializer.Serialize(clone));
    }
}