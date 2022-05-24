using NUnit.Framework;

namespace QA.Test
{
    public class Tests
    {
        [Test]
        public void Plus_Return_25()
        {
            //Arrange
            Program program = new Program();
            int x = 15;
            int y = 10;
            int result = 25;

            //Act
            int response = program.Plus(x,y);

            //Assert
            Assert.AreEqual(result, response);
        }

        [Test]
        public void Minus_Return_5()
        {
            //Arrange
            Program program = new Program();
            int x = 15;
            int y = 10;
            int result = 5;

            //Act
            int response = program.Minus(x, y);

            //Assert
            Assert.AreEqual(result, response);
        }

        [Test]
        public void Multiple_Return_150()
        {
            //Arrange
            Program program = new Program();
            int x = 15;
            int y = 10;
            int result = 150;

            //Act
            int response = program.Multiple(x, y);

            //Assert
            Assert.AreEqual(result, response);
        }

        [Test]
        public void Division_Return_OneDotFive()
        {
            //Arrange
            Program program = new Program();
            int x = 15;
            int y = 10;
            float result = 1.5f;

            //Act
            float response = program.Division(x, y);

            //Assert
            Assert.AreEqual(result, response);
        }
    }
}