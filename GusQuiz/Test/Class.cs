using GusQuiz.Components;
using GusQuiz.Models;
using GusQuiz.Pages;
using Microsoft.Extensions.Options;
using Xunit;

namespace GusQuiz.Test
{
    public class Class
    {
        [Fact]
        public void TestPlayer1Score()
        {
            var TestQuiz = new QuizBase();
            TestQuiz.player1Score = 20;
            TestQuiz.player2Score = 10;

            Assert.True(TestQuiz.player1Score > TestQuiz.player2Score);
        }

        [Fact]
        public void TestPlayer2Score()
        {
            var TestQuiz = new QuizBase();
            TestQuiz.player1Score = 10;
            TestQuiz.player2Score = 20;

            Assert.True(TestQuiz.player2Score > TestQuiz.player1Score);
        }

        [Fact]
        public void TestPlayer1Wins()
        {
            var TestQuiz = new QuizBase();
            TestQuiz.player1Score = 10;
            TestQuiz.player2Score = 5;
            TestQuiz.player1Wins = 0;

            if (TestQuiz.player1Score > TestQuiz.player2Score)
            {
                TestQuiz.player1Wins++;
            }

            Assert.True(TestQuiz.player1Score > TestQuiz.player2Score);
            Assert.Equal(1, TestQuiz.player1Wins);
        }

        [Fact]
        public void TestPlayer2Wins()
        {
            var TestQuiz = new QuizBase();
            TestQuiz.player1Score = 5;
            TestQuiz.player2Score = 10;
            TestQuiz.player2Wins = 0;

            if (TestQuiz.player1Score < TestQuiz.player2Score)
            {
                TestQuiz.player2Wins++;
            }

            Assert.True(TestQuiz.player1Score < TestQuiz.player2Score);
            Assert.Equal(1, TestQuiz.player2Wins);
        }
    }
}

