using Post_.Entities;

namespace Exercise
{
    class Program
    {
        static void Main (string[] args)
        {
            Comment c1 = new Comment ("Have a nice tripe");
            Comment c2 = new Comment ("Wow that's awesome!");
            Post p1 = new Post (
                DateTime.Parse("06/21/2018 13:05:44"),
                "Traveling to New Zealand", "I'm going to visit this wonderfull country!", 12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);
            System.Console.WriteLine(p1);
            Comment c3 = new Comment ("Goodnight");
            Comment c4 = new Comment ("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("07/26/2018 23:14:19"), "Good night guys", " See you tomorrow", 5 
            );
            p2.AddComment(c3);
            p2.AddComment(c4);
            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);
        }
    }
}