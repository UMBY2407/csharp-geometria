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
		public void calcolaArea()
		{
			int area = baseRettangolo * altezzaRettangolo;
			Console.WriteLine("L'Area del rettangolo è: " + area + " cm");
		}

		public void calcolaPerimetro()
		{
			int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
			Console.WriteLine("Il Perimetro del rettangolo è: " + perimetro + " cm");
		}
	}
}