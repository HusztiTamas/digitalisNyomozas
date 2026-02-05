using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomozas
{
	internal class Case
	{
		private string ugy_azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<User> kapcsolodoSzemelyek;
		private List<Evidence> kapcsolodoBizonyitekok;

		public Case(string ugy_azonosito, string cim, string leiras, string allapot)
		{
			this.ugy_azonosito = ugy_azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.kapcsolodoSzemelyek = kapcsolodoSzemelyek;
			this.kapcsolodoBizonyitekok = kapcsolodoBizonyitekok;
		}

		public string Ugy_azonosito { get => ugy_azonosito; set => ugy_azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<User> KapcsolodoSzemelyek { get => kapcsolodoSzemelyek; set => kapcsolodoSzemelyek = value; }
		internal List<Evidence> KapcsolodoBizonyitekok { get => kapcsolodoBizonyitekok; set => kapcsolodoBizonyitekok = value; }

		public static Case UjUgy()
		{
			Console.WriteLine("Új ügy felvétele");
			Console.Write("Add meg az ügy azonosítóját: ");
			string azonosito = Console.ReadLine();
			Console.Write("Add meg a címet: ");
			string cim = Console.ReadLine();
			Console.Write("Add meg az ügy leírását: ");
			string leiras = Console.ReadLine();
			Console.Write("Add meg az ügy állapotát: ");
			string allapot = Console.ReadLine();
			Console.Write("Add meg a kapcsolódó személyeket: ");
			return new Case(azonosito, cim, leiras, allapot);
		}
	}
}
