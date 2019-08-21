using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PrizeTracker.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TournamentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TournamentContext>>()))
            {
                // Look for any Tournaments.
                if (context.Tournament.Any())
                {
                    return;   // DB has been seeded
                }

                context.Tournament.AddRange(
                    new Tournament
                    {
                        TournamentName = "The International 2019",
                        StartDate = DateTime.Parse("2019-08-15"),
                        EndDate = DateTime.Parse("2019-08-25"),
                        PrizePool = 30993000,
                        NumberOfPlayers = 18,
                        Location = "Shanghai",
                    },

                    new Tournament
                    {
                        TournamentName = "EPICENTER Major",
                        StartDate = DateTime.Parse("2019-06-22"),
                        EndDate = DateTime.Parse("2019-06-30"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Moscow",
                        Winner = "Vici Gaming",
                        RunnerUp = "Team Liquid"
                    },

                    new Tournament
                    {
                        TournamentName = "MDL Disneyland Paris Major",
                        StartDate = DateTime.Parse("2019-05-04"),
                        EndDate = DateTime.Parse("2019-05-12"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Paris",
                        Winner = "Team Secret",
                        RunnerUp = "Team Liquid"
                    },

                    new Tournament
                    {
                        TournamentName = "DreamLeague Season 11",
                        StartDate = DateTime.Parse("2019-03-14"),
                        EndDate = DateTime.Parse("2019-03-24"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Stockholm",
                        Winner = "Vici Gaming",
                        RunnerUp = "Virtus Pro"
                    },

                    new Tournament
                    {
                        TournamentName = "World Electronic Sports Games 2018",
                        StartDate = DateTime.Parse("2019-03-07"),
                        EndDate = DateTime.Parse("2019-03-10"),
                        PrizePool = 890000,
                        NumberOfPlayers = 24,
                        Location = "Chongqing",
                        Winner = "TNC Predator",
                        RunnerUp = "Keen Gaming"
                    },

                    new Tournament
                    {
                        TournamentName = "The Chongqing Major",
                        StartDate = DateTime.Parse("2019-01-19"),
                        EndDate = DateTime.Parse("2019-01-27"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Chongqing",
                        Winner = "Team Secret",
                        RunnerUp = "Virtus Pro"
                    },

                    new Tournament
                    {
                        TournamentName = "The Kuala Lumpur Major",
                        StartDate = DateTime.Parse("2018-11-09"),
                        EndDate = DateTime.Parse("2018-11-18"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Kuala Lumpur",
                        Winner = "Virtus Pro",
                        RunnerUp = "Team Secret"
                    },

                    new Tournament
                    {
                        TournamentName = "The International 2018",
                        StartDate = DateTime.Parse("2018-08-25"),
                        EndDate = DateTime.Parse("2019-08-15"),
                        PrizePool = 25532177,
                        NumberOfPlayers = 18,
                        Location = "Vancouver",
                        Winner = "OG",
                        RunnerUp = "PSG.LGD"
                    },

                    new Tournament
                    {
                        TournamentName = "China Dota2 Supermajor",
                        StartDate = DateTime.Parse("2018-06-02"),
                        EndDate = DateTime.Parse("2018-06-10"),
                        PrizePool = 1500000,
                        NumberOfPlayers = 16,
                        Location = "Shanghai",
                        Winner = "Team Liquid",
                        RunnerUp = "Virtus Pro"
                    },

                    new Tournament
                    {
                        TournamentName = "ESL One Birmingham 2018",
                        StartDate = DateTime.Parse("2018-05-23"),
                        EndDate = DateTime.Parse("2018-05-27"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 12,
                        Location = "Birmingham",
                        Winner = "Virtus Pro",
                        RunnerUp = "OpTic Gaming"
                    },

                    new Tournament
                    {
                        TournamentName = "MDL Changsha Major",
                        StartDate = DateTime.Parse("2018-05-14"),
                        EndDate = DateTime.Parse("2018-05-20"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 12,
                        Location = "Changsha",
                        Winner = "PSG.LGD",
                        RunnerUp = "VGJ.Storm"
                    },


                    new Tournament
                    {
                        TournamentName = "EPICENTER XL",
                        StartDate = DateTime.Parse("2018-04-27"),
                        EndDate = DateTime.Parse("2018-05-06"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 12,
                        Location = "Moscow",
                        Winner = "PSG.LGD",
                        RunnerUp = "Team Liquid"
                    },

                    new Tournament
                    {
                        TournamentName = "Dota 2 Asia Championships 2018",
                        StartDate = DateTime.Parse("2018-03-29"),
                        EndDate = DateTime.Parse("2018-04-07"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Shanghai",
                        Winner = "Mineski",
                        RunnerUp = "LGD"
                    },

                    new Tournament
                    {
                        TournamentName = "World Electronic Sports Games 2017",
                        StartDate = DateTime.Parse("2018-03-13"),
                        EndDate = DateTime.Parse("2018-03-18"),
                        PrizePool = 1500000,
                        NumberOfPlayers = 30,
                        Location = "Haikou",
                        Winner = "RUS",
                        RunnerUp = "paiN Gaming"
                    },

                    new Tournament
                    {
                        TournamentName = "The Bucharest Major",
                        StartDate = DateTime.Parse("2018-03-04"),
                        EndDate = DateTime.Parse("2018-03-11"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Bucharest",
                        Winner = "Virtus Pro",
                        RunnerUp = "VGJ.Thunder"
                    },

                    new Tournament
                    {
                        TournamentName = "ESL One Katowice 2018",
                        StartDate = DateTime.Parse("2018-02-20"),
                        EndDate = DateTime.Parse("2018-02-25"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 16,
                        Location = "Katowice",
                        Winner = "Virtus Pro",
                        RunnerUp = "Vici Gaming"
                    },

                    new Tournament
                    {
                        TournamentName = "DreamLeague Season 8",
                        StartDate = DateTime.Parse("2017-12-01"),
                        EndDate = DateTime.Parse("2017-12-03"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 8,
                        Location = "Jonkoping",
                        Winner = "Team Secret",
                        RunnerUp = "Team Liquid"
                    },

                    new Tournament
                    {
                        TournamentName = "ESL One Hamburg 2017",
                        StartDate = DateTime.Parse("2017-10-26"),
                        EndDate = DateTime.Parse("2017-10-29"),
                        PrizePool = 1000000,
                        NumberOfPlayers = 8,
                        Location = "Hamburg",
                        Winner = "Virtus Pro",
                        RunnerUp = "Team Secret"
                    },

                    new Tournament
                    {
                        TournamentName = "The International 2017",
                        StartDate = DateTime.Parse("2017-08-02"),
                        EndDate = DateTime.Parse("2017-08-12"),
                        PrizePool = 24787916,
                        NumberOfPlayers = 16,
                        Location = "Seattle",
                        Winner = "Team Liquid",
                        RunnerUp = "Newbee"
                    },

                    new Tournament
                    {
                        TournamentName = "Mars Dota 2 League 2017",
                        StartDate = DateTime.Parse("2017-07-05"),
                        EndDate = DateTime.Parse("2017-07-09"),
                        PrizePool = 250000,
                        NumberOfPlayers = 8,
                        Location = "Wuhan",
                        Winner = "LGD",
                        RunnerUp = "LFY"
                    },

                    new Tournament
                    {
                        TournamentName = "DOTA Summit 7",
                        StartDate = DateTime.Parse("2017-06-14"),
                        EndDate = DateTime.Parse("2017-06-18"),
                        PrizePool = 100000,
                        NumberOfPlayers = 8,
                        Location = "Los Angeles",
                        Winner = "Virtus Pro",
                        RunnerUp = "Team Secret"
                    },

                    new Tournament
                    {
                        TournamentName = "Galaxy Battles",
                        StartDate = DateTime.Parse("2017-06-15"),
                        EndDate = DateTime.Parse("2017-06-18"),
                        PrizePool = 150000,
                        NumberOfPlayers = 8,
                        Location = "Shenzhen",
                        Winner = "Newbee",
                        RunnerUp = "ODD"
                    },

                    new Tournament
                    {
                        TournamentName = "EPICENTER 2017",
                        StartDate = DateTime.Parse("2017-06-04"),
                        EndDate = DateTime.Parse("2017-06-11"),
                        PrizePool = 500000,
                        NumberOfPlayers = 10,
                        Location = "Moscow",
                        Winner = "Team Liquid",
                        RunnerUp = "EG"
                    },

                    new Tournament
                    {
                        TournamentName = "ZOTAC Cup Masters",
                        StartDate = DateTime.Parse("2017-05-30"),
                        EndDate = DateTime.Parse("2017-06-03"),
                        PrizePool = 100000,
                        NumberOfPlayers = 8,
                        Location = "Taipei",
                        Winner = "Newbee",
                        RunnerUp = "NP"
                    },

                    new Tournament
                    {
                        TournamentName = "The Manila Masters",
                        StartDate = DateTime.Parse("2017-05-25"),
                        EndDate = DateTime.Parse("2017-05-28"),
                        PrizePool = 250000,
                        NumberOfPlayers = 8,
                        Location = "Manila",
                        Winner = "EG",
                        RunnerUp = "Newbee"
                    },

                    new Tournament
                    {
                        TournamentName = "StarLadder i-League Invitational Season 2",
                        StartDate = DateTime.Parse("2017-05-18"),
                        EndDate = DateTime.Parse("2017-05-21"),
                        PrizePool = 100000,
                        NumberOfPlayers = 8,
                        Location = "Shanghai",
                        Winner = "Team Liquid",
                        RunnerUp = "TNC"
                    },

                    new Tournament
                    {
                        TournamentName = "The Kiev Major 2017",
                        StartDate = DateTime.Parse("2017-04-24"),
                        EndDate = DateTime.Parse("2017-04-30"),
                        PrizePool = 3000000,
                        NumberOfPlayers = 16,
                        Location = "Kiev",
                        Winner = "OG",
                        RunnerUp = "Virtus Pro"
                    },

                    new Tournament
                    {
                        TournamentName = "Dota 2 Asia Champhionships 2017",
                        StartDate = DateTime.Parse("2017-03-27"),
                        EndDate = DateTime.Parse("2017-04-04"),
                        PrizePool = 611997,
                        NumberOfPlayers = 12,
                        Location = "Shanghai",
                        Winner = "Invictus Gaming",
                        RunnerUp = "OG"
                    },


                    new Tournament
                    {
                        TournamentName = "StarLadder i-League StarSeries Season 3",
                        StartDate = DateTime.Parse("2017-02-23"),
                        EndDate = DateTime.Parse("2017-02-26"),
                        PrizePool = 300000,
                        NumberOfPlayers = 8,
                        Location = "Shanghai",
                        Winner = "Liquid",
                        RunnerUp = "VGJ.Thunder"
                    },


                    new Tournament
                    {
                        TournamentName = "Dota Pit League Season 5",
                        StartDate = DateTime.Parse("2017-01-20"),
                        EndDate = DateTime.Parse("2017-01-22"),
                        PrizePool = 139860,
                        NumberOfPlayers = 8,
                        Location = "Split",
                        Winner = "EG",
                        RunnerUp = "OG"
                    },

                    new Tournament
                    {
                        TournamentName = "World Electronic Sports Games 2016",
                        StartDate = DateTime.Parse("2017-01-12"),
                        EndDate = DateTime.Parse("2017-01-15"),
                        PrizePool = 1500000,
                        NumberOfPlayers = 8,
                        Location = "Changzhou",
                        Winner = "TNC",
                        RunnerUp = "Cloud 9"
                    },

                    new Tournament
                    {
                        TournamentName = "ESL One Genting 2017",
                        StartDate = DateTime.Parse("2017-01-06"),
                        EndDate = DateTime.Parse("2017-01-08"),
                        PrizePool = 250000,
                        NumberOfPlayers = 8,
                        Location = "Genting Highlands",
                        Winner = "Digital Chaos",
                        RunnerUp = "Newbee"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}