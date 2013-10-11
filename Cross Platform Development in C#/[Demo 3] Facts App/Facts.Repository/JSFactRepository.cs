using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facts.Domain.Entities;
using Facts.Domain.Repository;

namespace Facts.Repository
{
    public class JSFactRepository : IFactRepository
    {
        private Random random;
        private List<string> JSFacts = new List<string>()
        {
            "Jon Skeet is immutable. If something’s going to change, it’s going to have to be the rest of the universe.",
            "Jon Skeet doesn’t have performance bottlenecks. He just makes the universe wait its turn.",
            "Users don’t mark Jon Skeet’s answers as accepted. The universe accepts them out of a sense of truth and justice.",
            "Anonymous methods and anonymous types are really all called Jon Skeet. They just don’t like to boast.",
            "Jon Skeet does not use revision control software. None of his code has ever needed revision.",
            "When Jon Skeet’s code fails to compile, the compiler apologises.",
            "Jon Skeet is the traveling salesman. Only he knows the shortest route.",
            "When Jon Skeet points to null, null quakes in fear.",
            "Jon Skeet coded his last project entirely in Microsoft Paint, just for the challenge.",
            "Jon Skeet can believe it’s not butter.",
            "Jon Skeet can code in Perl and make it look like Java",
            "Jon Skeet codes only with final sealed methods. No one has ever needed to override any of Jon Skeet’s code.",
            "Jon Skeet programs in binary, then compiles it into human-readable code.",
            "Jon Skeet can make IE obey his CSS rules.",
            "Jon Skeet can divide by zero.",
            "Jon Skeet has already written a book about C# 5.0. It’s currently sealed up. In three years, Anders Hejlsberg is going to open the book to see if the language design team got it right.",
        };

        public JSFactRepository()
        {
            random = new Random();
        }
        public Task<Fact> GetFact()
        {
            int item = random.Next(0, JSFacts.Count);

            var Fact = new Fact() { TheFact = JSFacts[item] };
            return Task.FromResult(Fact);
        }
    }
}
