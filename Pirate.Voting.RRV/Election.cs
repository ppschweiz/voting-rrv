using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Pirate.Voting.RRV
{
  public class Election
  {
    public const string ElectionTag = "Election";
    public const string TitleTag = "Title";
    public const string SeatsTag = "Seats";
    public const string MajorityTag = "Majority";

    public string Title { get; set; }

    public List<Candidate> Candidates { get; private set; }

    public List<Ballot> Ballots { get; private set; }

    public int Seats { get; set; }

    public Majority Majority { get; set; }

    public Election(string title)
    {
      Title = title;
      Candidates = new List<Candidate>();
      Ballots = new List<Ballot>();
    }

    public XDocument ToXml()
    {
      var electionElement = new XElement(ElectionTag);
      electionElement.Add(new XElement(TitleTag, Title));
      electionElement.Add(new XElement(SeatsTag, Seats));
      electionElement.Add(new XElement(MajorityTag, Majority.ToString()));

      foreach (var candidate in Candidates)
      {
        electionElement.Add(candidate.ToXml());
      }

      foreach (var ballot in Ballots)
      {
        electionElement.Add(ballot.ToXml());
      }

      var document = new XDocument();
      document.Add(electionElement);
      return document;
    }

    public void Save(string filename)
    {
      var document = ToXml();
      document.Save(filename);
    }

    public static Election Load(string filename)
    {
      var document = XDocument.Load(filename);
      return FromXml(document);
    }

    public static Election FromXml(XDocument document)
    {
      var electionElement = document.Root;
      var title = electionElement.Element(TitleTag).Value;
      var election = new Election(title);
      election.Seats = Convert.ToInt32(electionElement.Element(SeatsTag).Value);
      election.Majority = (Majority)Enum.Parse(typeof(Majority), electionElement.Element(MajorityTag).Value);

      foreach (var candidateElement in electionElement.Elements(Candidate.CandidateTag))
      {
        election.Candidates.Add(Candidate.FromXml(candidateElement));
      }

      foreach (var ballotElement in electionElement.Elements(Ballot.BallotTag))
      {
        election.Ballots.Add(Ballot.FromXml(ballotElement, election.Candidates));
      }

      return election;
    }
  }
}
