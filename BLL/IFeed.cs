using DataLayer;
using System.IO;
using System.Threading.Tasks;

namespace BLL
{
    public class IFeed : IFeedRepository
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public async Task Add(string Link, int Intervall, string Folder, string Title, string Name)
        {

            await dataAccess.AddFeed(Link, Intervall, Folder, Title, Name);
        }

        public async Task Delete(string categoryName, string FeedName)
        {
            string Directory = Path.Combine(System.IO.Directory.GetCurrentDirectory(), FeedName, categoryName + @".xml");
            File.Delete(Directory);
        }
    }
}


