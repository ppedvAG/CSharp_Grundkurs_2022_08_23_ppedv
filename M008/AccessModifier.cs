namespace M008;

class AccessModifier //Klassen/Member ohne Modifier sind internal
{
	public string Name { get; set; } //Kann überall gesehen werden (auch außerhalb vom Projekt)

	private int Groesse { get; set; } //Kann nur in dieser Klasse gesehen werden

	internal string Wohnort { get; set; } //Kann überall aber nur in diesem Projekt gesehen werden


	protected string Lieblingsfarbe { get; set; } //Kann nur in dieser Klasse und in Unterklassen gesehen werden, auch außerhalb vom Projekt (effektiv private aber funktioniert auch in Vererbungshierarchien)

	protected internal string Lieblingsnahrung { get; set; } //Kann im Projekt überall gesehen werden und in Unterklassen außerhalb vom Projekt

	protected private DateTime Geburtsdatum { get; set; } //Kann nur in dieser Klasse und Unterklasse nur im Projekt gesehen werden
}
