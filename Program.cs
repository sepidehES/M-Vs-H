using Heroes_Vs_Monsters.Modeles;
using Heroes_Vs_Monsters.Tools;
using System;

Hero hero = new Hero("Sefi");
Monstre monstre = new Monstre("Vilain");
Humain jean = new Humain("Jean");

Console.WriteLine($"Nom: {jean.Nom}");
Console.WriteLine($"Endurance: {jean.Endurance}");
Console.WriteLine($"Force: {jean.Force}");
Console.WriteLine($"PointsDeVie: {jean.PointsDeVie}");

//Console.WriteLine();

//Console.WriteLine($"Nom: {monstre.Nom}");
//Console.WriteLine($"Endurance: {monstre.Endurance}");
//Console.WriteLine($"Force: {monstre.Force}");
//Console.WriteLine($"PointsDeVie: {monstre.PointsDeVie}");
//Console.WriteLine($"Or: {monstre.Or}");
//Console.WriteLine($"Cuir: {monstre.Cuir}");

//Console.WriteLine();


Inventaire test = new Inventaire();

int dice = Dice.Lancer(DiceType.D4, 1);
