using System;

namespace M006;

/// <summary>
/// Die Person Klasse
/// </summary>
class Person
{
	#region Variable
	/// <summary>
	/// Das Feld vom Nachnamen
	/// </summary>
	private string nachname;

	public string GetName()
	{
		return nachname;
	}

	public void SetName(string neuerName)
	{
		if (neuerName.Length >= 2 && neuerName.Length <= 20)
			nachname = neuerName;
	}
	#endregion

	#region Properties
	private string vorname;

	/// <summary>
	/// Das Vorname Property
	/// </summary>
	public string Vorname //Property statt Get/Set Methoden
	{
		get => vorname; //Expression Body mit => statt { } und return bei Einzeilern
		set
		{
			//value: string neuerName von oben
			if (value.Length >= 2 && value.Length <= 20) //Checks auch wieder einbauen
				vorname = value;
		}
	}

	private int gehalt;

	public int Gehalt
	{
		get => gehalt;
		private set => gehalt = value; //Gehalt kann von außen nicht gesetzt werden
	}

	public int Jahresgehalt //Get-Only Property
	{
		get => gehalt * 14;
	}

	//public int Jahresgehalt => gehalt * 14; Kurzform von Get-Only Property

	public string Lieblingsfarbe { get; set; } = "Blau"; //Standardwert setzen
	#endregion

	#region Konstruktor
	//Konstruktor: Entwickler dazu zwingen bestimmte Standardwerte zu übergeben
	public Person(string vorname, string nachname) //Standardkonstruktor wird überschrieben
	{
		this.vorname = vorname; //mit this nach oben greifen
		this.nachname = nachname;
	}

	/// <summary>
	/// Der Konstruktor mit Gehalt
	/// </summary>
	/// <param name="vorname">Der Vorname</param>
	/// <param name="nachname">Der Nachname</param>
	/// <param name="gehalt">Das Gehalt</param>
	public Person(string vorname, string nachname, int gehalt) : this(vorname, nachname) //Konstruktoren verketten
	{
		this.gehalt = gehalt;
	}

	/// <summary>
	/// Ein Standardkonstruktor, der Test auf die Konsole schreibt
	/// </summary>
	public Person() => Console.WriteLine("Test"); //Expression Body auch hier möglich (Einzeiler)
	#endregion

	/// <summary>
	/// Eine Ausgabe der Person wird durch diese Methode auf die Konsole geschrieben
	/// </summary>
	public void PrintPerson() => Console.WriteLine($"{Vorname} {GetName()}"); //Expression Body auch hier möglich (Einzeiler)
}
