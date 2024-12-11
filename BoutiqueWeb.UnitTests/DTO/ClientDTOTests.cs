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