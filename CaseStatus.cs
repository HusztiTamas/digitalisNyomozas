using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomozas
{
	internal class CaseStatus
	{
		private string aktStatus;

		public CaseStatus(string aktStatus)
		{
			this.aktStatus = aktStatus;
		}

		public string AktStatus { get => aktStatus; set => aktStatus = value; }
	}
}
