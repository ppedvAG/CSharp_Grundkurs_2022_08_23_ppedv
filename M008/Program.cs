namespace M008;

internal class Program
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch("Max", 32);
		m.WasBinIch(); //Nicht im Mensch definiert aber trotzdem möglich
	}
}

public class Lebewesen //Basisklasse
{
	public string Name { get; set; }

	public Lebewesen(string name) => Name = name;

	public virtual void WasBinIch() //Wird auch nach unten vererbt
	{
		Console.WriteLine("Ich bin ein Lebewesen");
	}
}

public sealed class Mensch : Lebewesen //Mensch ist ein Lebewesen (Vererbung herstellen)
{
	public int Alter { get; set; }

	public Mensch(string name, int alter) : base(name) //Konstruktoren verketten mit base(...)
	{
		Alter = alter;
	}

	//public void WasBinIch() => Console.WriteLine($"Ich bin ein Mensch und bin {Alter} Jahre alt"); //Keine Überschreibung sondern nur versteckt

	public sealed override void WasBinIch() //override: Überschreibe die Methode von oben, obere muss Methode muss virtual sein
	{
		//base.WasBinIch(); //base: nach oben greifen in der Vererbungshierarchie
		Console.WriteLine($"Ich bin ein Mensch, mein Name ist {Name} und bin {Alter} Jahre alt"); //Name wird vererbt
	}
}

//public class Kind : Mensch //Vererbung nicht möglich weil Mensch sealed ist
//{
//	public Kind(string name, int alter) : base(name, alter) { }
//
//	public override void WasBinIch() { } nicht möglich, weil sealed
//}