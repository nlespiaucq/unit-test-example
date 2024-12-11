## CLI

```
dotnet new mstest -n BoutiqueWeb.UnitTests
cd BoutiqueWeb.UnitTests
dotnet add BoutiqueWeb.UnitTests.csproj reference ../BoutiqueWeb/BoutiqueWeb.csproj
dotnet add package FluentAssertions --version 6.12.0
dotnet add package Moq
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0.0
```

## Source code - Example

https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
Test pattern: AAA (Arrange, Act, Assert)

```
namespace BoutiqueWeb.UniTests;

using BoutiqueWeb.Models;
using BoutiqueWeb.DTO;

[TestClass]
public class ClientDtoTests
{
    [TestMethod]
    public void ShouldOverideBirthday_WhenNull()
    {
        // Arrange
        Client stan = new()
        {
            Prenom = "Stan",
            Nom = "Smith",
            Adresse = "7 Cours de la Marne, 33000 Bordeaux",
            DateDeNaissance = null,
        };

        // Act
        var clientDTO = new ClientDTO(stan);

        // Assert
        Assert.AreEqual(clientDTO.FirstName, "Stan");
        Assert.AreEqual(clientDTO.LastName, "Smith");
        Assert.AreEqual(clientDTO.Address, "7 Cours de la Marne, 33000 Bordeaux");
        Assert.AreEqual(clientDTO.Birthday, "Unknown");
    }

    [TestMethod]
    public void ShouldOverideAddress_WhenNull()
    {
        // Arrange
        Client stan = new()
        {
            Prenom = "Stan",
            Nom = "Smith",
            Adresse = null,
            DateDeNaissance = null,
        };

        // Act
        var clientDTO = new ClientDTO(stan);

        // Assert
        Assert.AreEqual(clientDTO.FirstName, "Stan");
        Assert.AreEqual(clientDTO.LastName, "Smith");
        Assert.AreEqual(clientDTO.Address, "Unknown");
        Assert.AreEqual(clientDTO.Birthday, "Unknown");
    }
}
```
