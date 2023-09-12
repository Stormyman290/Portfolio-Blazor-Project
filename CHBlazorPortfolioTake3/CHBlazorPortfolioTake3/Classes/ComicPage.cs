namespace CHBlazorPortfolioTake3.Classes
{
    public class ComicPage
    {
        public string title = "Default";
        public string[] imageURLs = new string[] { "ComicPages/QuestForJonuts-OriginalRun-01.png" };
        public int thumbnailIndex = 0;
        public string comment = "Default 2oo";

        public ComicPage()
        {

        }

        public ComicPage(string comicTitle, string[] comicURL, int thumbnailIndex, string commentParagraph)
        {
            this.title = comicTitle;
            this.imageURLs = comicURL;
            this.thumbnailIndex = thumbnailIndex;
            this.comment = commentParagraph;
        }
    }
}
