using System.Collections;

namespace M015;

internal class Program
{
	static void Main(string[] args)
	{
		Wagon w1 = new();
		Wagon w2 = new();
		
		Console.WriteLine(w1 == w2); //Speicheradressen werden verglichen (HashCodes)

		Zug z = new Zug();
		z++;
		z++;
		z++;
		z++;
		z++;

		Zug z2 = new();
		z2++;
		z2++;
		z2++;

		z += z2;

		foreach (Wagon w in z) //Wagons durchgehen mit foreach auf den Zug direkt anstatt auf die Liste
		{
			w.AnzSitze = 10;
		}

		Wagon eins = z[1];
		Wagon str = z["Rot", 3];
	}
}

public class Zug : IEnumerable
{
	private List<Wagon> Wagons = new();

	public static Zug operator ++(Zug z) //mit ++ einen Wagon hinzufügen
	{
		z.Wagons.Add(new Wagon());
		return z;
	}

	public static Zug operator +(Zug z1, Zug z2)
	{
		z1.Wagons.AddRange(z2.Wagons);
		return z1;
	}

	public IEnumerator GetEnumerator() => Wagons.GetEnumerator(); //Enumerator von der Wagons Liste weitergeben

	public Wagon this[int index] => Wagons[index];

	public Wagon this[string str, int sitze] => Wagons.First(e => e.Farbe == str && e.AnzSitze == sitze);
}

public class Wagon
{
	public int AnzSitze;

	public string Farbe;

	public static bool operator ==(Wagon w1, Wagon w2) //== erfordert auch !=
	{
		return w1.AnzSitze == w2.AnzSitze && w1.Farbe == w2.Farbe;
	}

	public static bool operator !=(Wagon w1, Wagon w2)
	{
		return !(w1 == w2);
	}
}