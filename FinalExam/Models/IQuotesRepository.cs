using System;
using System.Linq;

namespace FinalExam.Models
{
    public interface IQuotesRepository
    {
        IQueryable<Quote> Quotes { get; }

        //initiate the CRUD functions
        public void AddQuote(Quote q);
        public void EditQuote(Quote q);
        public void DeleteQuote(Quote q);

    }
}
