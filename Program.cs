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
		}
	}
}
