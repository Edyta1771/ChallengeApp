namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeGradesAverage_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(4);
            employee.AddGrade(7);
            employee.AddGrade(3);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.That(Math.Round(4.666666, 2), Is.EqualTo(Math.Round(statistics.Average, 2)));
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
            Assert.That(statistics.Max, Is.EqualTo(7));
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
            Assert.That(statistics.Min, Is.EqualTo(3));
        }
    }
}