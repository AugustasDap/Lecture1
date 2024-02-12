using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    internal class SportLeague<T>
    {
        private string sport;
        private List<T> teams;

        public SportLeague(string sport)
        {
            this.sport = sport;
            this.teams = new List<T>();
        }

        public void AddTeam(T team, string teamSport)
        {
            if (teamSport != this.sport)
            {
                throw new ArgumentException($"Cannot add a {teamSport} team to a {this.sport} league");
            }
            this.teams.Add(team);
        }

        public void PrintTeams()
        {
            if (this.teams.Count == 0)
            {
                Console.WriteLine("No teams currently in the league");
            }
            else
            {
                Console.WriteLine($"Teams in the {this.sport} league:");
                foreach (var team in this.teams)
                {
                    Console.WriteLine(team);
                }
            }
        }
    }
}
