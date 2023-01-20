using Microsoft.AspNetCore.Components;
using GusQuiz.Models;
using System.Xml.Linq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Linq;

namespace GusQuiz.Pages
{
    public class QuizBase : ComponentBase
    {
        public List<QuestionFrenchCuisine> QuestionsFrenchCuisine { get; set; } = new List<QuestionFrenchCuisine>();
        public List<Question> Questions { get; set; } = new List<Question>();


        protected int questionIndex6 = 0;
        protected int questionIndex5 = 0;
        protected int questionIndex4 = 0;
        protected int questionIndex23 = 0;
        protected int player1Score = 0;
        protected int player2Score = 0;
        protected bool röv = false;
        protected bool bajs = true;
        protected int player1Wins = 0;
        protected int player2Wins = 0;
        protected string player1 = "";
        protected string player2 = "";
        protected int kuken = 0;
        protected int golfCount = 0;
        protected int hockeyCount = 5;
        protected int tennisCount = 9;
        protected int musicCount = 14;
        protected int movieCount = 20;
        protected int carsCount = 24;
        protected int videoGamesCount = 28;
        protected int footballCount = 32;
        protected override Task OnInitializedAsync()
        {
            LoadQuestions();
            return base.OnInitializedAsync();
        }

        public void OptionSelected(string option)
        {
            if (option == Questions[kuken].Answer)
            {
                player1Score++;
            }

            questionIndex23++;
        }

        protected void OptionSelected2(string option)
        {
            if (option == Questions[kuken].Answer)
            {
                player2Score++;
            }

            questionIndex23++;
        }

        public void OptionSelectedSolo(string option)
        {
            if (questionIndex5 >= 5)
            {
                questionIndex5--;
            }
            if (questionIndex6 >= 6)
            {
                questionIndex6--;
            }
            if (questionIndex4 >= 4)
            {
                questionIndex4--;
            }
            if (option == Questions[golfCount].Answer || option == Questions[hockeyCount].Answer || option == Questions[tennisCount].Answer || option == Questions[footballCount].Answer || option == Questions[carsCount].Answer || option == Questions[musicCount].Answer || option == Questions[movieCount].Answer || option == Questions[videoGamesCount].Answer)
            {
                player1Score++;
            }

            questionIndex23++;
            questionIndex6++;
            questionIndex5++;
            questionIndex4++;
        }

        protected void NextPlayer()
        {
            questionIndex6 = 0;
            questionIndex5 = 0;
            questionIndex4 = 0;
            questionIndex23 = 0;
            röv = true;
            bajs = false;
        }

        protected void RestartQuiz()
        {
            questionIndex23 = 0;
            questionIndex6 = 0;
            questionIndex5 = 0;
            questionIndex4 = 0;
            röv = false;
            bajs = true;
            player1Score = 0;
            player2Score = 0;
            golfCount = 0;
            hockeyCount = 5;
            tennisCount = 9;
            musicCount = 14;
            movieCount = 20;
            carsCount = 24;
            videoGamesCount = 28;
            footballCount = 32;
        }

        public class Player
        {
            public string Name { get; set; }
            public Player(string name)
            {
                Name = name;
            }
        }

        private void LoadQuestionsFrenchCuisine()
        {
            QuestionFrenchCuisine q1 = new QuestionFrenchCuisine
            {
                NameOfQuestion = "Vad är Frankrikes nationalrätt?",
                Options = new List<string>() { "Bouillabaisse", "Steak Frites", "Boeuf bourguignon ", "Coq au vin" },
                Answer = "Steak Frites",
                Category = "Franska Köket"
            };

            QuestionFrenchCuisine q2 = new QuestionFrenchCuisine
            {
                NameOfQuestion = "Vad kallas denna franska dessert?",
                Options = new List<string>() { "Omelette", "Croissant", "Pain au chocolat", "Éclair" },
                Answer = "Croissant",
                Image = "https://gammaldagsrecept.se/wp-content/uploads/2021/02/Croissanter-Recept.jpg",
                Category = "Franska Köket"
            };

            QuestionFrenchCuisine q3 = new QuestionFrenchCuisine
            {
                NameOfQuestion = "Vilken svensk skapade Minecraft?",
                Options = new List<string>() { "Markus Persson", "Daniel Ek", "Joakim Larsson", "Max Pettersson" },
                Answer = "Markus Persson",
                Category = "TV-Spel"
            };

            QuestionFrenchCuisine q4 = new QuestionFrenchCuisine
            {
                NameOfQuestion = "Battle Royale är ett populärt läge. Det innebär att man möter andra lag och laget som är kvar sist vinner. Vilket är det populäraste Battle Royale Spelet?",
                Options = new List<string>() { "Fortnite", "Apex Legends", "PUBG: Battlegrounds", "Call Of Duty: Warzone" },
                Answer = "PUBG: Battlegrounds",
                Category = "TV-Spel"
            };
            QuestionsFrenchCuisine.AddRange(new List<QuestionFrenchCuisine> { q1, q2, q3, q4, });
        }

        private void LoadQuestions()
        {
            Question q1 = new Question
            {
                NameOfQuestion = "Vem är världens bästa golfspelare?",
                Options = new List<string>() { "Tiger Woods", "Matt Kuchar", "S.H. Kim", "Adam Scott" },
                Answer = "Tiger Woods",
                Category = "Golf"
            };

            Question q2 = new Question
            {
                NameOfQuestion = "Vad heter Rory i efternamn?",
                Options = new List<string>() { "Svensson", "Mcilroy", "Eriksson", "Smith" },
                Answer = "Mcilroy",
                Category = "Golf"
            };

            Question q3 = new Question
            {
                NameOfQuestion = "Hur många golfhål spelar man under en tävling?",
                Options = new List<string>() { "18", "26", "72", "180" },
                Answer = "72",
                Category = "Golf"
            };

            Question q4 = new Question
            {
                NameOfQuestion = "Vilken bana spelas Masters på?",
                Options = new List<string>() { "TPC Sawgrass", "Agusta", "Halmstad GK", "The Country Club" },
                Answer = "Agusta",
                Category = "Golf"
            };

            Question q5 = new Question
            {
                NameOfQuestion = "Vad har Gustav i HCP?",
                Options = new List<string>() { "Alldeles för högt", "Alldeles för lågt", "Han är bäst", "Han är sämst" },
                Answer = "Han är sämst",
                Category = "Golf"
            };

            Question q6 = new Question
            {
                NameOfQuestion = "Hur många spelare är på isen samtidigt?",
                Options = new List<string>() { "8", "10", "6", "12" },
                Answer = "12",
                Category = "Hockey"
            };

            Question q7 = new Question
            {
                NameOfQuestion = "Hur lång är en hockeymatch?",
                Options = new List<string>() { "40 minuter", "60 minuter", "90 minuter", "45 minuter" },
                Answer = "60 minuter",
                Category = "Hockey"
            };

            Question q8 = new Question
            {
                NameOfQuestion = "Hur många poäng får ett lag om de vinner i övertid?",
                Options = new List<string>() { "3", "4", "2", "1" },
                Answer = "2",
                Category = "Hockey"
            };

            Question q9 = new Question
            {
                NameOfQuestion = "Vilken färg har en hockeypuck?",
                Options = new List<string>() { "Mörkblå", "Svart", "Grå", "Svart & vit" },
                Answer = "Svart",
                Category = "Hockey"
            };

            Question q10 = new Question
            {
                NameOfQuestion = "Vad kallas det när det står 40-40 i tennis?",
                Options = new List<string>() { "Even", "All square", "Deuce", "Even Steven" },
                Answer = "Deuce",
                Category = "Tennis"
            };

            Question q11 = new Question
            {
                NameOfQuestion = "Vad heter den kända svensken som tog 11 grand slam-segrar?",
                Options = new List<string>() { "Björn Borg", "Stefan Edberg", "Gustav Eriksson", "Mats Wilander" },
                Answer = "Björn Borg",
                Category = "Tennis"
            };

            Question q12 = new Question
            {
                NameOfQuestion = "Vart föddes den kända tennisspelaren Andy Murray?",
                Options = new List<string>() { "Wales", "England", "Scotland", "Ireland" },
                Answer = "Scotland",
                Category = "Tennis"
            };

            Question q13 = new Question
            {
                NameOfQuestion = "Vad kallas det kända mästerskap som spelas i England varje år?",
                Options = new List<string>() { "Wimbledon", "Offerthon", "English Tennis Cup", "London Tennis Championship" },
                Answer = "Wimbledon",
                Category = "Tennis"
            };

            Question q14 = new Question
            {
                NameOfQuestion = "Avsluta meningen: Game, Set &    ",
                Options = new List<string>() { "Victory", "Relax", "Time to make your bet", "Match" },
                Answer = "Match",
                Category = "Tennis"
            };

            Question q15 = new Question
            {
                NameOfQuestion = "Vilken låt är den mest strömmade på spotify?",
                Options = new List<string>() { "The Weeknd - Blinding Lights", "Ed Sheeran - Shape Of You", "Tones And I - Dance Monkey", "Post Malone - Rockstar" },
                Answer = "The Weeknd - Blinding Lights",
                Category = "Music"
            };

            Question q16 = new Question
            {
                NameOfQuestion = "Vilket band har gjort låten: Smoke on the water?",
                Options = new List<string>() { "Europe", "Iron Maiden", "Rolling Stones", "Deep Purple" },
                Answer = "Deep Purple",
                Category = "Music"
            };

            Question q17 = new Question
            {
                NameOfQuestion = "Vilken är Avicii's mest streamade låt på spotify?",
                Options = new List<string>() { "The Nights", "The Days", "Wake Me Up", "Without you" },
                Answer = "Wake Me Up",
                Category = "Music"
            };

            Question q18 = new Question
            {
                NameOfQuestion = "The Beatles är otroligt känt band med bandmedlemmar som John Lennon, Ringo Starr och Paul McCartney. Vad heter den fjärde medlemmen?",
                Options = new List<string>() { "George Harisson", "Dean Smith", "George Davidson", "Terry McDavid" },
                Answer = "George Harisson",
                Category = "Music"
            };

            Question q19 = new Question
            {
                NameOfQuestion = "Elvis Presley performed the song Hound dog. Please continue the lyrics to the song: You ain't nothing but a hound dog:",
                Options = new List<string>() { "Party'n all the time", "Lying all the time", "Crying all the time", "Smiling everytime" },
                Answer = "Crying all the time",
                Category = "Music"
            };

            Question q20 = new Question
            {
                NameOfQuestion = "Who performed the song: Like a virgin?",
                Options = new List<string>() { "Madonna", "Rihanna", "Britney Spears", "Cher" },
                Answer = "Madonna",
                Category = "Music"
            };

            Question q21 = new Question
            {
                NameOfQuestion = "Walter White är en högskolelärare som börjar att tillverka droger. Vad heter denna serie?",
                Options = new List<string>() { "Game Of Thrones", "Drugs & Teach", "Breaking Bad", "Cocaine & Clementine" },
                Answer = "Breaking Bad",
                Category = "Film & TV-Serie"
            };

            Question q22 = new Question
            {
                NameOfQuestion = "I sagan om ringen finns det en liten hobbit som blivit förvriden av mörkret. Han mumlar ofta: my precious... Vad heter denna karaktär?",
                Options = new List<string>() { "Smeagol", "Reagol", "Chero", "Mearo" },
                Answer = "Smeagol",
                Category = "Film & TV-Serie"
            };

            Question q23 = new Question
            {
                NameOfQuestion = "Vilken film har högst betyg på rating-sidan IMDB?",
                Options = new List<string>() { "Gudfadern", "The Dark Knight", "Nyckeln till frihet", "Schindler's List" },
                Answer = "Nyckeln till frihet",
                Category = "Film & TV-Serie"
            };

            Question q24 = new Question
            {
                NameOfQuestion = "Vilken TV-serie har högst betyg på rating-sidan IMDB?",
                Options = new List<string>() { "Planet Earth", "Planet Earth II", "Breaking Bad", "Band of Brothers" },
                Answer = "Planet Earth II",
                Category = "Film & TV-Serie"
            };

            Question q25 = new Question
            {
                NameOfQuestion = "Vad heter det svenska företaget som fram till 2012 tillverkade bilar? De kanske är mest kända för sina flygplan.",
                Options = new List<string>() { "Volvo", "Audi", "Saab", "Gripen" },
                Answer = "Saab",
                Category = "Bilar"
            };

            Question q26 = new Question
            {
                NameOfQuestion = "Vad heter företaget från Ängelholm som tillverkar världens snabbaste bilar?",
                Options = new List<string>() { "Hyundai", "Roendi", "Polestar", "Koenigsegg" },
                Answer = "Koenigsegg",
                Category = "Bilar"
            };

            Question q27 = new Question
            {
                NameOfQuestion = "Volvo är ett stort bilföretag som är baserat i Göteborg, Sverige. Men vad betyder volvo på latin?",
                Options = new List<string>() { "Säkerhet", "Jag rullar", "Snabb och kompakt", "Säkert rullande" },
                Answer = "Jag rullar",
                Category = "Bilar"
            };

            Question q28 = new Question
            {
                NameOfQuestion = "Vad heter det kända Italienska bilmärket som är kända för sin röda färg?",
                Options = new List<string>() { "Lamborghini", "Rolls Royce", "Audi", "Ferrari" },
                Answer = "Ferrari",
                Category = "Bilar"
            };

            Question q29 = new Question
            {
                NameOfQuestion = "Vilket är världens mest sålda TV-spel?",
                Options = new List<string>() { "Counter Strike: Global Offensive", "Minecraft", "World Of Warcraft", "Grand Theft Auto V" },
                Answer = "Minecraft",
                Category = "TV-Spel"
            };

            Question q30 = new Question
            {
                NameOfQuestion = "Vad heter Mario's bror?",
                Options = new List<string>() { "Bowser", "Toad", "Luigi", "Yoshi" },
                Answer = "Luigi",
                Category = "TV-Spel"
            };

            Question q31 = new Question
            {
                NameOfQuestion = "Vilken svensk skapade Minecraft?",
                Options = new List<string>() { "Markus Persson", "Daniel Ek", "Joakim Larsson", "Max Pettersson" },
                Answer = "Markus Persson",
                Category = "TV-Spel"
            };

            Question q32 = new Question
            {
                NameOfQuestion = "Battle Royale är ett populärt läge. Det innebär att man möter andra lag och laget som är kvar sist vinner. Vilket är det populäraste Battle Royale Spelet?",
                Options = new List<string>() { "Fortnite", "Apex Legends", "PUBG: Battlegrounds", "Call Of Duty: Warzone" },
                Answer = "PUBG: Battlegrounds",
                Category = "TV-Spel"
            };

            Question q33 = new Question
            {
                NameOfQuestion = "Hur många fotbollspelare är det i samma lag?",
                Options = new List<string>() { "11", "9", "12", "13" },
                Answer = "11",
                Category = "Fotboll"
            };

            Question q34 = new Question
            {
                NameOfQuestion = "I fotboll så kan man få olika kort av domaren, vad betyder det gula kortet?",
                Options = new List<string>() { "Varning", "Utvisning", "Att man har gjort mål", "Att man har gjort något bra" },
                Answer = "Varning",
                Category = "Fotboll"
            };

            Question q35 = new Question
            {
                NameOfQuestion = "Vad heter den långa svenska fotbollspelaren som är känd för att ha spelat för PSG, Barcelona, Inter, Milan med mera?",
                Options = new List<string>() { "Kim Källström", "Håkan Hellström", "Antony Elanga", "Zlatan Ibrahimovic" },
                Answer = "Zlatan Ibrahimovic",
                Category = "Fotboll"
            };

            Question q36 = new Question
            {
                NameOfQuestion = "Vad kallas det när man sparkar bollen mellan någons ben?",
                Options = new List<string>() { "Underspark", "Cykelspark", "Tunnel", "Rabona" },
                Answer = "Tunnel",
                Category = "Fotboll"
            };

            Question q37 = new Question
            {
                NameOfQuestion = "Vad innebär det röda kortet som domaren kan dela ut?",
                Options = new List<string>() { "Varning", "Utvisning", "Att man har gjort mål", "Att man har gjort något bra" },
                Answer = "Utvisning",
                Category = "Fotboll"
            };

            Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24, q25, q26, q27, q28, q29, q30, q31, q32, q33, q34, q35, q36, q37 });
        }
    }
}
