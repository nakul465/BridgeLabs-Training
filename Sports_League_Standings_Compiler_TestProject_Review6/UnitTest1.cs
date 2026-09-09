using System.Diagnostics;
using Sports_League_Standings_Compiler_Review_6;
namespace Sports_League_Standings_Compiler_TestProject_Review6;
[TestFixture]
public class Tests
{
    private LeagueProcessor processor;
    [SetUp]
    public void Setup()
    {
        processor = new LeagueProcessor(
            new List<string>
            {
                    "Tigers",
                    "Lions",
                    "Eagles",
                    "Wolves"
            });
    }

    [Test]
    public void ValidMatch_UpdatesStandings()
    {
        processor.ProcessMatch(new Match
        {
            MatchId = "M1",
            HomeTeam = "Tigers",
            AwayTeam = "Lions",
            HomeScore = 2,
            AwayScore = 1
        });

        Team tiger = processor.GetStandings().First(t => t.Name == "Tigers");

        Assert.That(tiger.Played, Is.EqualTo(1));
        Assert.That(tiger.GoalsFor, Is.EqualTo(2));
        Assert.That(tiger.GoalsAgainst, Is.EqualTo(1));
    }

    [Test]
    public void HomeTeamWin_GivesThreePoints()
    {
        processor.ProcessMatch(new Match
        {
            MatchId = "M1",
            HomeTeam = "Tigers",
            AwayTeam = "Lions",
            HomeScore = 2,
            AwayScore = 1
        });
        Team tiger = processor.GetStandings().First(t => t.Name == "Tigers");
        Assert.That(tiger.Won, Is.EqualTo(1));
        Assert.That(tiger.Lost, Is.EqualTo(0));
        Assert.That(tiger.Points, Is.EqualTo(3));
    }

    [Test]
    public void AwayTeamWin_GivesThreePoints()
    {
        processor.ProcessMatch(new Match
        {
            MatchId = "M1",
            HomeTeam = "Tigers",
            AwayTeam = "Lions",
            HomeScore = 1,
            AwayScore = 2
        });

        Team lions = processor.GetStandings().First(t => t.Name == "Lions");
        Assert.That(lions.Won, Is.EqualTo(1));
        Assert.That(lions.Points, Is.EqualTo(3));
    }

    [Test]
    public void Draw_GivesOnePointToBothTeams()
    {
        processor.ProcessMatch(new Match
        {
            MatchId = "M1",
            HomeTeam = "Tigers",
            AwayTeam = "Lions",
            HomeScore = 1,
            AwayScore = 1
        });

        Team tiger = processor.GetStandings().First(t => t.Name == "Tigers");
        Team lions = processor.GetStandings().First(t => t.Name == "Lions");
        Assert.That(tiger.Draw, Is.EqualTo(1));
        Assert.That(lions.Draw, Is.EqualTo(1));
        Assert.That(tiger.Points, Is.EqualTo(1));
        Assert.That(lions.Points, Is.EqualTo(1));
    }

    [Test]
    public void UnregisteredHomeTeam_ThrowsException()
    {
        Assert.Throws<UnregisteredTeamException>(() =>
            processor.ProcessMatch(new Match
            {
                MatchId = "M1",
                HomeTeam = "India",
                AwayTeam = "Lions",
                HomeScore = 1,
                AwayScore = 0
            }));
    }

    [Test]
    public void UnregisteredAwayTeam_ThrowsException()
    {
        Assert.Throws<UnregisteredTeamException>(() =>
            processor.ProcessMatch(new Match
            {
                MatchId = "M1",
                HomeTeam = "Tigers",
                AwayTeam = "India",
                HomeScore = 1,
                AwayScore = 0
            }));
    }

    [Test]
    public void NegativeScore_ThrowsException()
    {
        Assert.Throws<InvalidScoreException>(() =>
            processor.ProcessMatch(new Match
            {
                MatchId = "M1",
                HomeTeam = "Tigers",
                AwayTeam = "Lions",
                HomeScore = -1,
                AwayScore = 0
            }));
    }

    [Test]
    public void SelfMatch_ThrowsException()
    {
        Assert.Throws<SelfMatchException>(() =>
            processor.ProcessMatch(new Match
            {
                MatchId = "M1",
                HomeTeam = "Tigers",
                AwayTeam = "Tigers",
                HomeScore = 1,
                AwayScore = 0
            }));
    }

}
