using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
namespace YahtzeeTests
{
    [TestClass]
    public class YahtzeeRulesTests
    {
        [TestMethod]
        public void FiveOfAKindWorth50()
        {
            //Arrange
            int expected = 50;
            int die1 = 1, die2 = 1, die3 = 1, die4 = 1, die5 = 1;

            //Act
            int actual = (int)YahtzeeRules.determineScore(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }

        public void FourOnesAndOneTwoWorth0()
        {
            //Arrange
            int expected = 0;
            int die1 = 1, die2 = 1, die3 = 1, die4 = 1, die5 = 2;

            //Act
            int actual = (int)YahtzeeRules.determineScoresSecondTestCase(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }


        public void ThreeOfAKind() {
            int expected = 13;
            int die1 = 1, die2 = 1, die3 = 1, die4 = 4, die5 = 6;

            //Act
            int actual = (int)YahtzeeRules.addDies(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }
        public void FourOfAKind() {
            int expected = 12;
            int die1 = 2, die2 = 2, die3 = 2, die4 = 2, die5 = 4;

            //Act
            int actual = (int)YahtzeeRules.addDies(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }

        public void FullHouse() {
            int expected = 25;
            int die1 = 3, die2 = 3, die3 = 3, die4 = 5, die5 = 5;

            //Act
            int actual = (int)YahtzeeRules.determineFullHouse(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }

        public void SmallStraight() {
            int expected = 30;
            int die1 = 2, die2 = 2, die3 = 3, die4 = 4, die5 = 5;

            //Act
            int actual = (int)YahtzeeRules.determineSmallStraight(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }

        public void LargeStraight() {
            int expected = 40;
            int die1 = 2, die2 = 2, die3 = 3, die4 = 4, die5 = 5;

            //Act
            int actual = (int)YahtzeeRules.determineLargeStraight(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }

        public void Chance() {
            int expected = 21;
            int die1 = 6, die2 = 6, die3 = 2, die4 = 2, die5 = 5;

            //Act
            int actual = (int)YahtzeeRules.addDies(die1, die2, die3, die4, die5);

            //Assert
            Assert.AreEqual(expected, actual, "Yahtzee score not correct");
        }

    }
}
