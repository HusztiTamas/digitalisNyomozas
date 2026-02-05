using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomozas
{
	internal class User
	{
		private string nev;
		private string azonosito;
		private string szerepkor;

		public User(string nev, string azonosito, string szerepkor)
		{
			this.nev = nev;
			this.azonosito = azonosito;
			this.szerepkor = szerepkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Szerepkor { get => szerepkor; set => szerepkor = value; }

		public static User Ujugyfel()
		{
			Console.WriteLine("Új ügyfél felvétele");
			Console.WriteLine("Add meg a nevet:");
			string nev = Console.ReadLine();
			Console.WriteLine("Add meg az azonosítót:");
			string azonosito = Console.ReadLine();
			Console.WriteLine("Add meg a szerepkörét:");
			string szerepkor = Console.ReadLine();
			return new User(nev,azonosito,szerepkor);
		}

		public override string ToString()
		{
			return $"Felhasználó neve: {this.nev} Azonosító: {this.azonosito} Szerepköre: {this.szerepkor}";
		}
	}
}
