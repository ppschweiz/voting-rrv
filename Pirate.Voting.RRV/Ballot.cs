using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Pirate.Voting.RRV
{
  public class Ballot
  {
    public const string BallotTag = "Ballot";
    public const string VoteTag = "Vote";
    public const string IdAttribute = "Id";
    public const string ValueAttribute = "Value";

    public double Weight { get; set; }

    public double Success { get; set; }

    public Dictionary<Candidate, int> Votes { get; private set; }

    public Ballot()
    {
      Weight = 1d;
      Success = 0d;
      Votes = new Dictionary<Candidate, int>();
    }

    public XElement ToXml()
    {
      var ballotElement = new XElement(BallotTag);

      foreach (var vote in Votes)
      {
        var voteElement = new XElement(VoteTag);
        voteElement.Add(new XAttribute(IdAttribute, vote.Key.Id));
        voteElement.Add(new XAttribute(ValueAttribute, vote.Value));
        ballotElement.Add(voteElement);
      }

      return ballotElement;
    }

    public static Ballot FromXml(XElement ballotElement, IEnumerable<Candidate> candidates)
    {
      var ballot = new Ballot();

      foreach (var voteElement in ballotElement.Elements(VoteTag))
      {
        var id = Convert.ToInt32(voteElement.Attribute(IdAttribute).Value);
        var candidate = candidates.Where(c => c.Id == id).Single();
        var value = Convert.ToInt32(voteElement.Attribute(ValueAttribute).Value);
        ballot.Votes.Add(candidate, value);
      }

      return ballot;
    }
  }
}
