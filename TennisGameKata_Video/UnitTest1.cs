﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameKata_Video
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void love_all()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScoreTimes(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fiftten()
        {
            tennisGame.SecondPlayerScore();
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            tennisGame.FirstPlayerScore();
            tennisGame.SecondPlayerScore();
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScoreTimes(2);
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce_When_3_3()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_When_4_4()
        {
            GivenFirstPlayerScoreTimes(4);
            GivenSecondPlayerScoreTimes(4);
            ScoreShouldBe("Deuce");
        }
        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            string score = tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}