using System.Globalization;

namespace digitalisNyomozas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char valasz;
			bool test = true;
			Console.WriteLine("Üdvözlöm a rendszerben.");
			Console.WriteLine("-----------------------");
			Console.WriteLine("Válasszon az alábbi lehetőségekből(sorszám)");
			Console.WriteLine("1. Ügyek kezelése\n2. Személyek kezelése\n3. Bizonyíték kezlése\n4. Idővonal megtekintése\n5. Elemzés / döntések\n6. Kilépés");
			do
			{
				{
					valasz = char.Parse(Console.ReadLine());
					if (char.IsNumber(valasz))
					{
						int ertek = valasz;
						if (ertek < 55 & ertek > 48)
						{
							switch (ertek)
							{
								case 49:
									Console.WriteLine();
									break;
								case 50:
									Console.WriteLine();
									break;
								case 51:
									Console.WriteLine();
									break;
								case 52:
									Console.WriteLine();
									break;
								case 53:
									Console.WriteLine();
									break;
								case 54:
									Console.WriteLine();
									test = false;
									break;
							}
						}
						else
						{
							Console.WriteLine("Helyes értéket adj meg!");
							valasz = char.Parse(Console.ReadLine());
						}
					}
					else
					{
						Console.WriteLine("Ne betűt adj meg!");
						valasz = char.Parse(Console.ReadLine());
					}
				}
			}
			while (test);
			User u1 = new User("Lajos", "UDLGO732", "Gépész");
			Console.WriteLine(u1);
		}
	}
}
