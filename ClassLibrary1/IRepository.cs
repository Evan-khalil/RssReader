using DataLayer;
using System.Collections.Generic;

namespace BLL
{
    public interface IRepository
    {
        List<Feed> GetFeeds();
        List<Feed> GetFeeds(string path);
        List<Category> GetCategories();
    }
}
