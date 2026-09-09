// See https://aka.ms/new-console-template for more information
using Sports_League_Standings_Compiler_Review_6;

string basePath = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;


string pathToCSV = Path.Combine(basePath,"matches.csv");
using (FileStream fsForCSV =new FileStream(pathToCSV, FileMode.Create, FileAccess.Write))
using (StreamWriter writerForCSV =new StreamWriter(fsForCSV))
{
    string csvFile =
       "MatchId,HomeTeam,AwayTeam,HomeScore,AwayScore\n" +
       "M1,Tigers,Lions,2,1\n" +
       "M2,Eagles,Tigers,0,0\n" +
       "M3,Lions,Wolves9,3,1\n" +
       "M4,Eagles,Lions,-1,2\n" +
       "M5,Wolves,Tigers,1,1";
    writerForCSV.Write(csvFile);
}


string pathToJSON = Path.Combine(basePath,"teams.json");
using (FileStream fsForJSON =new FileStream(pathToJSON, FileMode.Create, FileAccess.Write))
using (StreamWriter writerForJSON =new StreamWriter(fsForJSON))
{
    string jsonFile =
        "{\n" +
        "  \"teams\": [\"Tigers\", \"Lions\", \"Eagles\", \"Wolves\"]\n" +
        "}";
    writerForJSON.Write(jsonFile);
}


List<string> registeredTeams = LeagueProcessor.ReadRegisteredTeams(pathToJSON);
LeagueProcessor processor = new LeagueProcessor(registeredTeams);

string auditPath = Path.Combine(basePath, "match_audit.log");
processor.ProcessMatches(pathToCSV, auditPath);

List<Team> standings = processor.GetStandings();

string standingsPath = Path.Combine(basePath, "standings.json");

processor.WriteStandingsJson(standingsPath);

byte[] snapshot = processor.CreateBinarySnapshot();

List<Team> decodedStandings =LeagueProcessor.DecodeBinarySnapshot(snapshot);

Console.WriteLine("STANDINGS");
Console.WriteLine();
int rank = 1;
foreach (Team team in decodedStandings)
{
    Console.WriteLine(
        $"{rank} {team.Name} " +
        $"{team.Played} " +
        $"{team.Won} " +
        $"{team.Draw} " +
        $"{team.Lost} " +
        $"{team.GoalsFor} " +
        $"{team.GoalsAgainst} " +
        $"{team.GoalDifference} " +
        $"{team.Points}");

    rank++;
}

Console.WriteLine();
Console.WriteLine($"Standings JSON: {standingsPath}");
Console.WriteLine($"Audit log: {auditPath}");
Console.WriteLine($"Binary snapshot size: {snapshot.Length} bytes");
