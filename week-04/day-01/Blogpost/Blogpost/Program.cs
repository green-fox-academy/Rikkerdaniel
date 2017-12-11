using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogpost
{
    class Program
    {
        static void Main(string[] args)
        {
            var blog = new BlogPost();
            blog.AuthorName = "John Doe";
            blog.Title = "Lorem ipsum";
            blog.Text = "Lorem ipsum dolor sit amet.";
            blog.PublicationDate = "2000.05.04.";

            var blog1 = new BlogPost();
            blog1.AuthorName = "Tim Urban";
            blog1.Title = "Wait but why";
            blog1.Text = "A popular long-form, stick-figure-illustrated blog about almost everything";
            blog1.PublicationDate = "2010.10.10.";

            var blog2 = new BlogPost();
            blog2.AuthorName = "William Turton ";
            blog2.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blog2.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center" +
                " of attention. When I asked to take his picture outside one of IBM’s New York City offices," +
                " he told me that he wasn’t really into the whole organizer profile thing.";
            blog2.PublicationDate = " 2017.03.28.";
        }
    }
}
