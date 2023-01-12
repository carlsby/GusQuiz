namespace GusQuiz.Models
{
    public class Question
    {
        public string NameOfQuestion { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;
    }

    public class Question2
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
