using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
            this.person = new Person("Gonzalo", "5.126.332-8");
        }

        [Test]
        public void Test() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
        }

        [Test]
        public void TestEmptyName()
        {
            this.person.Name = "";
            Assert.AreEqual("Gonzalo", this.person.Name, "La clase Person permite nombres vacíos");
        }

        [Test]
        public void TestEmptyID()
        {
            this.person.ID = "";
            Assert.AreEqual("5.126.332-8", this.person.ID, "La clase Person permite ID vacíos");
        }

        [Test]
        public void TestInvalidId()
        {
            this.person.ID = "5.126.332-1";
            bool validId = IdUtils.IdIsValid(this.person.ID);
            Assert.IsTrue(validId, "Se permiten Cédulas inválidas");
        }
    }
}