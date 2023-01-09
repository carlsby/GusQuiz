using Microsoft.AspNetCore.Components;
using GusQuiz.Models;

namespace GusQuiz.Pages
{
    public class QuizBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<Question2> Questions2 { get; set; } = new List<Question2>();
        protected int questionIndex = 0;
        protected int questionIndex2 = 0;
        protected int score = 0;

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();
            LoadQuestions2();
            return base.OnInitializedAsync();
        }

        protected void OptionSelected(string option)
        {
            if (option == Questions[questionIndex].Answer || option == Questions2[questionIndex2].Answer)
            {
                score++;
            }
            questionIndex++;
            questionIndex2++;
        } 

        protected void RestartQuiz()
        {
            score = 0;
            questionIndex= 0;
            questionIndex2 = 0;
        }

        private void LoadQuestions()
        {
            Question q1 = new Question
            {
                NameOfQuestion = "Who is the best footballplayer in the world?",
                Options = new List<string>() { "Cristiano Ronaldo", "Bukayo Saka", "Lionel Messi", "Harry Maguire" },
                Answer = "Harry Maguire",
                Category = "Sports"
            };

            Question q2 = new Question
            {
                NameOfQuestion = "Which two players were tied for most goals in the 2021/2022 season?",
                Options = new List<string>() { "Cristiano Ronaldo & Son Heung-Min", "Son Heung-Min & Sadio Mane", "Mohamed Salah & Son Heung-Min", "Mohamed Salah & Cristiano Ronaldo" },
                Answer = "Mohamed Salah & Son Heung-Min",
                Category = "Sports"
            };

            Question q3 = new Question
            {
                NameOfQuestion = "Which player had the most assists in the 2021/2022 season?",
                Options = new List<string>() { "Trent Alexander-Arnold", "Mason Mount", "Andrew Robertson", "Mohamed Salah" },
                Answer = "Mohamed Salah",
                Category = "Sports"
            };

            Question q4 = new Question
            {
                NameOfQuestion = "Which two goalkeepers were tid for most clean sheets in the 2021/2022 season?",
                Options = new List<string>() { "Ederson & Alisson", "Hugo Lloris & Alisson", "Hugo Lloris & David De Gea", "David De Gea & Ederson" },
                Answer = "Ederson & Alisson",
                Category = "Sports"
            };
            Questions.AddRange(new List<Question> { q1, q2, q3, q4 });
        }

        private void LoadQuestions2()
        {
            Question2 q1 = new Question2
            {
                NameOfQuestion = "Vad heter Gustav?",
                Options = new List<string>() { "Gustav", "Gorkuva", "Dkes", "Harry Maguire" },
                Answer = "Gustav",
                Category = "Public Knowledge"
            };

            Question2 q2 = new Question2
            {
                NameOfQuestion = "Which two players were tied for most goals in the 2021/2022 season?",
                Options = new List<string>() { "Cristiano Ronaldo & Son Heung-Min", "Son Heung-Min & Sadio Mane", "Mohamed Salah & Son Heung-Min", "Mohamed Salah & Cristiano Ronaldo" },
                Answer = "Mohamed Salah & Son Heung-Min",
                Category = "Sports"
            };

            Question2 q3 = new Question2
            {
                NameOfQuestion = "Which player had the most assists in the 2021/2022 season?",
                Options = new List<string>() { "Trent Alexander-Arnold", "Mason Mount", "Andrew Robertson", "Mohamed Salah" },
                Answer = "Mohamed Salah",
                Category = "Sports"
            };

            Question2 q4 = new Question2
            {
                NameOfQuestion = "Which two goalkeepers were tid for most clean sheets in the 2021/2022 season?",
                Options = new List<string>() { "Ederson & Alisson", "Hugo Lloris & Alisson", "Hugo Lloris & David De Gea", "David De Gea & Ederson" },
                Answer = "Ederson & Alisson",
                Category = "Sports"
            };
            Questions2.AddRange(new List<Question2> { q1, q2, q3, q4 });
        }
    }
}
