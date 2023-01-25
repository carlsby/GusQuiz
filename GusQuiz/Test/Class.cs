using GusQuiz.Components;
using GusQuiz.Models;
using Microsoft.Extensions.Options;
using Xunit;

namespace GusQuiz.Test
{
    public class Class
    {
        [Fact]
        public void TestPlayer1Score()
        {
            int player1Score = 20;
            int player2Score = 10;

            Assert.True(player1Score > player2Score);
        }

        [Fact]
        public void TestPlayer2Score()
        {
            int player1Score = 10;
            int player2Score = 20;

            Assert.True(player2Score > player1Score);
        }

        [Fact]
        public void QuizTest()
        {
            string question1 = "test1";
            string player1 = question1;

            Assert.True(player1 == question1);
        }

        [Fact]
        public void TestPlayer1Wins()
        {
            int player1Score = 10;
            int player2Score = 5;
            int player1Wins = 0;

            if (player1Score > player2Score)
            {
                player1Wins++;
            }

            Assert.True(player1Score > player2Score);
            Assert.Equal(1, player1Wins);
        }

        [Fact]
        public void TestPlayer2Wins()
        {
            int player1Score = 5;
            int player2Score = 10;
            int player2Wins = 0;

            if (player1Score < player2Score)
            {
                player2Wins++;
            }

            Assert.True(player1Score < player2Score);
            Assert.Equal(1, player2Wins);
        }
    }
}

