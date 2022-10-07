namespace BLL
{
    public interface ICategoryRepository
    {
        void Add(string directory);
        void Delete(string categoryName);
        void Edit(string New, string Old);
    }
}
