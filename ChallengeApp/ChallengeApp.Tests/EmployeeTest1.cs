namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectsScores_ShouldFetCorrectResult()
        {
            //arrange
            var employee1 = new Employee("Alina", "Bukowska", "33");
            employee1.AddScore(5);
            employee1.AddScore(7);
            employee1.AddScore(-7);

            //act
            var result = employee1.Result;

            //assert
            Assert.AreEqual(5, result);
        }
    }
}