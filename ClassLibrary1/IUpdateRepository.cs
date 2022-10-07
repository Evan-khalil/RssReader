using BLL;
using DataLayer;
using System.Collections.Generic;
using System.Timers;


namespace WindowsFormsTimer
{
    public class IUpdateRepository : Category
    {
        public static Timer _timer;
        private readonly IFeedRepository _feedRepository = new IFeed();
        private readonly IRepository _repository = new Repository();
        public override List<Feed> Feeds { get; set; }
        public IUpdateRepository()
        {
            _timer = new Timer();

        }
        public void Update()
        {
            _timer.Elapsed += OnTimeElased;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public void OnTimeElased(object source, ElapsedEventArgs e)
        {
            Feeds = _repository.GetFeeds();
            foreach (Feed feed in Feeds)
            {
                _feedRepository.Add(feed.Link, feed.Intervall, feed.Folder, feed.Title, feed.CategoryName);
                _timer.Interval = feed.Intervall;
            }

        }

    }

}
