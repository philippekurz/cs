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
// afficher lequel des deux est le plus âgé, avec des if, puis avec un switch
int agePierre = 14;
int agePaul = 15;

if (agePierre > agePaul)
    Console.WriteLine("Pierre est plus âgé que Paul.");
else if (agePierre < agePaul)
    Console.WriteLine("Paul est plus âgé que Pierre.");
else
    Console.WriteLine("Pierre et Paul ont tous les deux le même âge.");

switch (agePierre)
{
    case var age when age > agePaul:
        Console.WriteLine("Pierre est plus âgé que Paul.");
        break;

    case var age when age < agePaul:
        Console.WriteLine("Paul est plus âgé que Pierre.");
        break;

    default:
        Console.WriteLine("Pierre et Paul ont tous les deux le même âge.");
        break;
}


int pierre = 25;
int paul = 30;

if (pierre < paul) 
    Console.WriteLine("Pierre est plus jeune que Paul");
else if (pierre > paul) 
    Console.WriteLine("Pierre est plus âgé que Paul");
else 
    Console.WriteLine("Pierre et Paul ont le même âge");

switch (pierre<paul)
{
    case true:
        Console.WriteLine("Pierre est plus jeune que Paul");
        break;
    case false:
        Console.WriteLine("Pierre est plus âgé que Paul");
        break;
    default:
        Console.WriteLine("Pierre et Paul ont le même âge");
        break;  
}