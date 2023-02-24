namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeGradesAverage_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();  
            
            //assert
            Assert.AreEqual(5, statistics.Average);
        }

        [Test]
        public void EmployeeGradesMax_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();
            
            //assert
            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void EmployeeGradesMin_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, statistics.Min);
        }
    }
}