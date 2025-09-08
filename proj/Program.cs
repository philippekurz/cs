using System;

namespace ExempleObjet
{
    // Définition d'une classe Personne
    public class Personne
    {
        // Attributs
        public string Nom { get; set; }
        public int Age { get; set; }

        // Constructeur
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        // Méthode d'instance
        public void SePresenter()
        {
            Console.WriteLine($"Bonjour, je m'appelle {Nom} et j'ai {Age} ans.");
        }
    }

    // Classe principale avec Main
    class Program
    {
        static void Main(string[] args)
        {
            // Création d’un objet Personne
            Personne alice = new Personne("Alice", 25);

            // Appel d’une méthode de l’objet
            alice.SePresenter();

            // On peut créer un autre objet
            Personne bob = new Personne("Bob", 30);
            bob.SePresenter();
        }
    }
}
