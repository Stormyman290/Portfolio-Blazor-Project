namespace CHBlazorPortfolioTake3.Classes
{
    public class ComicPage
    {
        public string Title { get; set; }
        public string[] ImageURLs { get; set; }
        public int ThumbnailIndex { get; set; }
        public string Comment { get; set; }

        public ComicPage()
        {
            Title = "Default";
            ImageURLs = new string[] { "ComicPages/QuestForJonuts-OriginalRun-01.png" };
            ThumbnailIndex = 0;
            Comment = "Default 2oo";
        }

        public ComicPage(string comicTitle, string[] comicURL, int thumbnailIndex, string commentParagraph)
        {
            this.Title = comicTitle;
            this.ImageURLs = comicURL;
            this.ThumbnailIndex = thumbnailIndex;
            this.Comment = commentParagraph;
        }

        public string printValues()
        {
            return "title: " + Title +
                "\nimageURLs: " + ImageURLs +
                "\nthumbnailIndex: " + ThumbnailIndex +
                "\ncomment: " + Comment;
        }
    }
}
