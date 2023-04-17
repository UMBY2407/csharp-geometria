// See https://aka.ms/new-console-template for more information
using Geometria;

Console.WriteLine("Hello, Utente!");
Console.Write("Inserisci la base del Rettangolo (accetto solo numeri interi): ");
int Base = int.Parse(Console.ReadLine());

Console.Write("Inserisci l'altezza del Rettangolo (accetto solo numeri interi): ");
int altezza = int.Parse(Console.ReadLine());

Rettangolo ilMioRettangolo = new Rettangolo(altezza, Base);

ilMioRettangolo.calcolaArea();
ilMioRettangolo.calcolaPerimetro();