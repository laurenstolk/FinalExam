using System;
using System.Linq;

namespace FinalExam.Models
{
    public class EFQuotesRepository : IQuotesRepository
    {
        private QuotesDbContext context { get; set; }

        public EFQuotesRepository (QuotesDbContext temp)
        {
            context = temp;
        }

        public IQueryable<Quote> Quotes => context.Quotes;

        // implement the CRUD functions
        public void AddQuote(Quote q)
        {
            context.Add(q);
            context.SaveChanges();
        }
        public void EditQuote(Quote q)
        {
            context.Update(q);
            context.SaveChanges();
        }
        public void DeleteQuote(Quote q)
        {
            context.Remove(q);
            context.SaveChanges();
        }
    }
}
