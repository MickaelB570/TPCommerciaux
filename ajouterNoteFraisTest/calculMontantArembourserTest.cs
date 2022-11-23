using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BiblioClasse;

namespace ajouterNoteFraisTest
{
    [TestClass]
    public class calculMontantArembourserTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            Commercial c = new Commercial("Darius", "Kugel",9, 'C');
            Commercial c1 = new Commercial("Hamid", "Lekbouri", 11 , 'B');
            Commercial c2 = new Commercial("René", "Belardi", 4, 'A');

            NoteFrais f1 = new NoteTransport(new DateTime(2015, 12, 03), c, 200);
            Assert.AreEqual(40, f1.calculMontantARembourser());
            NoteFrais f2 = new NoteTransport(new DateTime(2015, 12, 03), c1, 200);
            Assert.AreEqual(60, f2.calculMontantARembourser());
            NoteFrais f3 = new NoteTransport(new DateTime(2015, 12, 03), c2, 200);
            Assert.AreEqual(20, f3.calculMontantARembourser());



            NoteFrais f6 = new NoteRepas(new DateTime(2015, 10, 23), c1, 15);
            Assert.AreEqual(15, f6.calculMontantARembourser());
            NoteFrais f7 = new NoteRepas(new DateTime(2015, 10, 23), c1, 25);
            Assert.AreEqual(22, f7.calculMontantARembourser());

            NoteFrais f8 = new NoteRepas(new DateTime(2015, 10, 23), c2, 28);
            Assert.AreEqual(25, f8.calculMontantARembourser());
            NoteFrais f9 = new NoteRepas(new DateTime(2015, 10, 23), c2, 18);
            Assert.AreEqual(18, f9.calculMontantARembourser());





            NoteFrais f13 = new NoteNuit(new DateTime(2015, 10, 23), c1, 60, 2);
            Assert.AreEqual(60, f13.calculMontantARembourser());
            NoteFrais f14 = new NoteNuit(new DateTime(2015, 10, 23), c1, 60, 3);
            Assert.AreEqual(60, f14.calculMontantARembourser());
            NoteFrais f15 = new NoteNuit(new DateTime(2015, 10, 23), c1, 50, 1);
            Assert.AreEqual(49.5, f15.calculMontantARembourser());

            NoteFrais f16 = new NoteNuit(new DateTime(2015, 10, 23), c2, 76, 2);
            Assert.AreEqual(71.5, f16.calculMontantARembourser());
            NoteFrais f17 = new NoteNuit(new DateTime(2015, 10, 23), c2, 80, 3);
            Assert.AreEqual(74.75, f17.calculMontantARembourser());
            NoteFrais f18 = new NoteNuit(new DateTime(2015, 10, 23), c2, 46, 1);
            Assert.AreEqual(46, f18.calculMontantARembourser());

        }
    }
}
