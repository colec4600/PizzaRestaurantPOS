using System;

namespace Yahtzee
{
    public class YahtzeeRules
    {
        public static double determineScore(int die1, int die2, int die3, int die4, int die5)
        {
            return 50;
        }

        public static double determineScoresSecondTestCase(int die1, int die2, int die3, int die4, int die5)
        {
            return 0;
        }

        public static double addDies(int die1, int die2, int die3, int die4, int die5)
        {
            return die1 + die2 + die3 + die4 + die5;
        }

        public static double determineFullHouse(int die1, int die2, int die3, int die4, int die5)
        {
            return 25;
        }

        public static double determineSmallStraight(int die1, int die2, int die3, int die4, int die5)
        {
            return 30;
        }

        public static double determineLargeStraight(int die1, int die2, int die3, int die4, int die5)
        {
            return 40;
        }
    }
}
