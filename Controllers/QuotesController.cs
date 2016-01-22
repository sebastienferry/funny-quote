using FunnyQuote.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;

namespace HelloApi.Controllers
{
    [Route("/api/quotes")]
    public class QuotesController
    {
        private static List<Quote> _quotes = new List<Quote>()
        {
            new Quote(){ Text = "The best thing about a boolean is even if you are wrong, you are only off by a bit.", Author = "Anonymous" },
            new Quote(){ Text = "Without requirements or design, programming is the art of adding bugs to an empty text file.", Author = "Louis Srygley" },
            new Quote(){ Text = "Before software can be reusable it first has to be usable.", Author = "Ralph Johnson" },
            new Quote(){ Text = "The best method for accelerating a computer is the one that boosts it by 9.8 m/s2.", Author = "Anonymous" },
            new Quote(){ Text = "I think Microsoft named .Net so it wouldn’t show up in a Unix directory listing.", Author = "Oktal" },
            new Quote(){ Text = "If builders built buildings the way programmers wrote programs, then the first woodpecker that came along wound destroy civilization.", Author = "Gerald Weinberg" },
            new Quote(){ Text = "There are two ways to write error-free programs; only the third one works.", Author = "Alan J. Perlis" },
            new Quote(){ Text = "Ready, fire, aim:  the fast approach to software development.  Ready, aim, aim, aim, aim:  the slow approach to software development.", Author = "Anonymous" },
            new Quote(){ Text = "It’s not a bug – it’s an undocumented feature.", Author = "Anonymous" },
            new Quote(){ Text = "One man’s crappy software is another man’s full time job.", Author = "Jessica Gaston" },
            new Quote(){ Text = "A good programmer is someone who always looks both ways before crossing a one-way street.", Author = "Doug Linder" },
            new Quote(){ Text = "Always code as if the guy who ends up maintaining your code will be a violent psychopath who knows where you live.", Author = "Martin Golding"},
            new Quote(){ Text = "Programming is like sex.  One mistake and you ,have to support it for the rest of your life.", Author = "Michael Sinz" },
            new Quote(){ Text = "Deleted code is debugged code.", Author = "Jeff Sickel" },
            new Quote(){ Text = "Walking on water and developing software from a specification are easy if both are frozen.", Author = "Edward V Berard" },
            new Quote(){ Text = "If debugging is the process of removing software bugs, then programming must be the process of putting them in.", Author = "Edsger Dijkstra" },
            new Quote(){ Text = "Software undergoes beta testing shortly before it’s released.  Beta is Latin for “still doesn’t work.", Author = "Anonymous" },
            new Quote(){ Text = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to produce bigger and better idiots.  So far, the ,universe is winning.", Author = "Rick Cook" },
            new Quote(){ Text = "It’s a curious thing about our industry: not only do we not learn from our mistakes, we also don’t learn from our successes.", Author = "Keith Braithwaite" },
            new Quote(){ Text = "There are only two kinds of programming languages: those people always bitch about and those nobody uses.", Author = "Bjarne Stroustrup" },
            new Quote(){ Text = "In order to understand recursion, one must first understand recursion.", Author = "Anonymous" },
            new Quote(){ Text = "The cheapest, fastest, and most reliable components are those that aren’t there.", Author = "Gordon Bell" },
            new Quote(){ Text = "The best performance improvement is the transition from the nonworking state to the working state.", Author = "J. Osterhout" },
            new Quote(){ Text = "The trouble with programmers is that you can never tell what a programmer is doing until it’s too late.", Author = "Seymour Cray" },
            new Quote(){ Text = "Don’t worry if it doesn’t work right.  If everything did, you’d be out of a job.", Author = "Mosher’s Law of Software Engineering" }
        };
        
        [Route("/api/quotes")]
        public IEnumerable<Quote> Get() => _quotes;
        
        [Route("/api/quote")]
        public Quote GetRandomQuote()
        {
            Random random = new Random();
            int index = random.Next(0, _quotes.Count);
            return _quotes[index];
        }
    }
} 

