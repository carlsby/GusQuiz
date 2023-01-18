namespace GusQuiz.Models
{
    public class QuestionGolf
    {
        public string NameOfQuestion { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;
    }

    public class QuestionTennis
    {
        public string NameOfQuestion { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;
    }

    public class QuestionMusic
    {
        public string NameOfQuestion { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;
    }

    public class QuestionMovie
    {
        public string NameOfQuestion { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;
    }

    public class QuestionHockey
    {
        public string NameOfQuestion { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;
    }

    public class QuestionFotboll
    {
        public string NameOfQuestion { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;
    }

    public class Names
    {
        public string NameOfPerson { get; set; } = string.Empty;
    }
}
