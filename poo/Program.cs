// Classe Program (représente le programme avec son point d'entrée)
class Program
{
    // Point d'entrée du programme : méthode statique appelée Main qui retourne void
    static void Main(string[] args)
    {
        Console.WriteLine("Début");

        // Instanciation (créer un objet) d'un objet de classe Ville
        //Ville Avignon = new Ville("Avignon", "84000");
        Ville Avignon = new Ville(codePostal: "84000", nom: "Avignon");

        // A partir d'ici, on peut utiliser l'objet Avignon

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

        Ville Paris = new Ville("Paris");
        Paris.CodePostal = "75000";
        Paris.Afficher();
        Paris.Population = 2200000;
        Console.WriteLine(Paris.Population);

        // Appel de la méthode statique Bonjour() sur la classe
        Ville.Bonjour();

        Console.WriteLine(Ville.Region);
    }
}