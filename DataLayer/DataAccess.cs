using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace DataLayer
{
    public class DataAccess
    {
        //Get episodes from link 
        public async Task<List<Episode>> GetEpisodes(string Link)
        {
            using (XmlReader xmlReader = XmlReader.Create(Link))
            {
                SyndicationFeed syndicationFeed = SyndicationFeed.Load(xmlReader);
                List<Episode> episodes = new List<Episode>();
                foreach (SyndicationItem item in syndicationFeed.Items)
                {
                    Episode Episode = new Episode
                    {
                        Title = item.Title.Text,
                        Description = item.Summary.Text,
                        Date = item.PublishDate.ToString()
                    };
                    episodes.Add(Episode);
                }
                return episodes;
                await GetEpisodes(Link);
                xmlReader.Close();
            }

        }

        //Add feed
        public async Task AddFeed(string Link, int Intervall, string Folder, string Title, string categoryName)
        {
            Feed feed = new Feed
            {
                Title = Title,
                CategoryName = categoryName,
                Link = Link,
                Intervall = Intervall,
                Folder = Folder,
                Episodes = await GetEpisodes(Link)
            };
            Save(feed);
        }

        //save file 
        public void Save(Feed feed)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Feed));
            using (StreamWriter streamWriter = new StreamWriter(feed.Folder))
            {
                xmlSerializer.Serialize(streamWriter, feed);
                streamWriter.Close();
            }
        }

    }
}



