using System.Text.Json;
using ConsoleApp.Classes;
using Xunit;

namespace Tests;

public class PersonTests
{
    [Fact]
    public void MyCloneableTest_MustReturnPersonWithEqualFields()
    {
        // Arrange
        var person = new Person("Maks", 20);
        var clone = person.CloneThisObj();
        
        // Act
        
        // Assert
        Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
    }
    
    [Fact]
    public void MyCloneableTest_MustReturnPersonWithDifferentReferencesToFields()
    {
        // Arrange
        var person = new Person("Maks", 20);
        var clone = person.CloneThisObj();
        
        // Act
        clone.Name = "Maksim";
        clone.Age = 30;
        
        // Assert
        Assert.NotEqual(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
    }

    [Fact]
    public void ICloneableTest_MustReturnPersonWithEqualFields()
    {
        // Arrange
        var person = new Person("Maks", 20);
        var clone = person.Clone();
        
        // Act
        
        // Assert
        Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
    }

    [Fact]
    public void ICloneableTest_MustReturnPersonWithDifferentReferencesToFields()
    {
        // Arrange
        var person = new Person("Maks", 20);
        var clone = (Person)person.Clone();
        
        // Act
        clone.Name = "Maksim";
        clone.Age = 30;
        
        // Assert
        Assert.NotEqual(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
    }
}