namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeGradesAverage_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(24);
            employee.AddGrade(58);
            employee.AddGrade(63);
            employee.AddGrade("7");
            employee.AddGrade(55);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(statistics.Average, 2), (Math.Round(41.4, 2)));
        }

        [Test]
        public void EmployeeGradesAverageLetter_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(24);
            employee.AddGrade(58);
            employee.AddGrade(63);
            employee.AddGrade("7");
            employee.AddGrade(55);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.AverageLetter, 'C');
        }

        [Test]
        public void EmployeeGradesMax_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(24);
            employee.AddGrade(58);
            employee.AddGrade(63);
            employee.AddGrade("7");
            employee.AddGrade(55);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Max, 63);
        }

        [Test]
        public void EmployeeGradesMin_Check()
        {
            //arrange
            var employee = new Employee("Alina", "Bukowska");
            employee.AddGrade(24);
            employee.AddGrade(58);
            employee.AddGrade(63);
            employee.AddGrade("7");
            employee.AddGrade(55);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Min, 7);
        }
    }
}