using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace M014;

internal class Program
{
	static void Main(string[] args)
	{
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Pfad zum Desktop

		string folderPath = Path.Combine(desktop, "M014"); //Path.Combine: beliebig viele Pfade kombinieren

		if (!Directory.Exists(folderPath)) //Schauen ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Wenn nicht, Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		//BasicStreams();

		//NewtonsoftJson();

		//Json();

		//Xml();

		//Binary();

		//CSV();
	}

	public static void BasicStreams()
	{
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Pfad zum Desktop

		string folderPath = Path.Combine(desktop, "M014"); //Path.Combine: beliebig viele Pfade kombinieren

		if (!Directory.Exists(folderPath)) //Schauen ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Wenn nicht, Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		StreamWriter sw = new StreamWriter(filePath); //Stream öffnen
		sw.WriteLine("Test1"); //Inhalt in den Stream schreiben (noch nicht auf die Festplatte)
		sw.WriteLine("Test2");
		sw.WriteLine("Test3");
		sw.Close(); //Stream schließen

		StreamReader sr = new StreamReader(filePath);
		string s = sr.ReadToEnd(); //Ganzes File einlesen (unpraktisch bei 100_000+ Zeilen)
		string[] zeilen = s.Split("\n");
		sr.Close();

		using (StreamWriter sw2 = new StreamWriter(filePath)) //Using-Block: schließt Stream am Ende des Blocks, StreamWriter nur im Block sichtbar
		{
			sw2.WriteLine("Test1");
			sw2.WriteLine("Test2");
			sw2.WriteLine("Test3");
		} //sw2 schließen

		using StreamWriter sw3 = new StreamWriter(filePath); //Using vor StreamWriter schließt den Stream am Ende der Methode
		sw3.WriteLine("Test1");
		sw3.WriteLine("Test2");
		sw3.WriteLine("Test3");
	} //sw3 schließen

	public static void NewtonsoftJson()
	{
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Pfad zum Desktop

		string folderPath = Path.Combine(desktop, "M014"); //Path.Combine: beliebig viele Pfade kombinieren

		if (!Directory.Exists(folderPath)) //Schauen ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Wenn nicht, Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		string json = JsonConvert.SerializeObject(fahrzeuge); //Objekt zu Json konvertieren
		File.WriteAllText(filePath, json); //Json in File schreiben

		string readJson = File.ReadAllText(filePath); //Json einlesen
		List<Fahrzeug> readFzg = JsonConvert.DeserializeObject<List<Fahrzeug>>(readJson); //Json String zu Objektliste konvertieren
	}

	public static void Json()
	{
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Pfad zum Desktop

		string folderPath = Path.Combine(desktop, "M014"); //Path.Combine: beliebig viele Pfade kombinieren

		if (!Directory.Exists(folderPath)) //Schauen ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Wenn nicht, Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		string json = System.Text.Json.JsonSerializer.Serialize(fahrzeuge);
		File.WriteAllText(filePath, json);

		string readJson = File.ReadAllText(filePath);
		List<Fahrzeug> readFzg = System.Text.Json.JsonSerializer.Deserialize<List<Fahrzeug>>(readJson);
	}

	public static void Xml()
	{
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Pfad zum Desktop

		string folderPath = Path.Combine(desktop, "M014"); //Path.Combine: beliebig viele Pfade kombinieren

		if (!Directory.Exists(folderPath)) //Schauen ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Wenn nicht, Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		XmlSerializer xmlS = new XmlSerializer(fahrzeuge.GetType()); //Hier keine statischen Zugriffspunkte, Typ(en) zum Serialisieren müssen angegeben werden
		using (FileStream fs = new FileStream(filePath, FileMode.Create)) //FileStream muss bei XML erstellt werden
			xmlS.Serialize(fs, fahrzeuge); //XML schreiben

		using FileStream readStream = new FileStream(filePath, FileMode.Open); //Diesmal FileStream mit Open erstellen
		List<Fahrzeug> readFzg = (List<Fahrzeug>) xmlS.Deserialize(readStream) as List<Fahrzeug>; //Hier Deserialize mit Cast (entweder mit () oder mit as)
	}

	public static void Binary()
	{
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Pfad zum Desktop

		string folderPath = Path.Combine(desktop, "M014"); //Path.Combine: beliebig viele Pfade kombinieren

		if (!Directory.Exists(folderPath)) //Schauen ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Wenn nicht, Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		BinaryFormatter binary = new BinaryFormatter(); //Hier keine statischen Zugriffspunkte
		using (FileStream fs = new FileStream(filePath, FileMode.Create)) //FileStream muss bei Binary auch erstellt werden
			binary.Serialize(fs, fahrzeuge); //XML schreiben

		using FileStream readStream = new FileStream(filePath, FileMode.Open); //Diesmal FileStream mit Open erstellen
		List<Fahrzeug> readFzg = (List<Fahrzeug>) binary.Deserialize(readStream) as List<Fahrzeug>; //Hier Deserialize mit Cast (entweder mit () oder mit as)
	}

	public static void CSV()
	{
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Pfad zum Desktop

		string folderPath = Path.Combine(desktop, "M014"); //Path.Combine: beliebig viele Pfade kombinieren

		if (!Directory.Exists(folderPath)) //Schauen ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Wenn nicht, Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		TextFieldParser tfp = new TextFieldParser(filePath); //TextFieldParse für CSV
		tfp.SetDelimiters(";"); //Trennzeichen setzen (meistens ;)
		tfp.ReadFields(); //In einer Schleife verwenden um CSV einzulesen
	}
}

[DebuggerDisplay("Marke: {Marke}, Geschwindigkeit: {MaxGeschwindigkeit} - {typeof(Fahrzeug).FullName}")]
[Serializable] //Für Binary hier Serializable setzen
public class Fahrzeug
{
	public int MaxGeschwindigkeit;

	public FahrzeugMarke Marke;

	public Fahrzeug(int v, FahrzeugMarke fm)
	{
		MaxGeschwindigkeit = v;
		Marke = fm;
	}

	public Fahrzeug()
	{

	}
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}