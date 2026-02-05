using System.Globalization;
using System.Runtime.InteropServices;

namespace digitalisNyomozas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string valasz;
			bool test = true;
			Console.WriteLine("Üdvözlöm a rendszerben.");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Válasszon az alábbi lehetőségekből(sorszám)");
			List<User> felhasznalok = new List<User>();
			User u1 = new User("nev", "azonosito", "szerepkor");
			do
			{
				{
					Console.WriteLine("1. Ügyek kezelése\n2. Személyek kezelése\n3. Bizonyíték kezlése\n4. Idővonal megtekintése\n5. Elemzés / döntések\n6. Kilépés");
					valasz = Console.ReadLine();
					switch (valasz)
					{
						case "1":
							Console.WriteLine();
							break;
						case "2":
							User uj = User.Ujugyfel();
							felhasznalok.Add(uj);
							foreach (var item in felhasznalok)
							{
								Console.WriteLine(item);
							}
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
							test = false;
							break;
						default:
							Console.WriteLine("Nincs ilyen menüpont");
							break;
					}
				}
			}
			while (test);
		}
	}
}
