using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string name = input[0];
                string team = input[1];
                Team t = new Team {Creator = name, Name = team, Members = new List<string>() };
                if (teams.Any(x=>x.Name == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (teams.Any(x=>x.Creator==name))
                {
                    Console.WriteLine($"{name} cannot create another team!");
                }
                else
                {
                    t.Members.Add(name);
                    teams.Add(t);
                    Console.WriteLine($"Team {team} has been created by {teams.First(x => x.Name == team).Creator}!");
                }
            }
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine== "end of assignment")
                {
                    break;
                }
                string[] input = inputLine.Split(new char[] { '-','>'},StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                string team = input[1];
                if (!teams.Any(x => x.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(name)) || teams.Any(x => x.Creator == name))
                {
                    Console.WriteLine($"Member {name} cannot join team {team}!");
                }
                else
                {
                    teams.First(x=>x.Name==team).Members.Add(name);
                }
            }
            foreach (var team in teams.Where(x=>x.Members.Count>1).OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.Skip(1).OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(x=>x.Members.Count<=1).OrderBy(x=>x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    class Team
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }
    }
}
