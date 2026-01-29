using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomozas
{
	internal class Suspect
	{
		private int gyanusitottsagiSzint;
		private string status;

		public Suspect(int gyanusitottsagiSzint, string status)
		{
			this.gyanusitottsagiSzint = gyanusitottsagiSzint;
			this.status = status;
		}

		public int GyanusitottsagiSzint { get => gyanusitottsagiSzint; set => gyanusitottsagiSzint = value; }
		public string Status { get => status; set => status = value; }
	}
}
