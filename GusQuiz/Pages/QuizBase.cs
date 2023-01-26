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
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<int> usedNumbers = new List<int>(); // Lista för att få ut random nummer


        protected int questionIndex6 = 0;
        protected int questionIndex5 = 0;
        protected int questionIndex4 = 0;
        protected int questionIndex23 = 0;
        public int player1Score = 0;
        public int player2Score = 0;
        protected bool playertwoloop = false;
        protected bool playeroneloop = true;
        protected int newNumber;
        public int player1Wins = 0;
        public int player2Wins = 0;
        public string player1 = "";
        protected string player2 = "";
        protected int index = 0;

        // Under deklareras så att frågorna börjar på rätt index till de olika kategorierna
        protected int golfCount = 0;
        protected int hockeyCount = 5;
        protected int tennisCount = 9;
        protected int musicCount = 14;
        protected int movieCount = 20;
        protected int carsCount = 24;
        protected int videoGamesCount = 28;
        protected int footballCount = 32;
        protected int historyCount = 37;
        protected int politicalHistoryCount = 41;
        protected int arthistoryCount = 45;
        protected int worldwarsCount = 49;
        protected int dessertCount = 53;
        protected int frenchCount = 57;
        protected int italianCount = 61;
        protected int drinksCount = 65;
        protected override Task OnInitializedAsync()
        {
            LoadQuestions();
            return base.OnInitializedAsync();
        }

        // Spelare1's alternativ, om de svarar rätt så får de poäng. Efter spelare1 har svarat går det vidare till nästa fråga
        public void OptionSelected(string option)
        {
            if (option == Questions[index].Answer)
            {
                player1Score++;
            }

            questionIndex23++;
        }

        // Spelare2's alternativ, om de svarar rätt så får de poäng. Efter spelare1 har svarat går det vidare till nästa fråga
        protected void OptionSelected2(string option)
        {
            if (option == Questions[index].Answer)
            {
                player2Score++;
            }

            questionIndex23++;
        }

        public void OptionSelectedSolo(string option)
        {
            // Ifall indexet går över sin limit så stoppas det så att programmet inte kraschar
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
            // Om du svarar rätt på frågorna så får du ett poäng
            if (option == Questions[golfCount].Answer ||
                option == Questions[hockeyCount].Answer ||
                option == Questions[tennisCount].Answer ||
                option == Questions[footballCount].Answer ||
                option == Questions[carsCount].Answer ||
                option == Questions[musicCount].Answer ||
                option == Questions[movieCount].Answer ||
                option == Questions[videoGamesCount].Answer ||
                option == Questions[dessertCount].Answer ||
                option == Questions[frenchCount].Answer ||
                option == Questions[historyCount].Answer ||
                option == Questions[politicalHistoryCount].Answer ||
                option == Questions[arthistoryCount].Answer ||
                option == Questions[italianCount].Answer ||
                option == Questions[worldwarsCount].Answer ||
                option == Questions[drinksCount].Answer)
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
            playertwoloop = true;
            playeroneloop = false;
        }

        protected void RestartQuiz() // Startar om quizet och nollställer alla värden förutom playerwins till 0
        {
            usedNumbers.Clear();
            questionIndex23 = 0;
            questionIndex6 = 0;
            questionIndex5 = 0;
            questionIndex4 = 0;
            playeroneloop = true;
            playertwoloop = false;
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
            historyCount = 37;
            politicalHistoryCount = 41;
            arthistoryCount = 45;
            worldwarsCount = 49;
            dessertCount = 53;
            frenchCount = 57;
            italianCount = 61;
            drinksCount = 65;
    }

        // Skapar klassen player som används för att ta in spelarnamn till en lista
        public class Player
        {
            public string Name { get; set; }
            public Player(string name)
            {
                Name = name;
            }
        }

        // Skapar en lista som fylls på med titel, alternativ, svar och kategorier
        private void LoadQuestions()
        {
            Question q0 = new Question
            {
                NameOfQuestion = "Vem är världens bästa golfspelare?",
                Options = new List<string>() { "Tiger Woods", "Matt Kuchar", "S.H. Kim", "Adam Scott" },
                Answer = "Tiger Woods",
                Category = "Golf"
            };

            Question q1 = new Question
            {
                NameOfQuestion = "Vad heter Rory i efternamn?",
                Options = new List<string>() { "Svensson", "Mcilroy", "Eriksson", "Smith" },
                Answer = "Mcilroy",
                Category = "Golf"
            };

            Question q2 = new Question
            {
                NameOfQuestion = "Hur många golfhål spelar man under en tävling?",
                Options = new List<string>() { "18", "26", "72", "180" },
                Answer = "72",
                Category = "Golf"
            };

            Question q3 = new Question
            {
                NameOfQuestion = "Vilken bana spelas Masters på?",
                Options = new List<string>() { "TPC Sawgrass", "Agusta", "Halmstad GK", "The Country Club" },
                Answer = "Agusta",
                Category = "Golf"
            };

            Question q4 = new Question
            {
                NameOfQuestion = "Vad har Gustav i HCP?",
                Options = new List<string>() { "Alldeles för högt", "Alldeles för lågt", "Han är bäst", "Han är sämst" },
                Answer = "Han är sämst",
                Category = "Golf"
            };

            Question q5 = new Question
            {
                NameOfQuestion = "Hur många spelare är på isen samtidigt?",
                Options = new List<string>() { "8", "10", "6", "12" },
                Answer = "12",
                Category = "Hockey"
            };

            Question q6 = new Question
            {
                NameOfQuestion = "Hur lång är en hockeymatch?",
                Options = new List<string>() { "40 minuter", "60 minuter", "90 minuter", "45 minuter" },
                Answer = "60 minuter",
                Category = "Hockey"
            };

            Question q7 = new Question
            {
                NameOfQuestion = "Hur många poäng får ett lag om de vinner i övertid?",
                Options = new List<string>() { "3", "4", "2", "1" },
                Answer = "2",
                Category = "Hockey"
            };

            Question q8 = new Question
            {
                NameOfQuestion = "Vilken färg har en hockeypuck?",
                Options = new List<string>() { "Mörkblå", "Svart", "Grå", "Svart & vit" },
                Answer = "Svart",
                Category = "Hockey"
            };

            Question q9 = new Question
            {
                NameOfQuestion = "Vad kallas det när det står 40-40 i tennis?",
                Options = new List<string>() { "Even", "All square", "Deuce", "Even Steven" },
                Answer = "Deuce",
                Category = "Tennis"
            };

            Question q10 = new Question
            {
                NameOfQuestion = "Vad heter den kända svensken som tog 11 grand slam-segrar?",
                Options = new List<string>() { "Björn Borg", "Stefan Edberg", "Gustav Eriksson", "Mats Wilander" },
                Answer = "Björn Borg",
                Category = "Tennis"
            };

            Question q11 = new Question
            {
                NameOfQuestion = "Vart föddes den kända tennisspelaren Andy Murray?",
                Options = new List<string>() { "Wales", "England", "Scotland", "Ireland" },
                Answer = "Scotland",
                Category = "Tennis"
            };

            Question q12 = new Question
            {
                NameOfQuestion = "Vad kallas det kända mästerskap som spelas i England varje år?",
                Options = new List<string>() { "Wimbledon", "Offerthon", "English Tennis Cup", "London Tennis Championship" },
                Answer = "Wimbledon",
                Category = "Tennis"
            };

            Question q13 = new Question
            {
                NameOfQuestion = "Avsluta meningen: Game, Set &    ",
                Options = new List<string>() { "Victory", "Relax", "Time to make your bet", "Match" },
                Answer = "Match",
                Category = "Tennis"
            };

            Question q14 = new Question
            {
                NameOfQuestion = "Vilken låt är den mest strömmade på spotify?",
                Options = new List<string>() { "The Weeknd - Blinding Lights", "Ed Sheeran - Shape Of You", "Tones And I - Dance Monkey", "Post Malone - Rockstar" },
                Answer = "The Weeknd - Blinding Lights",
                Category = "Music"
            };

            Question q15 = new Question
            {
                NameOfQuestion = "Vilket band har gjort låten: Smoke on the water?",
                Options = new List<string>() { "Europe", "Iron Maiden", "Rolling Stones", "Deep Purple" },
                Answer = "Deep Purple",
                Category = "Music"
            };

            Question q16 = new Question
            {
                NameOfQuestion = "Vilken är Avicii's mest streamade låt på spotify?",
                Options = new List<string>() { "The Nights", "The Days", "Wake Me Up", "Without you" },
                Answer = "Wake Me Up",
                Category = "Music"
            };

            Question q17 = new Question
            {
                NameOfQuestion = "The Beatles är otroligt känt band med bandmedlemmar som John Lennon, Ringo Starr och Paul McCartney. Vad heter den fjärde medlemmen?",
                Options = new List<string>() { "George Harisson", "Dean Smith", "George Davidson", "Terry McDavid" },
                Answer = "George Harisson",
                Category = "Music"
            };

            Question q18 = new Question
            {
                NameOfQuestion = "Elvis Presley uppträdde med låten Hound dog. Var vänlig fortsätt låttexten: You ain't nothing but a hound dog:",
                Options = new List<string>() { "Party'n all the time", "Lying all the time", "Crying all the time", "Smiling everytime" },
                Answer = "Crying all the time",
                Category = "Music"
            };

            Question q19 = new Question
            {
                NameOfQuestion = "Vem uppträdde med låten: Like a virgin?",
                Options = new List<string>() { "Madonna", "Rihanna", "Britney Spears", "Cher" },
                Answer = "Madonna",
                Category = "Music"
            };

            Question q20 = new Question
            {
                NameOfQuestion = "Walter White är en högskolelärare som börjar att tillverka droger. Vad heter denna serie?",
                Options = new List<string>() { "Game Of Thrones", "Drugs & Teach", "Breaking Bad", "Cocaine & Clementine" },
                Answer = "Breaking Bad",
                Category = "Film & TV-Serie"
            };

            Question q21 = new Question
            {
                NameOfQuestion = "I sagan om ringen finns det en liten hobbit som blivit förvriden av mörkret. Han mumlar ofta: my precious... Vad heter denna karaktär?",
                Options = new List<string>() { "Smeagol", "Reagol", "Chero", "Mearo" },
                Answer = "Smeagol",
                Category = "Film & TV-Serie"
            };

            Question q22 = new Question
            {
                NameOfQuestion = "Vilken film har högst betyg på rating-sidan IMDB?",
                Options = new List<string>() { "Gudfadern", "The Dark Knight", "Nyckeln till frihet", "Schindler's List" },
                Answer = "Nyckeln till frihet",
                Category = "Film & TV-Serie"
            };

            Question q23 = new Question
            {
                NameOfQuestion = "Vilken TV-serie har högst betyg på rating-sidan IMDB?",
                Options = new List<string>() { "Planet Earth", "Planet Earth II", "Breaking Bad", "Band of Brothers" },
                Answer = "Planet Earth II",
                Category = "Film & TV-Serie"
            };

            Question q24 = new Question
            {
                NameOfQuestion = "Vad heter det svenska företaget som fram till 2012 tillverkade bilar? De kanske är mest kända för sina flygplan.",
                Options = new List<string>() { "Volvo", "Audi", "Saab", "Gripen" },
                Answer = "Saab",
                Category = "Bilar"
            };

            Question q25 = new Question
            {
                NameOfQuestion = "Vad heter företaget från Ängelholm som tillverkar världens snabbaste bilar?",
                Options = new List<string>() { "Hyundai", "Roendi", "Polestar", "Koenigsegg" },
                Answer = "Koenigsegg",
                Category = "Bilar"
            };

            Question q26 = new Question
            {
                NameOfQuestion = "Volvo är ett stort bilföretag som är baserat i Göteborg, Sverige. Men vad betyder volvo på latin?",
                Options = new List<string>() { "Säkerhet", "Jag rullar", "Snabb och kompakt", "Säkert rullande" },
                Answer = "Jag rullar",
                Category = "Bilar"
            };

            Question q27 = new Question
            {
                NameOfQuestion = "Vad heter det kända Italienska bilmärket som är kända för sin röda färg?",
                Options = new List<string>() { "Lamborghini", "Rolls Royce", "Audi", "Ferrari" },
                Answer = "Ferrari",
                Category = "Bilar"
            };

            Question q28 = new Question
            {
                NameOfQuestion = "Vilket är världens mest sålda TV-spel?",
                Options = new List<string>() { "Counter Strike: Global Offensive", "Minecraft", "World Of Warcraft", "Grand Theft Auto V" },
                Answer = "Minecraft",
                Category = "TV-Spel"
            };

            Question q29 = new Question
            {
                NameOfQuestion = "Vad heter Mario's bror?",
                Options = new List<string>() { "Bowser", "Toad", "Luigi", "Yoshi" },
                Answer = "Luigi",
                Category = "TV-Spel"
            };

            Question q30 = new Question
            {
                NameOfQuestion = "Vilken svensk skapade Minecraft?",
                Options = new List<string>() { "Markus Persson", "Daniel Ek", "Joakim Larsson", "Max Pettersson" },
                Answer = "Markus Persson",
                Category = "TV-Spel"
            };

            Question q31 = new Question
            {
                NameOfQuestion = "Battle Royale är ett populärt läge. Det innebär att man möter andra lag och laget som är kvar sist vinner. Vilket är det populäraste Battle Royale Spelet?",
                Options = new List<string>() { "Fortnite", "Apex Legends", "PUBG: Battlegrounds", "Call Of Duty: Warzone" },
                Answer = "PUBG: Battlegrounds",
                Category = "TV-Spel"
            };

            Question q32 = new Question
            {
                NameOfQuestion = "Hur många fotbollspelare är det i samma lag?",
                Options = new List<string>() { "11", "9", "12", "13" },
                Answer = "11",
                Category = "Fotboll"
            };

            Question q33 = new Question
            {
                NameOfQuestion = "I fotboll så kan man få olika kort av domaren, vad betyder det gula kortet?",
                Options = new List<string>() { "Varning", "Utvisning", "Att man har gjort mål", "Att man har gjort något bra" },
                Answer = "Varning",
                Category = "Fotboll"
            };

            Question q34 = new Question
            {
                NameOfQuestion = "Vad heter den långa svenska fotbollspelaren som är känd för att ha spelat för PSG, Barcelona, Inter, Milan med mera?",
                Options = new List<string>() { "Kim Källström", "Håkan Hellström", "Antony Elanga", "Zlatan Ibrahimovic" },
                Answer = "Zlatan Ibrahimovic",
                Category = "Fotboll"
            };

            Question q35 = new Question
            {
                NameOfQuestion = "Vad kallas det när man sparkar bollen mellan någons ben?",
                Options = new List<string>() { "Underspark", "Cykelspark", "Tunnel", "Rabona" },
                Answer = "Tunnel",
                Category = "Fotboll"
            };

            Question q36 = new Question
            {
                NameOfQuestion = "Vad innebär det röda kortet som domaren kan dela ut?",
                Options = new List<string>() { "Varning", "Utvisning", "Att man har gjort mål", "Att man har gjort något bra" },
                Answer = "Utvisning",
                Category = "Fotboll"
            };
            Question q37 = new Question
            {
                NameOfQuestion = "Nya testamentets fyra evangelister är Matteus, Markus, Lukas och...",
                Options = new List<string>() { "Johannes", "Petrus", "Johan", "Peter" },
                Answer = "Johannes",
                Category = "Religionshistoria"
            };
            Question q38 = new Question
            {
                NameOfQuestion = "Vad heter den grekiska havsguden Poseidons motsvarighet i den romerska mytologin?",
                Options = new List<string>() { "Jupiter", "Neptunus", "Bacchus", "Saturnus" },
                Answer = "Neptunus",
                Category = "Religionshistoria"
            };
            Question q39 = new Question
            {
                NameOfQuestion = "Oden är den högste av gudarna i den nordiska mytologin. Hugin och Munin är hans korpar. Men vad heter hans åttafotade häst?",
                Options = new List<string>() { "Sleipner", "Rimfaxe", "Svadilfare", "Lokeis" },
                Answer = "Sleipner",
                Category = "Religionshistoria"
            };
            Question q40 = new Question
            {
                NameOfQuestion = "Johannes Döparens avrättning beskrivs i Nya testamentet. Hur dödas han?\r\n",
                Options = new List<string>() { "Strypning", "Gift", "Dränkning", "Halshuggning" },
                Answer = "Halshuggning",
                Category = "Religionshistoria"
            };
            Question q41 = new Question
            {
                NameOfQuestion = "Vad tog Sverige avsked av 1866?",
                Options = new List<string>() { "Ståndsriksdagen", "Lotteririksdagen", "Tvåkammarriksdagen", "Trekammarriksdagen" },
                Answer = "Ståndsriksdagen",
                Category = "Politisk historia"
            };
            Question q42 = new Question
            {
                NameOfQuestion = "År 1903 bildades föreningen LKPR. Vad krävde föreningen?",
                Options = new List<string>() { "Kortare arbetstid", "Rösträtt för kvinnor", "Sänkt rösträttsålder", "Borttagning av dödsstraff" },
                Answer = "Rösträtt för kvinnor",
                Category = "Politisk historia"
            };
            Question q43 = new Question
            {
                NameOfQuestion = "För snart hundra år sedan, 1921, fick Sverige allmän och lika rösträtt. Varför behövde riksdagen fatta två beslut om detta, som dessutom var formulerade på exakt samma sätt?",
                Options = new List<string>() { "Folket krävde detta", "Kungen krävde detta", "Eftersom det handlade om en ändring i grundlagen krävdes det två likadana beslut", "Ledamöterna i riksdagens första kammare hade bestämt att så skulle ske" },
                Answer = "Eftersom det handlade om en ändring i grundlagen krävdes det två likadana beslut",
                Category = "Politisk historia"
            };
            Question q44 = new Question
            {
                NameOfQuestion = "Efter valet 1921 tog fem kvinnor plats i riksdagen. Hur många procent av de som valdes in som riksdagsledamöter vid senaste valet var kvinnor?",
                Options = new List<string>() { "33,7 procent", "67,2 procent", "46,1 procent", "49,4 procent" },
                Answer = "46,1 procent",
                Category = "Politisk historia"
            };
            Question q45 = new Question
            {
                NameOfQuestion = "Leonardo da Vinci målade Mona Lisa, eller La Gioconda, i början av 1500-talet. Var hänger den ikoniska tavlan i dag?",
                Options = new List<string>() { "Louvren, Paris", "British Musem, London", "Houvren, Paris", "Paris Museum, Paris" },
                Answer = "Louvren, Paris",
                Category = "Konstens historia"
            };
            Question q46 = new Question
            {
                NameOfQuestion = "Vem komponerade De fyra årstiderna, på italienska Le quattro stagioni?",
                Options = new List<string>() { "Giacomo Puccini", "Antonio Vivaldi", "Gioacchino Rossini", "Ludwig van Beethoven" },
                Answer = "Antonio Vivaldi",
                Category = "Konstens historia"
            };
            Question q47 = new Question
            {
                NameOfQuestion = "Den nederländske konstnären Vincent van Gogh tog sitt liv och blev berömd först efter sin död. Omtalat är också att han skar av en bit av en egen kroppsdel, vilken?",
                Options = new List<string>() { "Pekfingret", "Överläppen", "Stortån", "Örat" },
                Answer = "Örat",
                Category = "Konstens historia"
            };
            Question q48 = new Question
            {
                NameOfQuestion = "Under vilket århundrade levde Carl Michael Bellman?",
                Options = new List<string>() { "1500-talet", "1600-talet", "1700-talet", "1800-talet" },
                Answer = "1700-talet",
                Category = "Konstens historia"
            };
            Question q49 = new Question
            {
                NameOfQuestion = "Vilken händelse inleder andra världskriget 1 september 1939?",
                Options = new List<string>() { "Tyskland invaderar Danmark", "Tyskland invaderar Polen", "Tyskland invaderar Sovjetunionen", "Sovjetunionen invaderar Estland" },
                Answer = "Tyskland invaderar Polen",
                Category = "Världskrig"
            };
            Question q50 = new Question
            {
                NameOfQuestion = "Våren 1940 ockuperade Tyskland två nordiska länder. Vilka länder var det?",
                Options = new List<string>() { "Norge och Finland", "Danmark och Norge", "Sverige och Norge", "Danmark och Sverige" },
                Answer = "Danmark och Norge",
                Category = "Världskrig"
            };
            Question q51 = new Question
            {
                NameOfQuestion = "Vad hette mannen som sköt Franz Ferdinand?",
                Options = new List<string>() { "Harald Pavić", "Harald Provice", "Gavrilo Princip", "Stanislav Princip" },
                Answer = "Gavrilo Princip",
                Category = "Världskrig"
            };
            Question q52 = new Question
            {
                NameOfQuestion = "Det serbiska terroristattentat som ledde fram till krigsutbrottet 1914 (och där den österrikisk-ungerske tronföljaren Franz Ferdinand och hans maka mördades) ägde rum i vilken stad?",
                Options = new List<string>() { "Sarajevo", "Paris", "Hamburg", "Moskva" },
                Answer = "Sarajevo",
                Category = "Världskrig"
            };
            Question q53 = new Question
            {
                NameOfQuestion = "Vilken typ av glasyr går traditionellt på morotskaka?",
                Options = new List<string>() { "Smörkräm", "Gräddfil", "Vispad grädde", "Färskost" },
                Answer = "Färskost",
                Category = "Desserter"
            };
            Question q54 = new Question
            {
                NameOfQuestion = "Vilket land kommer cheesecaken från?",
                Options = new List<string>() { "Frankrike", "Finland", "England", "Italien" },
                Answer = "Frankrike",
                Category = "Desserter"
            };
            Question q55 = new Question
            {
                NameOfQuestion = "Vilken nöt döljer sig i julrisgrynsgröt i Sverige?",
                Options = new List<string>() { "Jordnöt", "Hasselnöt", "Valnöt", "Mandel" },
                Answer = "Mandel",
                Category = "Desserter"
            };
            Question q56 = new Question
            {
                NameOfQuestion = "Vilken populär mexikansk dessert är täckt med karamell?",
                Options = new List<string>() { "Shortcake", "Flan", "Cannoli", "Tiramisu" },
                Answer = "Flan",
                Category = "Desserter"
            };
            Question q57 = new Question
            {
                NameOfQuestion = "Vilken är den traditionella huvudefterrätten i det franska köket?",
                Options = new List<string>() { "Kräm", "Ost", "Vispad grädde", "Frukt" },
                Answer = "Ost",
                Category = "Franska köket"
            };
            Question q58 = new Question
            {
                NameOfQuestion = "Vilken fransk delikatess är gjord på grund av vilken fransmän fick ett av deras smeknamn?",
                Options = new List<string>() { "Spindlar", "Grodor", "Sniglar", "Gräshoppor" },
                Answer = "Grodor",
                Category = "Franska köket"
            };
            Question q59 = new Question
            {
                NameOfQuestion = "Vad heter traditionellt långt franskt bröd - mjukt inuti och med en krispig skorpa ute?",
                Options = new List<string>() { "Baguette", "Calvados", "Shpalet", "Pain boule" },
                Answer = "Baguette",
                Category = "Franska köket"
            };
            Question q60 = new Question
            {
                NameOfQuestion = "Vad är bechamel?",
                Options = new List<string>() { "En grundläggande sås", "En ostsort", "En frank efterrätt", "En fransk drink" },
                Answer = "En grundläggande sås",
                Category = "Franska köket"
            };
            Question q61 = new Question
            {
                NameOfQuestion = "Vilken stad dök den första italienska pizzan upp i?",
                Options = new List<string>() { "Palermo", "Rom", "Neapel", "Milano" },
                Answer = "Neapel",
                Category = "Italienska köket"
            };
            Question q62 = new Question
            {
                NameOfQuestion = "Vilken av dessa är inte ingrediensen i carbonara?",
                Options = new List<string>() { "Mjölk", "Ägg", "Bacon", "Ost" },
                Answer = "Mjölk",
                Category = "Italienska köket"
            };
            Question q63 = new Question
            {
                NameOfQuestion = "Vad är Calzone?",
                Options = new List<string>() { "En grönsakssallad", "En vikad pizza", "En mängd pasta", "En pastasås" },
                Answer = "En vikad pizza",
                Category = "Italienska köket"
            };
            Question q64 = new Question
            {
                NameOfQuestion = "I Sverige har vi köttfärssåsen, men vad kallas denna förfinade rätt från Italien?",
                Options = new List<string>() { "Pasta bolognese", "Pasta tomato", "Pasta salsiccio", "Pasta carbonara" },
                Answer = "Pasta bolognese",
                Category = "Italienska köket"
            };
            Question q65 = new Question
            {
                NameOfQuestion = "Vilken ört ingår i en Mojito?",
                Options = new List<string>() { "Basilika", "Oregano", "Mynta", "Rosmarin" },
                Answer = "Mynta",
                Category = "Drinkar & cocktails"
            };
            Question q66 = new Question
            {
                NameOfQuestion = "Vilken juice är basen i en Bloody Mary?",
                Options = new List<string>() { "Rödbetsjuice", "Apelsinjuice", "Tomatjuice", "Morotsjuice" },
                Answer = "Tomatjuice",
                Category = "Drinkar & cocktails"
            };
            Question q67 = new Question
            {
                NameOfQuestion = "Vilken drink förknippas med James Bond?",
                Options = new List<string>() { "Dry Martini", "Negroni", "Whiskey Sour", "Old Fashioned" },
                Answer = "Dry Martini",
                Category = "Drinkar & cocktails"
            };
            Question q68 = new Question
            {
                NameOfQuestion = "Vad heter drinken med samma namn som en stadsdel i New York?",
                Options = new List<string>() { "Queens", "Brooklyn", "Manhattan", "Bronx" },
                Answer = "Manhattan",
                Category = "Drinkar & cocktails"
            };

            Questions.AddRange(new List<Question> { q0, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24, q25, q26, q27, q28, q29, q30, q31, q32, q33, q34, q35, q36, q37, q38, q39, q40, q41, q42, q43, q44, q45, q46, q47, q48, q49, q50, q51, q52, q53, q54, q55, q56, q57, q58, q59, q60, q61, q62, q63, q64, q65, q66, q67, q68 });
        }
    }
}
