using System;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Models
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options) : base (options)
        {
        }

        public DbSet<Quote> Quotes { get; set; }

        // seed the data if you want to
        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<Quote>().HasData(
        //        new Quote
        //        {
        //            QuoteID = 1,
        //            Words = "I am happy because I'm grateful. I choose to be grateful. That gratitude allows me to be happy.",
        //            Author = "Will Arnett",
        //            Date = "January 8, 2003",
        //            Subject = "Gratitude",
        //            Citation = "",
        //        },
        //        new Quote
        //        {
        //            QuoteID = 2,
        //            Words = "Do what is right all the time, regardless of who knows.",
        //            Author = "David F Evans",
        //            Date = "April 2006",
        //            Subject = "Integrity",
        //            Citation = "",
        //        },
        //        new Quote
        //        {
        //            QuoteID = 3,
        //            Words = "Make a sacrifice to the Lord... and then be prepared to be surprised. God is a great compensator.",
        //            Author = "Wendy Watson Nelson",
        //            Date = "October 1998",
        //            Subject = "Sacrifice",
        //            Citation = "",
        //        }
        //    );
        //}

    }
}
