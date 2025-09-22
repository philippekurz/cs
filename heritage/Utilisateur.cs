public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    // Constructeur sans parametre
    public Utilisateur()
    {
        Nom = "Vide";
        Prenom = "Vide";
    }
    // Constructeur avec 2 parametres
    public Utilisateur(string prenom, string nom)
    {
        Prenom = prenom;
        Nom = nom;
    }
    public void Afficher()
    {
        Console.WriteLine($"Utilisateur : {Prenom} {Nom}");
    }
}
// Classe héritée Administrateur
public class Administrateur : Utilisateur
{
     
}

// Classe héritée Client
public class Client : Utilisateur
{
    public Client()
    {
        Adresse = "";
    }
    public Client(string prenom, string nom, string adresse) : base(prenom, nom)
    {
        // Inutile grace à :base
        // Prenom = prenom;
        // Nom = nom;
        Adresse = adresse;
    }
    public string Adresse { get; set; }
    // surcharge de la méthode Afficher
    public new void Afficher()
    {
        Console.WriteLine($"Client : {Prenom} {Nom} {Adresse}");
    }
}

public class Employe : Utilisateur
{
    public Employe()
    {
        Poste = "";
    }
    public string Poste { get; set; }
    public new void Afficher()
    {
        Console.WriteLine($"Employé : {Prenom} {Nom} {Poste}");
    }
}