using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pirate.Voting.RRV
{
  public class Election
  {
    public Guid Id { get; private set; }

    public string Title { get; set; }

    public List<Candidate> Candidates { get; private set; }

    public List<Ballot> Ballots { get; private set; }

    public int Seats { get; set; }

    public Election(string title)
    {
      Id = Guid.NewGuid();
      Title = title;
      Candidates = new List<Candidate>();
      Ballots = new List<Ballot>();
    }
  }
}
