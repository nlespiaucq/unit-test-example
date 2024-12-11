namespace BoutiqueWeb.Models;

public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; } = null!;
    public string Prenom { get; set; } = null!;
    public string? Adresse { get; set; }
    public DateTime? DateDeNaissance { get; set; }
}