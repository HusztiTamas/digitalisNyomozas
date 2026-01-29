using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomozas
{
	internal class Witness
	{
		private string vallomasSzovege;
		private DateTime vallomasdatuma;

		public Witness(string vallomasSzovege, DateTime vallomasdatuma)
		{
			this.vallomasSzovege = vallomasSzovege;
			this.vallomasdatuma = vallomasdatuma;
		}

		public string VallomasSzovege { get => vallomasSzovege; set => vallomasSzovege = value; }
		public DateTime Vallomasdatuma { get => vallomasdatuma; set => vallomasdatuma = value; }
	}
}
