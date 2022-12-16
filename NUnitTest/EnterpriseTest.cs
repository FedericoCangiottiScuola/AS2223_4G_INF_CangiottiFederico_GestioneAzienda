using AziendaDLL;

namespace EnterpriseTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddEmployee_Test()
        {
            Administration administrator = new Administration("Orazio", "Rossi", 46, (float)1746.89, 8);

            Department department = new Department("test", administrator, 4);

            Assert.That(department.AddEmployee(administrator), Is.EqualTo(true));   // si può inserire
            Assert.That(department.AddEmployee(administrator), Is.EqualTo(true));   // si può inserire
            Assert.That(department.AddEmployee(administrator), Is.EqualTo(true));   // si può inserire
            Assert.That(department.AddEmployee(administrator), Is.EqualTo(false));  // non si può inserire
        }
    }
}
