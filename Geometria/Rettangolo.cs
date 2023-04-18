using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
	public class Rettangolo
	{
		//ATTRIBUTI	
		public int altezzaRettangolo, baseRettangolo;

		//COSTRUTTORE
		public Rettangolo(int altezza, int Base)
		{
			this.altezzaRettangolo = altezza;
			this.baseRettangolo = Base;
		}

		//METODI
		public int calcolaArea()
		{
			int area = baseRettangolo * altezzaRettangolo;
			return area;
		}

		public int calcolaPerimetro()
		{
			int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
			return perimetro;
		}

		public void stampaRisultato()
		{
			int area = calcolaArea();
			int perimetro = calcolaPerimetro();

			Console.WriteLine("-- RETTANGOLO --");
			Console.WriteLine("base: " + baseRettangolo + " cm");
			Console.WriteLine("altezza: " + altezzaRettangolo + " cm");
			Console.WriteLine("Perimetro: " + perimetro + " cm");
			Console.WriteLine("Area: " + area + " cm²");
		}
	}
}