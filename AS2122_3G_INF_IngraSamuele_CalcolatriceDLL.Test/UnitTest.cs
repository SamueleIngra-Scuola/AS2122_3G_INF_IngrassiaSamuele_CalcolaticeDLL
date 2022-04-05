using NUnit.Framework;
using AS2122_3G_INF_IngraSamuele_CalcolatriceDLL.Library;

namespace AS2122_3G_INF_IngraSamuele_CalcolatriceDLL.Test
{
    public class Tests
    {
        Operazioni o;

        [SetUp]
        public void Setup()
        {
            o = new Operazioni();
        }

        [Test]
        public void TestSomma()
        {
            Assert.IsTrue(o.Somma(2, 3) == 5);
            Assert.IsTrue(o.Somma(6, 0) == 6);
            Assert.IsTrue(o.Somma(6, -7) == -1);
        }

        [Test]
        public void TestDifferenza()
        {
            Assert.IsTrue(o.Differenza(2, 3) == -1);
            Assert.IsTrue(o.Differenza(3, 2) == 1);
            Assert.IsTrue(o.Differenza(6, 0) == 6);
        }

        [Test]
        public void TestMoltiplicazione()
        {
            Assert.IsTrue(o.Moltiplicazione(2, 3) == 6);
            Assert.IsTrue(o.Moltiplicazione(3, 1) == 3);
            Assert.IsTrue(o.Moltiplicazione(6, 0) == 0);
            Assert.IsTrue(o.Moltiplicazione(4, -1) == -4);
        }

        [Test]
        public void TestDivisione()
        {
            Assert.IsTrue(o.Divisione(6, 2) == 3);
            Assert.IsTrue(o.Divisione(3, 1) == 3);
            Assert.IsTrue(o.Divisione(6, 6) == 1);
        }

        [Test]
        public void TestFattoriale()
        {
            Assert.IsTrue(o.Fattoriale(5) == 120);
            Assert.IsTrue(o.Fattoriale(3) == 6);
        }
    }
}
}