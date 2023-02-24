namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void PorównanieTypówInt()
        {
            //arrange
            int number1 = 5;
            int number2 = 5;
            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void PorównanieTypówFloat()
        {
            //arrange
            float number1 = 1.5e+22f;
            float number2 = 1.5e+22f;
            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void PorównanieTypówString()
        {
            //arrange
            string name1 = "Ola";
            string name2 = "Ola";
            //assert
            Assert.AreEqual(name1, name2);
        }
       
    }
}
