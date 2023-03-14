namespace CHBlazorPortfolio
{
    public class ComicPage
    {
        public string fileName;
        public string? comment { get; set; }

        public ComicPage(string fileName) : this(fileName, comment: "") { }

        public ComicPage(string fileName, string comment) { this.fileName = fileName; this.comment = comment; }
    }
}
