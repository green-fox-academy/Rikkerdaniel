using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var postit = new PostIt();
            var postit1 = new PostIt();
            var postit2 = new PostIt();
            postit.BackgrounColor = "orange";
            postit.Text = "idea1";
            postit.TextColor = "Blue";

            postit1.BackgrounColor = "pink";
            postit1.Text = "Awsome";
            postit1.TextColor = "Black";

            postit2.BackgrounColor = "yellow";
            postit2.Text = "super";
            postit2.TextColor = "green";

        }
    }
}
