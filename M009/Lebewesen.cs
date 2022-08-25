namespace M009;

public abstract class Lebewesen //abstract: Strukturklasse, Entwickler muss Methoden die abstract sind selber implementieren
{
	public string Name { get; set; }

	public Lebewesen(string name) => Name = name;

	public abstract void WasBinIch(); //Methode ohne body, weil abstract
}

public class Mensch : Lebewesen //Mensch ist ein Lebewesen (Vererbung herstellen)
{
	public int Alter { get; set; }

	public Mensch(string name, int alter) : base(name) //Konstruktoren verketten mit base(...)
	{
		Alter = alter;
	}

	public override void WasBinIch() //mit override eine Abstrakte Methode implementieren
	{
		Console.WriteLine($"Ich bin ein Mensch, mein Name ist {Name} und bin {Alter} Jahre alt");
	}

	public void MenschMethode()
	{

	}

	//public new void WasBinIch() => Console.WriteLine($"Ich bin ein Mensch und bin {Alter} Jahre alt"); //Keine Überschreibung sondern nur versteckt

	//public sealed override void WasBinIch() //override: Überschreibe die Methode von oben, obere muss Methode muss virtual sein
	//{
	//	//base.WasBinIch(); //base: nach oben greifen in der Vererbungshierarchie
	//	Console.WriteLine($"Ich bin ein Mensch, mein Name ist {Name} und bin {Alter} Jahre alt"); //Name wird vererbt
	//}
}

public class Hund : Lebewesen
{
	public Hund(string name) : base(name)
	{
	}

	public override void WasBinIch()
	{
		throw new NotImplementedException();
	}

	public void HundMethode()
	{

	}
}