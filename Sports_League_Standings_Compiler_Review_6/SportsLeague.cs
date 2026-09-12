using System;
using System.Text;
using System.Text.Json;
using CsvHelper;
namespace Sports_League_Standings_Compiler_Review_6
{
    public class Match
    {
        public string MatchId { get; set; } = "";
        public string HomeTeam { get; set; } = "";
        public string AwayTeam { get; set; } = "";
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
    }

    public class MatchException : Exception
    {
        public MatchException(string msg) : base(msg)
        {
        }
    }

    public class UnregisteredTeamException : MatchException
    {
        public UnregisteredTeamException(string msg) : base(msg)
        {
        }
    }

    public class InvalidScoreException : MatchException
    {
        public InvalidScoreException(string msg) : base(msg)
        {
        }
    }

    public class DuplicateMatchException : MatchException
    {
        public DuplicateMatchException(string msg) : base(msg)
        {
        }
    }

    public class SelfMatchException : MatchException
    {
        public SelfMatchException(string msg) : base(msg)
        {
        }
    }

    public class TeamsData
    {
        public List<string>? Teams { get; set; }
    }

    public class Team
    {
        public string Name { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Draw { get; set; }
        public int Lost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference => GoalsFor - GoalsAgainst;
        public int Points { get; set; }

        public Team(string name)
        {
            Name = name;
        }
    }

    public class LeagueProcessor
    {
        private Dictionary<string, Team> standings;
        private HashSet<string> matchIds;

        public LeagueProcessor(List<string> registeredTeams)
        {
            standings = new Dictionary<string, Team>();
            matchIds = new HashSet<string>();

            foreach (string team in registeredTeams)
            {
                standings[team] = new Team(team);
            }
        }

        public void ProcessMatch(Match match)
        {
            ValidateMatch(match);
            Team home = standings[match.HomeTeam];
            Team away = standings[match.AwayTeam];
            home.Played++;
            away.Played++;
            home.GoalsFor += match.HomeScore;
            home.GoalsAgainst += match.AwayScore;
            away.GoalsFor += match.AwayScore;
            away.GoalsAgainst += match.HomeScore;
            if (match.HomeScore > match.AwayScore)
            {
                home.Won++;
                home.Points += 3;
                away.Lost++;
            }
            else if (match.HomeScore < match.AwayScore)
            {
                away.Won++;
                away.Points += 3;
                home.Lost++;
            }
            else
            {
                home.Draw++;
                away.Draw++;
                home.Points++;
                away.Points++;
            }
            matchIds.Add(match.MatchId);
        }

        private void ValidateMatch(Match match)
        {
            if (!standings.ContainsKey(match.HomeTeam))
            {
                throw new UnregisteredTeamException($"Unregistered home team: {match.HomeTeam}");
            }
            if (!standings.ContainsKey(match.AwayTeam))
            {
                throw new UnregisteredTeamException($"Unregistered away team: {match.AwayTeam}");
            }
            if (match.HomeTeam == match.AwayTeam)
            {
                throw new SelfMatchException($"Self-match is not allowed: {match.HomeTeam}");
            }
            if (match.HomeScore < 0 || match.AwayScore < 0)
            {
                throw new InvalidScoreException($"Negative score in match {match.MatchId}");
            }
            if (matchIds.Contains(match.MatchId))
            {
                throw new DuplicateMatchException($"Duplicate MatchId: {match.MatchId}");
            }
        }

        public List<Team> GetStandings()
        {
            return standings.Values
                .OrderByDescending(t => t.Points)
                .ThenByDescending(t => t.GoalDifference)
                .ThenByDescending(t => t.GoalsFor)
                .ThenBy(t => t.Name)
                .ToList();
        }

        public void WriteStandingsJson(string path)
        {
            List<Team> result = GetStandings();
            var options = new JsonSerializerOptions{WriteIndented = true};
            string json = JsonSerializer.Serialize(result, options);
            using FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write);
            using StreamWriter writer = new StreamWriter(fs);
            writer.Write(json);
        }

        public byte[] CreateBinarySnapshot()
        {
            List<Team> result = GetStandings();
            using MemoryStream memoryStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(memoryStream,Encoding.UTF8,true);
            writer.Write(result.Count);
            foreach (Team team in result)
            {
                writer.Write(team.Name);
                writer.Write(team.Played);
                writer.Write(team.Won);
                writer.Write(team.Draw);
                writer.Write(team.Lost);
                writer.Write(team.GoalsFor);
                writer.Write(team.GoalsAgainst);
                writer.Write(team.GoalDifference);
                writer.Write(team.Points);
            }
            writer.Flush();
            return memoryStream.ToArray();
        }

        public static List<Team> DecodeBinarySnapshot(byte[] data)
        {
            List<Team> teams = new List<Team>();
            using MemoryStream memoryStream = new MemoryStream(data);
            using BinaryReader reader = new BinaryReader(memoryStream,Encoding.UTF8);
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                string name = reader.ReadString();
                Team team = new Team(name)
                {
                    Played = reader.ReadInt32(),
                    Won = reader.ReadInt32(),
                    Draw = reader.ReadInt32(),
                    Lost = reader.ReadInt32(),
                    GoalsFor = reader.ReadInt32(),
                    GoalsAgainst = reader.ReadInt32()
                };
                reader.ReadInt32();
                team.Points = reader.ReadInt32();
                teams.Add(team);
            }
            return teams;
        }

        public static List<string> ReadRegisteredTeams(string path)
        {
            using FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read);
            using StreamReader reader = new StreamReader(fs);
            string json = reader.ReadToEnd();
            TeamsData? data =JsonSerializer.Deserialize<TeamsData>(json,
                new JsonSerializerOptions
                {
                PropertyNameCaseInsensitive = true
                });

            if (data == null || data.Teams == null)return new List<string>();

            return data.Teams;
        }

        public static List<Match> ReadMatches(string path)
        {
            List<Match> matches = new List<Match>();
            using FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read);
            using StreamReader reader = new StreamReader(fs);
            string? header = reader.ReadLine();
            if (header == null)
                return matches;
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                string[] parts = line.Split(',');
                if (parts.Length != 5)
                    continue;

                Match match = new Match
                {
                    MatchId = parts[0].Trim(),
                    HomeTeam = parts[1].Trim(),
                    AwayTeam = parts[2].Trim(),
                    HomeScore = int.Parse(parts[3].Trim()),
                    AwayScore = int.Parse(parts[4].Trim())
                };
                matches.Add(match);
            }
            return matches;
        }

        public void ProcessMatches(string matchesPath, string auditPath)
        {
            List<Match> matches = ReadMatches(matchesPath);
            using FileStream fs = new FileStream(auditPath,FileMode.Create,FileAccess.Write);
            using BufferedStream bufferedStream = new BufferedStream(fs);
            using StreamWriter writer = new StreamWriter(bufferedStream);
            foreach (Match match in matches)
            {
                try
                {
                    ProcessMatch(match);
                    writer.WriteLine($"{match.MatchId}: VALID - " +$"{match.HomeTeam} {match.HomeScore} " +$"{match.AwayScore} {match.AwayTeam}");
                }
                catch (MatchException ex)
                {
                    writer.WriteLine($"{match.MatchId}: INVALID - {ex.Message}");
                }
            }
        }
    }
}
