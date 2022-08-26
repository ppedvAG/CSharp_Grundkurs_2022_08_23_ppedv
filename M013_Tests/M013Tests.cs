using M013;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace M013_Tests
{
	[TestClass]
	public class M013Tests
	{
		Rechner r;

		[TestInitialize] //Vor allen Tests diesen Code ausführen
		public void Init()
		{
			r = new();
		}

		[TestCleanup] //Nach allen Tests diesen Code ausführen
		public void Cleanup()
		{
			r = null;
		}

		[TestCategory("Erfolgstest")] //Kategorie im Test Explorer hinzufügen
		[TestMethod]
		public void TesteAddiere()
		{
			int ergebnis = r.Addiere(3, 8);
			Assert.AreEqual(11, ergebnis);
		}

		[TestCategory("Fehlertest")] //Kategorie im Test Explorer hinzufügen
		[TestMethod]
		public void TesteSubtrahiereFehler()
		{
			int diff = r.Subtrahiere(7, 3);
			Assert.AreNotEqual(2, diff);
		}
	}
}