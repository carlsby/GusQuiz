using Microsoft.AspNetCore.Components;
using GusQuiz.Models;
using System.Xml.Linq;

namespace GusQuiz.Pages
{
    public class QuizBase : ComponentBase
    {
        public List<QuestionFotboll> QuestionsFotboll { get; set; } = new List<QuestionFotboll>();
        public List<QuestionHockey> QuestionsHockey { get; set; } = new List<QuestionHockey>();
        public List<QuestionGolf> QuestionsGolf { get; set; } = new List<QuestionGolf>();
        public List<QuestionTennis> QuestionsTennis { get; set; } = new List<QuestionTennis>();
        public List<QuestionMusic> QuestionsMusic { get; set; } = new List<QuestionMusic>();
        public List<QuestionMovie> QuestionsMovie { get; set; } = new List<QuestionMovie>();

        protected int questionIndex6 = 0;
        protected int questionIndex5 = 0;
        protected int questionIndex4 = 0;
        protected int player1Score = 0;
        protected int player2Score = 0;
        protected bool röv = false;
        protected bool bajs = true;
        protected int player1Wins = 0;
        protected int player2Wins = 0;
        protected string player1 = "";
        protected string player2 = "";

        protected override Task OnInitializedAsync()
        {
            LoadQuestionsFotboll();
            LoadQuestionsHockey();
            LoadQuestionsGolf();
            LoadQuestionsTennis();
            LoadQuestionsMusic();
            LoadQuestionsMovie();
            return base.OnInitializedAsync();
        }

        public void OptionSelected(string option)
        {
            if (questionIndex5 >= 5)
            {
                questionIndex5--;
            }
            if (option == QuestionsTennis[questionIndex5].Answer || option == QuestionsGolf[questionIndex5].Answer || option == QuestionsFotboll[questionIndex5].Answer)
            {
                player1Score++;
            }
            else if (option == QuestionsMusic[questionIndex6].Answer)
            {
                player1Score++;
            }
            if (questionIndex4 >= 4)
            {
                questionIndex4--;
            }
            else if (option == QuestionsHockey[questionIndex4].Answer || option == QuestionsMovie[questionIndex4].Answer)
            {
                player1Score++;
            }

            questionIndex6++;
            questionIndex5++;
            questionIndex4++;
        }

        protected void OptionSelected2(string option)
        {
            if (option == QuestionsFotboll[questionIndex5].Answer)
            {
                player2Score++;
            }
            questionIndex5++;
        }

        protected void NextPlayer()
        {
            questionIndex6 = 0;
            questionIndex5 = 0;
            questionIndex4 = 0;
            röv = true;
            bajs = false;
        }

        protected void RestartQuiz()
        {
            questionIndex6 = 0;
            questionIndex5 = 0;
            questionIndex4 = 0;
            röv = false;
            bajs = true;
            player1Score = 0;
            player2Score = 0;
        }

        public class Player
        {
            public string Name { get; set; }
            public Player(string name)
            {
                Name = name;
            }
        }

        private void LoadQuestionsFotboll()
        {
            QuestionFotboll q1 = new QuestionFotboll
            {
                NameOfQuestion = "Hur många fotbollspelare är det i samma lag?",
                Options = new List<string>() { "11", "9", "12", "13" },
                Answer = "11",
                Category = "Fotboll"
            };

            QuestionFotboll q2 = new QuestionFotboll
            {
                NameOfQuestion = "I fotboll så kan man få olika kort av domaren, vad betyder det gula kortet?",
                Options = new List<string>() { "Varning", "Utvisning", "Att man har gjort mål", "Att man har gjort något bra" },
                Answer = "Varning",
                Category = "Fotboll"
            };

            QuestionFotboll q3 = new QuestionFotboll
            {
                NameOfQuestion = "Vad heter den långa svenska fotbollspelaren som är känd för att ha spelat för PSG, Barcelona, Inter, Milan med mera?",
                Options = new List<string>() { "Kim Källström", "Håkan Hellström", "Antony Elanga", "Zlatan Ibrahimovic" },
                Answer = "Zlatan Ibrahimovic",
                Category = "Fotboll"
            };

            QuestionFotboll q4 = new QuestionFotboll
            {
                NameOfQuestion = "Vad kallas det när man sparkar bollen mellan någons ben?",
                Options = new List<string>() { "Underspark", "Cykelspark", "Tunnel", "Rabona" },
                Answer = "Tunnel",
                Category = "Fotboll"
            };

            QuestionFotboll q5 = new QuestionFotboll
            {
                NameOfQuestion = "Vad innebär det röda kortet som domaren kan dela ut?",
                Options = new List<string>() { "Varning", "Utvisning", "Att man har gjort mål", "Att man har gjort något bra" },
                Answer = "Utvisning",
                Category = "Fotboll"
            };
            QuestionsFotboll.AddRange(new List<QuestionFotboll> { q1, q2, q3, q4, q5 });
        }

        private void LoadQuestionsHockey()
        {
            QuestionHockey q1 = new QuestionHockey    
            {
                NameOfQuestion = "Hur många spelare är på isen samtidigt?",
                Options = new List<string>() { "8", "10", "6", "12" },
                Answer = "12",
                Category = "Hockey"
            };

            QuestionHockey q2 = new QuestionHockey
            {
                NameOfQuestion = "Hur lång är en hockeymatch?",
                Options = new List<string>() { "40 minuter", "60 minuter", "90 minuter", "45 minuter" },
                Answer = "60 minuter",
                Category = "Hockey"
            };

            QuestionHockey q3 = new QuestionHockey
            {
                NameOfQuestion = "Hur många poäng får ett lag om de vinner i övertid?",
                Options = new List<string>() { "3", "4", "2", "1" },
                Answer = "2",
                Category = "Hockey"
            };

            QuestionHockey q4 = new QuestionHockey
            {
                NameOfQuestion = "Vilken färg har en hockeypuck?",
                Options = new List<string>() { "Mörkblå", "Svart", "Grå", "Svart & vit" },
                Answer = "Svart",
                Category = "Hockey"
            };
            QuestionsHockey.AddRange(new List<QuestionHockey> { q1, q2, q3, q4 });
        }
        private void LoadQuestionsGolf()
        {
            QuestionGolf q1 = new QuestionGolf
            {
                NameOfQuestion = "Vem är världens bästa golfspelare?",
                Options = new List<string>() { "Tiger Woods", "Matt Kuchar", "S.H. Kim", "Adam Scott" },
                Answer = "Tiger Woods",
                Category = "Golf"
            };

            QuestionGolf q2 = new QuestionGolf
            {
                NameOfQuestion = "Vad heter Rory i efternamn?",
                Options = new List<string>() { "Svensson", "Mcilroy", "Eriksson", "Smith" },
                Answer = "Mcilroy",
                Category = "Golf"
            };

            QuestionGolf q3 = new QuestionGolf
            {
                NameOfQuestion = "Hur många golfhål spelar man under en tävling?",
                Options = new List<string>() { "18", "26", "72", "180" },
                Answer = "72",
                Category = "Golf"
            };

            QuestionGolf q4 = new QuestionGolf
            {
                NameOfQuestion = "Vilken bana spelas Masters på?",
                Options = new List<string>() { "TPC Sawgrass", "Agusta", "Halmstad GK", "The Country Club" },
                Answer = "Agusta",
                Category = "Golf"
            };

            QuestionGolf q5 = new QuestionGolf
            {
                NameOfQuestion = "Vad har Gustav i HCP?",
                Options = new List<string>() { "Alldeles för högt", "Alldeles för lågt", "Han är bäst", "Han är sämst" },
                Answer = "Han är sämst",
                Category = "Golf"
            };
            QuestionsGolf.AddRange(new List<QuestionGolf> { q1, q2, q3, q4 , q5 });
        }

        private void LoadQuestionsTennis()
        {
            QuestionTennis q1 = new QuestionTennis
            {
                NameOfQuestion = "Vad kallas det när det står 40-40 i tennis?",
                Options = new List<string>() { "Even", "All square", "Deuce", "Even Steven" },
                Answer = "Deuce",
                Category = "Tennis"
            };

            QuestionTennis q2 = new QuestionTennis
            {
                NameOfQuestion = "Vad heter den kända svensken som tog 11 grand slam-segrar?",
                Options = new List<string>() { "Björn Borg", "Stefan Edberg", "Gustav Eriksson", "Mats Wilander" },
                Answer = "Björn Borg",
                Category = "Tennis"
            };

            QuestionTennis q3 = new QuestionTennis
            {
                NameOfQuestion = "Vart föddes den kända tennisspelaren Andy Murray?",
                Options = new List<string>() { "Wales", "England", "Scotland", "Ireland" },
                Answer = "Scotland",
                Category = "Tennis"
            };

            QuestionTennis q4 = new QuestionTennis
            {
                NameOfQuestion = "Vad kallas det kända mästerskap som spelas i England varje år?",
                Options = new List<string>() { "Wimbledon", "Offerthon", "English Tennis Cup", "London Tennis Championship" },
                Answer = "Wimbledon",
                Category = "Tennis"
            };

            QuestionTennis q5 = new QuestionTennis
            {
                NameOfQuestion = "Avsluta meningen: Game, Set &    ",
                Options = new List<string>() { "Victory", "Relax", "Time to make your bet", "Match" },
                Answer = "Match",
                Category = "Tennis"
            };
            QuestionsTennis.AddRange(new List<QuestionTennis> { q1, q2, q3, q4, q5 });
        }
        private void LoadQuestionsMusic()
        {
            QuestionMusic q1 = new QuestionMusic
            {
                NameOfQuestion = "Vilken låt är den mest strömmade på spotify?",
                Options = new List<string>() { "The Weeknd - Blinding Lights", "Ed Sheeran - Shape Of You", "Tones And I - Dance Monkey", "Post Malone - Rockstar" },
                Answer = "The Weeknd - Blinding Lights",
                Category = "Music"
            };

            QuestionMusic q2 = new QuestionMusic
            {
                NameOfQuestion = "Vilket band har gjort låten: Smoke on the water?",
                Options = new List<string>() { "Europe", "Iron Maiden", "Rolling Stones", "Deep Purple" },
                Answer = "Deep Purple",
                Category = "Music"
            };

            QuestionMusic q3 = new QuestionMusic
            {
                NameOfQuestion = "Vilken är Avicii's mest streamade låt på spotify?",
                Options = new List<string>() { "The Nights", "The Days", "Wake Me Up", "Without you" },
                Answer = "Wake Me Up",
                Category = "Music"
            };

            QuestionMusic q4 = new QuestionMusic
            {
                NameOfQuestion = "The Beatles är otroligt känt band med bandmedlemmar som John Lennon, Ringo Starr och Paul McCartney. Vad heter den fjärde medlemmen?",
                Options = new List<string>() { "George Harisson", "Dean Smith", "George Davidson", "Terry McDavid" },
                Answer = "George Harisson",
                Category = "Music"
            };

            QuestionMusic q5 = new QuestionMusic
            {
                NameOfQuestion = "Elvis Presley performed the song Hound dog. Please continue the lyrics to the song: You ain't nothing but a hound dog:",
                Options = new List<string>() { "Party'n all the time", "Lying all the time", "Crying all the time", "Smiling everytime" },
                Answer = "Crying all the time",
                Category = "Music"
            };

            QuestionMusic q6 = new QuestionMusic
            {
                NameOfQuestion = "Who performed the song: Like a virgin?",
                Options = new List<string>() { "Madonna", "Rihanna", "Britney Spears", "Cher" },
                Answer = "Madonna",
                Category = "Music"
            };
            QuestionsMusic.AddRange(new List<QuestionMusic> { q1, q2, q3, q4, q5, q6 });
        }

        private void LoadQuestionsMovie()
        {
            QuestionMovie q1 = new QuestionMovie
            {
                NameOfQuestion = "Walter White är en högskolelärare som börjar att tillverka droger. Vad heter denna serie?",
                Options = new List<string>() { "Game Of Thrones", "Drugs & Teach", "Breaking Bad", "Cocaine & Clementine" },
                Answer = "Breaking Bad",
                Category = "Film & TV-Serie"
            };

            QuestionMovie q2 = new QuestionMovie
            {
                NameOfQuestion = "I sagan om ringen finns det en liten hobbit som blivit förvriden av mörkret. Han mumlar ofta: my precious... Vad heter denna karaktär?",
                Options = new List<string>() { "Smeagol", "Reagol", "Chero", "Mearo" },
                Answer = "Smeagol",
                Category = "Film & TV-Serie"
            };

            QuestionMovie q3 = new QuestionMovie
            {
                NameOfQuestion = "Vilken film har högst betyg på rating-sidan IMDB?",
                Options = new List<string>() { "Gudfadern", "The Dark Knight", "Nyckeln till frihet", "Schindler's List" },
                Answer = "Nyckeln till frihet",
                Category = "Film & TV-Serie"
            };

            QuestionMovie q4 = new QuestionMovie
            {
                NameOfQuestion = "Vilken TV-serie har högst betyg på rating-sidan IMDB?",
                Options = new List<string>() { "Planet Earth", "Planet Earth II", "Breaking Bad", "Band of Brothers" },
                Answer = "Planet Earth II",
                Category = "Film & TV-Serie"
            };
            QuestionsMovie.AddRange(new List<QuestionMovie> { q1, q2, q3, q4, });
        }
    }
}
