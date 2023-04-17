// See https://aka.ms/new-console-template for more information
using Geometria;
using System.Data;

Console.WriteLine("Hello, Utente!");
Console.Write("Inserisci la base del 1° Rettangolo (accetto solo numeri interi): ");
int Base = int.Parse(Console.ReadLine());

Console.Write("Inserisci l'altezza del 1° Rettangolo (accetto solo numeri interi): ");
int altezza = int.Parse(Console.ReadLine());

Rettangolo primoRettangolo = new Rettangolo(altezza, Base);

primoRettangolo.calcolaArea();
primoRettangolo.calcolaPerimetro();
Console.WriteLine("----------------------------");

Console.Write("Inserire la Base del 2° Rettangolo (accetto solo interi): ");
int Base2 = int.Parse(Console.ReadLine());

Console.Write("Inserire l'altezza del 2° Rettangolo (accetto solo interi): ");
int altezza2 = int.Parse(Console.ReadLine());

Rettangolo secondoRettangolo = new Rettangolo(altezza2, Base2);
secondoRettangolo.stampaRisultato();