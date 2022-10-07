using System.Threading.Tasks;

namespace BLL
{
    public interface IFeedRepository
    {
        Task Add(string Link, int Intervall, string Folder, string Title, string categoryName);
        Task Delete(string categoryName, string FeedName);
    }
}
