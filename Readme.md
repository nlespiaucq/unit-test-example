## CLI

dotnet new mstest -n BoutiqueWeb.UnitTests
cd BoutiqueWeb.UnitTests
dotnet add BoutiqueWeb.UnitTests.csproj reference ../BoutiqueWeb/BoutiqueWeb.csproj
dotnet add package FluentAssertions --version 6.12.0
dotnet add package Moq
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0.0

## Source code - Example

namespace BoutiqueWeb.UniTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var p = new Produit() {
            Prix = 9.99
        };
        var c = new Commande() {
            Produit = p,
            Quantite = 10
        }; // 10 produits
        var prix = c.getPrix();
        Assert.AreEqual(99.9, prix);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var p = new Produit() {
            Prix = 9.99
        };
        var c = new Commande() {
            Produit = p,
            Quantite = 0
        }; // 10 produits
        var prix = c.getPrix();
        Assert.AreEqual(0, prix);
    }
}