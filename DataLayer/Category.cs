using System.Collections.Generic;

namespace DataLayer
{
    public class Category
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public virtual List<Feed> Feeds { get; set; }
    }
}
