Console.WriteLine("Exercice 2");
// If/Else
int note = 10;
if (note >= 10)
{
    Console.WriteLine("Réussi");
}
else
{
    Console.WriteLine("Echec");
}

// Si une seule instruction dans le bloc, {} pas,indispensable
if (note >= 10)
    Console.WriteLine("Réussi");
else
    Console.WriteLine("Echec");

// if/else if/else
if (note >= 15)
    Console.WriteLine("Très bien");
else if (note >= 10)
    Console.WriteLine("Bien");
else if (note >= 5)
    Console.WriteLine("Passable");
else
    Console.WriteLine("Mauvais");

// switch
switch (note)
{
    case >= 15:
        Console.WriteLine("Très bien");
        Console.WriteLine("Bravo");
        break;

    case >= 10:
        Console.WriteLine("Bien");
        break;

    case >= 5:
        Console.WriteLine("Passable");
        break;

    default:
        Console.WriteLine("Mauvais");
        break;
}

// Exercice
// Déclarer deux variables pour les âges de Pierre et Paul
// afficher lequel de deus est le plus âgé, avec des if, puis avec un switch