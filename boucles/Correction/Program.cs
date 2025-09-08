﻿// Exercice 3

// Ecrire un programme qui demande à l'utilisateur d'entrer des nombres (un par un).
// La saisie s'arrête lorsqu'il entre 0.
// Avec une boucle while, calculer et afficher la somme des nombres saisis.

Console.WriteLine("Veuillez entrer un nombre (0 pour arrêter) :");

int iterations = 1;
int somme = 0;

int nombre = Convert.ToInt32(Console.ReadLine());
while (nombre != 0)
{
    somme += nombre;

    nombre = Convert.ToInt32(Console.ReadLine());

    iterations ++;
}

Console.WriteLine("Nombres d'itérations : " + iterations + ", somme = " + somme);
Console.WriteLine("Boucle 3 terminée.");