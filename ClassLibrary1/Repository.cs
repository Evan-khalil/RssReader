using DataLayer;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BLL
{
    public class Repository : IRepository
    {
        private readonly XmlSerializer xmlSerializer = new XmlSerializer(typeof(Feed));

        public List<Feed> GetFeeds()
        {
            List<Category> getCategories = GetCategories();
            List<Feed> feeds = new List<Feed>();
            foreach (Category category in getCategories)
            {
                string[] feedList = Directory.GetFiles(category.Name);
                FileInfo information = new FileInfo(category.Name);
                foreach (string feed in feedList)
                {
                    using (StreamReader reader = new StreamReader(feed))
                    {
                        feeds.Add((Feed)xmlSerializer.Deserialize(reader));
                        reader.Close();
                    }
                }
            }
            return feeds;
        }
        public List<Feed> GetFeeds(string path)
        {

            string[] files = Directory.GetFiles(path);
            List<Feed> feeds = new List<Feed>();
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                using (StreamReader reader = new StreamReader(file))
                {
                        feeds.Add((Feed)xmlSerializer.Deserialize(reader));
                        reader.Close();
             
                }
            }
            return feeds;
        }
        public List<Category> GetCategories()
        {
            string Path = Directory.GetCurrentDirectory();
            string[] Folder = Directory.GetDirectories(Path);
            List<Category> Categories = new List<Category>();
            foreach (string category in Folder)
            {
                DirectoryInfo information = new DirectoryInfo(category);
                Categories.Add(new Category()
                {
                    Name = information.Name,
                    Path = category,
                    Feeds =
                    GetFeeds(category)
                });
            }
            return Categories;
        }
    }
}
