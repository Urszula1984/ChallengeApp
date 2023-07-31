namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployee1ScoreSum_ShouldReturnCorrectResult()
        {
            //  arrange
            var employee1 = new Employee("Roman", "Szczêœliwy", 39);
            employee1.AddScore(5);
            employee1.AddScore(4);
            employee1.AddScore(-9);

            //act
            var result1 = employee1.Result;

            //assert
            Assert.AreEqual(0, result1);
        }
        [Test]

        public void WhenEmployee2ScoreSum_ShouldReturnCorrectResult()
        {
            var employee2 = new Employee("Zbigniew", "Zmêczony", 46);
            employee2.AddScore(7);
            employee2.AddScore(6);
            employee2.AddScore(-7);

            var result2 = employee2.Result;
            Assert.AreEqual(6, result2);

        }
        [Test]
        public void WhenEmployee3ScoreSum_ShouldReturnCorrectResult()
        {
            var employee3 = new Employee("Mariola", "Radosna", 68);
            employee3.AddScore(8);
            employee3.AddScore(6);
            employee3.AddScore(-1);

            var result3 = employee3.Result;

            Assert.AreEqual(13, result3);
        }
    }
}
