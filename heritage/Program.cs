public class Heritage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Héritage c#");

        // Utilisateur user = new Utilisateur();
        // user.Nom = "Kurz";
        // user.Prenom = "Philippe";
        // user.Afficher();

        Utilisateur user = new Utilisateur("Philippe", "Kurz");
        user.Afficher();

        // client est une instance (un objet) de la classe Client
        // Client client = new Client();
        // client.Nom = "Dupont";
        // client.Prenom = "Jacques";
        // client.Adresse = "Place Jean Jaurès 84740 Velleron";

        Client client = new Client("Jacques", "Dupont", "Place Jean Jaurès 84740 Velleron");
        client.Afficher();

        // employe est une instance (un objet) de la classe Employe
        Employe employe = new Employe();
        employe.Nom = "Martin";
        employe.Prenom = "Paul";
        employe.Poste = "Secrétaire";
        employe.Afficher();
    }

} 

