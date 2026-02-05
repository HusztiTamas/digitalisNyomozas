using System.Globalization;
using System.Runtime.InteropServices;

namespace digitalisNyomozas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool use = true;
			List<Case> ugy=new List<Case>();
			List<User> felhasznalok = new List<User>();
			do
			{
				{
					Console.Clear();
					Console.WriteLine("Digitális nyomozás rendszer");
					Console.WriteLine("-----------------------");
					Console.WriteLine("Válasszon az alábbi lehetőségekből(sorszám)");
					Console.WriteLine("1. Ügyek kezelése");
					Console.WriteLine("2. Személyek kezelése");
					Console.WriteLine("3. Bizonyíték kezelése");
					Console.WriteLine("4. Idővonal megtekintése");
					Console.WriteLine("5. Elemzés / döntések");
					Console.WriteLine("6. Kilépés");
					string valasz = Console.ReadLine();
					switch (valasz)
					{
						case "1":
							Case uju = Case.UjUgy();
							ugy.Add(uju);
							Console.WriteLine("\nÜgyek:");
							foreach (var item in ugy)
							{
								Console.WriteLine(item);
							}
							Console.WriteLine("Nyomj entert a folytatáshoz");
							Console.ReadKey();
							break;
						case "2":
							User ujf = User.Ujugyfel();
							felhasznalok.Add(ujf);
							Console.WriteLine("\nSzemélyek:");
							foreach (var item in felhasznalok)
							{
								Console.WriteLine(item);
							}
							Console.WriteLine("Nyomj entert a folytatáshoz");
							Console.ReadKey();
							break;
						case "3":
							Console.WriteLine();
							break;
						case "4":
							Console.WriteLine();
							break;
						case "5":
							Console.WriteLine();
							break;
						case "6":
							Console.WriteLine();
							use = false;
							break;
						default:
							Console.WriteLine("Nincs ilyen menüpont");
							break;
					}
				}
			}
			while (use);
		}
	}
}
