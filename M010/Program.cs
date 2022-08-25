namespace M010;

internal class Program
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch();
		//m.Lohnauszahlung();
		//m.Test(); nicht möglich, da Methode im Interface definiert wurde

		IArbeit arbeit = new Mensch();
		arbeit.Test();
		arbeit.Lohnauszahlung(); //IArbeit Lohnauszahlung aufrufen über Variablentyp

		ITeilzeitArbeit arbeit2 = (ITeilzeitArbeit) arbeit;
		arbeit2.Lohnauszahlung(); //ITeilzeitArbeit Lohnauszahlung aufrufen über Variablentyp

		m.CompareTo(arbeit);

		if (m is IArbeit)
		{
			//Hat der Mensch das Interface?
		}
	}
}

public interface IArbeit //Interfaces fangen per Konvention mit I an
{
	static int Wochenstunden = 40; //Statische Felder müssen keine Properties sein

	int Gehalt { get; set; }

	string Job { get; set; } //Properties werden weitergegeben

	void Lohnauszahlung(); //Methode ohne Body wie bei Abstraken Methoden

	public void Test()
	{
		//Bad Practice
	}
}

public interface ITeilzeitArbeit : IArbeit
{
	static new int Wochenstunden = 20;

	new void Lohnauszahlung();
}

public abstract class Lebewesen { }

public class Mensch : Lebewesen, IArbeit, ITeilzeitArbeit, ICloneable, IComparable //Klassenvererbung muss vor Interfaces kommen
{
	public int Gehalt { get; set; } = 3000;

	public string Job { get; set; } = "Softwareentwickler";

	void IArbeit.Lohnauszahlung()
	{
		Console.WriteLine($"Dieser Mitarbeiter hat ein Gehalt von {Gehalt}€ für den Job {Job} bekommen. " +
			$"Er arbeitet {IArbeit.Wochenstunden} Stunden pro Woche."); //Auf statische Variable zugreifen
	}

	void ITeilzeitArbeit.Lohnauszahlung()
	{
		Console.WriteLine($"Dieser Mitarbeiter hat ein Gehalt von {Gehalt / 2}€ für den Job {Job} bekommen. " +
			$"Er arbeitet {ITeilzeitArbeit.Wochenstunden} Stunden pro Woche."); //Auf statische Variable zugreifen
	}

	public object Clone()
	{
		return new Mensch() { Gehalt = this.Gehalt, Job = this.Job };
	}

	public int CompareTo(object? obj)
	{
		return 0;
	}
}