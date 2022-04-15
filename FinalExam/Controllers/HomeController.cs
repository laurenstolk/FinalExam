using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalExam.Models;
using System.Security.Cryptography;

namespace FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private IQuotesRepository repo;

        public HomeController(IQuotesRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var x = repo.Quotes // pass in all the current quotes
                .OrderBy(x => x.Author)
                .ToList();

            return View(x);
        }

        public IActionResult ViewQuoteDetails(int quoteid)
        {
            var quote = repo.Quotes.Single(x => x.QuoteID == quoteid); // grab the quote with the specific quoteid that was passed in
            return View(quote);
        }

        public IActionResult RandomQuote()
        {
            var lowerBound = 1; // set a lower bound for the range
            var upperBound = repo.Quotes.Max(x => x.QuoteID); // grab the highest quoteid and set an upper bound for the range
            var randomNumber = RandomNumberGenerator.GetInt32(lowerBound, upperBound); // generate a random number in range from 1 to max quote id

            var quote = repo.Quotes.Single(x => x.QuoteID == randomNumber); // grab the quote with that random quote id

            return View(quote);
        }

        [HttpGet]
        public IActionResult AddQuote()
        {
            Quote quote = new Quote(); // make a new quote object
            ViewBag.Quotes = repo.Quotes.ToList(); // pass in all the current quotes
            return View("EditQuote", quote);
        }

        [HttpPost]
        public IActionResult AddQuote(Quote q)
        {
            if (ModelState.IsValid) // check if the fields meet the data requirements
            {
                repo.AddQuote(q);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Quotes = repo.Quotes.ToList();
                return View(q);
            }
        }

        [HttpGet]
        public IActionResult EditQuote(int quoteid)
        {
            var quote = repo.Quotes.Single(x => x.QuoteID == quoteid); // grab the quote with the specific quoteid that was passed in
            return View(quote);
        }

        [HttpPost]
        public IActionResult EditQuote(Quote q)
        {
            repo.EditQuote(q);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteQuote(int quoteid)
        {
            var quote = repo.Quotes.Single(x => x.QuoteID == quoteid); // grab the quote with the specific quoteid that was passed in
            repo.DeleteQuote(quote);
            return RedirectToAction("Index");
        }

    }
}
