using BoutiqueWeb.Models;

namespace BoutiqueWeb.DTO;

// Data Transfer Object class, used to bypass navigation properties validation during API calls
public class ClientDTO
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Address { get; set; }
    public string Birthday { get; set; }

    public ClientDTO() { }

    public ClientDTO(Client client)
    {
        Id = client.Id;
        LastName = client.Nom;
        FirstName = client.Prenom;
        Address = client.Adresse ?? "Unknown";
        Birthday = client.DateDeNaissance?.ToShortDateString() ?? "Unknown";
    }
}