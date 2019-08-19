using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrizeTracker.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PrizeTracker.Pages.Tournaments
{
    public class IndexModel : PageModel
    {
        private readonly PrizeTracker.Models.TournamentContext _context;

        public IndexModel(PrizeTracker.Models.TournamentContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string StartDateSort { get; set; }
        public string EndDateSort { get; set; }
        public string PrizeSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<Tournament> Tournament { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
         public string TournamentName { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            StartDateSort = sortOrder == "StartDate" ? "startdate_desc" : "StartDate";
            EndDateSort = sortOrder == "EndDate" ? "enddate_desc" : "EndDate";
            PrizeSort = sortOrder == "Prize" ? "prize_desc" : "Prize";
            CurrentFilter = searchString;


            IQueryable<Tournament> tournamentIQ = from t in _context.Tournament
                                select t;


            if (!String.IsNullOrEmpty(searchString))
            {
                tournamentIQ = tournamentIQ.Where(t => t.TournamentName.Contains(searchString));
    
            }


            switch (sortOrder)
            {
                case "name_desc":
                    tournamentIQ = tournamentIQ.OrderByDescending(t => t.TournamentName);
                    break;
                case "StartDate":
                    tournamentIQ = tournamentIQ.OrderBy(t => t.StartDate);
                    break;
                case "startdate_desc":
                    tournamentIQ = tournamentIQ.OrderByDescending(t => t.StartDate);
                    break;
                case "EndDate":
                    tournamentIQ = tournamentIQ.OrderBy(t => t.EndDate);
                    break;
                case "enddate_desc":
                    tournamentIQ = tournamentIQ.OrderByDescending(t => t.EndDate);
                    break;
                case "Prize":
                    tournamentIQ = tournamentIQ.OrderBy(t => t.PrizePool);
                    break;
                case "prize_desc":
                    tournamentIQ = tournamentIQ.OrderByDescending(t => t.PrizePool);
                    break;
                default:
                    tournamentIQ = tournamentIQ.OrderByDescending(t => t.StartDate);
                    break;
    }


            Tournament = await tournamentIQ.AsNoTracking().ToListAsync();

            
        }
    }
}
