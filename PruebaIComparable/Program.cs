﻿using PruebaIComparable;

Rectangulo[] rectangulos = new Rectangulo[5];

rectangulos[0] = new Rectangulo(7, 5);
rectangulos[1] = new Rectangulo(6, 4);
rectangulos[2] = new Rectangulo(4, 3);
rectangulos[3] = new Rectangulo(3, 6);
rectangulos[4] = new Rectangulo(5, 7);

//Imprimimos el arreglo original
foreach(Rectangulo rectangulo in rectangulos)
    Console.WriteLine(rectangulo);

Console.WriteLine("------------------------------------");

//Hacemos uso de sort, el cual necesita la implementacion IComparable
Array.Sort(rectangulos);

//Imprimimos el arreglo ordenado
foreach(Rectangulo rectangulo in rectangulos)
    Console.WriteLine(rectangulo);