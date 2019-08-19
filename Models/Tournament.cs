using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrizeTracker.Models
{
    public class Tournament
    {
        public int ID { get; set; }
        [Display(Name = "Tournament Name")]
        [StringLength(300, MinimumLength = 5)]
        [Required]
        public string TournamentName { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Prize Pool")]
        [Range(1, 100000000)]
        public int PrizePool { get; set; }
        [Display(Name = "Number of Players")]
        [Range(1, 50)]
        public int NumberOfPlayers { get; set; }
        [Required]
        public string Location { get; set; }
        public string Winner { get; set; }
        [Display(Name = "Runner Up")]
        public string RunnerUp { get; set; }
    }
}