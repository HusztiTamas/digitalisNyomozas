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
			Console.WriteLine("1. Új ügy felvétele\n2. Személy hozzáadása ügyhöz\n3. Bizonyíték rögzítése\n4. Ügy állapotának módosítása\n5. Idővonal esemény hozzáadása\n6. Gyanúsított értékelése bizonyítékok alapján");
			valasz = char.Parse(Console.ReadLine());
			while (test)
			{
				{
					if (char.IsNumber(valasz))
					{
						int ertek = valasz;
						if (ertek < 55 & ertek > 48)
						{
							switch (ertek)
							{
								case 49:
									Console.WriteLine("Új ügy felvétele");
									break;
								case 50:
									Console.WriteLine("Személy hozzáadása ügyhöz");
									break;
								case 51:
									Console.WriteLine("Bizonyíték rögzítése");
									break;
								case 52:
									Console.WriteLine("Ügy állapotának módosítása");
									break;
								case 53:
									Console.WriteLine("Idővonal esemény hozzáadása");
									break;
								case 54:
									Console.WriteLine("Gyanúsított értékelése bizonyítékok alapján");
									break;
							}
							test = false;
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
			User u1 = new User("Lajos", "UDLGO732", "Gépész");
			Console.WriteLine(u1);
		}
	}
}
