﻿using System;

class Program
{
    static void Main(string[] args)
    {

        // Création d’un compte
        Compte compte = new Compte("Durand", "Alice", "15 rue Victor Hugo", "75001", "Paris", "0601020304", "alice.durand@email.com", 1500m);

        // Affichage des infos
        compte.Afficher();
    }
}