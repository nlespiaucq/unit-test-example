using BoutiqueWeb.Models;

namespace BoutiqueWeb.Data;

public static class SeedData
{
    // Test data for part 1 and 2
    public static void Init()
    {
        using var context = new BoutiqueWebContext();
        // Look for existing content
        if (context.Clients.Any())
        {
            return;   // DB already filled
        }

        // Add students
        Client stan = new()
        {
            Prenom = "Stan",
            Nom = "Smith",
            Adresse = "7 Cours de la Marne, 33000 Bordeaux",
            DateDeNaissance = DateTime.Parse("1995-09-01"),
        };
        Client ana = new()
        {
            Prenom = "Ana",
            Nom = "Gonzalez",
            Adresse = "150 Boulevard des Pyrénées, 64000 Pau"
        };
        Client wim = new()
        {
            Prenom = "Wim",
            Nom = "Jansen",
            DateDeNaissance = DateTime.Parse("1989-07-14"),
        };
        context.Clients.AddRange(
            stan,
            ana,
            wim
        );


        // Commit changes into DB
        context.SaveChanges();
    }
}