using System.Text;

namespace CHBlazorPortfolioTake3.Classes
{
    public class ComicData
    {
        public string comicTitle = "Comic Title";
        public string[] authors = { "Christopher Hahn" };
        public List<ComicPage> comicPages = new List<ComicPage>();


        public ComicData()
        {
            comicPages.Add(new ComicPage());
        }

        public ComicData(string comicDataFileName)
        {
            string[] lines = File.ReadAllLines(comicDataFileName, Encoding.UTF8);

            comicTitle = lines[0];
            authors = lines[1].Split(',');

            for (int i = 3; i < lines.Length; i += 5)
            {
                comicPages.Add(new ComicPage(lines[i], lines[i + 1].Split(','), int.Parse(lines[i + 2]), lines[i + 3]));
            }
        }
    }
}
