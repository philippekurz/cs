// Classe "normale"
class Ville
{
    // Constructeur par défaut (optionnel, car implicite si non défini)
    // Signature : public NomDeLaClasse
    public Ville()
    {
        Nom = "";
        CodePostal = "";
    }
    // Données de la classe : Propriétés / Attributs
    public string Nom { get; set; }
    public string CodePostal { get; set; }
    
    // Comportements de la classe : Méthodes (fonctions)
    public void Afficher()
    {
        Console.WriteLine($"{this.CodePostal} {this.Nom}");
        Test();
    }
    // Méthode privée (private) utilisable uniquement dans la classe
    private void Test()
    {
        Console.WriteLine("Test");
    }
}

// Classe Program (représente le programme avec son point d'entrée)
class Program
{
    // Point d'entrée du programme : méthode statique appelée Main qui retourne void
    static void Main(string[] args)
    {
        Console.WriteLine("Début");

        // Instanciation (créer un objet) d'un objet de classe Ville
        Ville Avignon = new Ville();

        // A partir d'ici, on peut utiliser l'objet maVille
        Avignon.Nom = "Avignon";        // Affectation du nom
        Avignon.CodePostal = "84000";   // Affectation du CodePostal

        // Utilisation de la méthode public Afficher de l'objet maVille
        Avignon.Afficher();

        // Impossible car la méthode est private
        //Avignon.Test();

        // Instanciation (créer un objet) d'un objet de classe Ville
        Ville Marseille = new Ville();

        // A partir d'ici, on peut utiliser l'objet maVille
        Marseille.Nom = "Marseille";        // Affectation du nom
        Marseille.CodePostal = "13000";   // Affectation du CodePostal

        // Utilisation de la méthode public Afficher de l'objet maVille
        Marseille.Afficher();

    }
}