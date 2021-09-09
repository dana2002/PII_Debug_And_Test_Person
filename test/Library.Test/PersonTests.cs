using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Dana Castroman", "5.257.460-1", "26/7/2002");
            string expected = "Dana Castroman";
            Assert.AreEqual(expected, p.Name);
            // Insertá tu código  de pruebaaquí
        }

        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Dana Castroman", "5.257.460-", "26/7/2002");
            string expected = null;
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestFecha_nac() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Dana Castroman", "5.257.460-1", "26/7/2002");
            string expected = "26/7/2002";
            Assert.AreEqual(expected, p.Fecha_nac);
        }
    }
}