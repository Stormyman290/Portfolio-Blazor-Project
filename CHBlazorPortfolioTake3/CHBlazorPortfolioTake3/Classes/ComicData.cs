using System.Diagnostics;
using System.Text;

namespace CHBlazorPortfolioTake3.Classes
{
    public class ComicData
    {
        public string ComicTitle { get; set; }
        public string[] Authors { get; set; }
        public string UrlPrefix { get; set; }
        public string FileType { get; set; }
        public List<ComicPage> ComicPages { get; set; }


        public ComicData()
        {
            ComicTitle = "Comic Title";
            Authors = new string[] { "Christopher Hahn" };
            UrlPrefix = "ComicPages/";
            FileType = ".png";

            ComicPages = new List<ComicPage>();
            ComicPages.Add(new ComicPage());
        }

        public void FixImageURLs()
        {
            foreach (ComicPage comic in ComicPages)
                for (int i = 0; i < comic.ImageURLs.Count(); i++)
                    comic.ImageURLs[i] = UrlPrefix + comic.ImageURLs[i] + FileType;
        }




        public ComicData(string comicDataFileName)
        {
            string[] lines = File.ReadAllLines(comicDataFileName, Encoding.UTF8);

            ComicTitle = lines[0];
            Authors = lines[1].Split(',');
            ComicPages = new List<ComicPage>();
            UrlPrefix = "ComicPages/";
            FileType = ".png";

            for (int i = 3; i < lines.Length; i += 5)
            {
                ComicPages.Add(new ComicPage(lines[i], lines[i + 1].Split(','), int.Parse(lines[i + 2]), lines[i + 3]));
            }
        }

        public ComicData(Stream stream)
        {
            Debug.WriteLine("@@@@");
            StreamReader sr = new StreamReader(stream);

            ComicTitle = sr.ReadLine();
            Debug.WriteLine(ComicTitle);
            Authors = sr.ReadLine().Split(',');
            sr.ReadLine(); //Dummy line

            ComicPages = new List<ComicPage>();
            UrlPrefix = "ComicPages/";
            FileType = ".png";

            for (int i = 3; sr.EndOfStream; i += 5)
            {
                ComicPages.Add(new ComicPage(sr.ReadLine(), sr.ReadLine().Split(','), int.Parse(sr.ReadLine()), sr.ReadLine()));
                Debug.WriteLine(ComicPages.Last().printValues());
                sr.ReadLine(); //Dummy line
            }
        }
    }
}
