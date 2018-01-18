using RedditProject.Entities;
using RedditProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Repositories
{
    public class RedditRepository
    {
        public RedditRepository(RedditContext redditContext)
        {
            RedditContext = redditContext;
        }

        public RedditContext RedditContext { get; set; }

        public List<Reddit> PostList()
        {
            List<Reddit> Postlist = new List<Reddit>();

            foreach (var item in RedditContext.Reddits)
            {
                Postlist.Add(item);
            }

            return Postlist;
        }

        public void AddPost(string content)
        {
            Reddit newPost = new Reddit()
            {
                Content = content
            };
            RedditContext.Add(newPost);
            RedditContext.SaveChanges();
        }
    }
}
