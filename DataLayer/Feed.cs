using System.Collections.Generic;

namespace DataLayer
{
    public class Feed
    {
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string Link { get; set; }
        public string Folder { get; set; }
        public int Intervall { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
