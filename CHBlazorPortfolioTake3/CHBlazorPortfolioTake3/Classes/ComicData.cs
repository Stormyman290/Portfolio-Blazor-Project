namespace CHBlazorPortfolioTake3.Classes
{
    public class ComicData
    {
        public string comicTitle = "Default";
        public string[] comicURL = new string[] { "ComicPages/QuestForJonuts-OriginalRun-01.png" };
        public string commentParagraph = "Default 2oo";

        //TODO Should I have a connection the next and previouis pages???


        public ComicData()
        {

        }

        public ComicData(string comicTitle, string[] comicURL, string commentParagraph)
        {
            this.comicTitle = comicTitle;
            this.comicURL = comicURL;
            this.commentParagraph = commentParagraph;
        }
    }
}
