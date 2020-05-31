using System;

namespace Post
{
    class Post
    {
        private string _title { get; set; }
        private string _description { get; set; }
        private string _created { get; set; }
        private int _upvote { get; set; }
        private int _downvote { get; set; }

        public string TitlePost()
        {
            _title = Console.ReadLine();
            return _title;
        }

        public string DescribePost()
        {
            _description = Console.ReadLine();
            return _description;
        }

        public string CreatePost()
        {
            _created = DateTime.Now.ToShortDateString();
            return _created;
        }

        public int Upvote(int upvote)
        {
            _upvote++;
            return _upvote;
        }

        public int Downvote(int downvote)
        {
            _downvote--;
            return _downvote;
        }
    }
}
