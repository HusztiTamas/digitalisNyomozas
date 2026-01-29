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
		private List<Case> kapcsolodoSzemelyek;
		private List<Case> kapcsolodoBizonyitekok;

		public Case(string ugy_azonosito, string cim, string leiras, string allapot, List<Case> kapcsolodoSzemelyek, List<Case> kapcsolodoBizonyitekok)
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
		internal List<Case> KapcsolodoSzemelyek { get => kapcsolodoSzemelyek; set => kapcsolodoSzemelyek = value; }
		internal List<Case> KapcsolodoBizonyitekok { get => kapcsolodoBizonyitekok; set => kapcsolodoBizonyitekok = value; }
	}
}
