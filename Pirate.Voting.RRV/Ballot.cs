using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pirate.Voting.RRV
{
  public class Ballot
  {
    public Guid Id { get; private set; }

    public double Weight { get; set; }

    public double Success { get; set; }

    public Dictionary<Candidate, int> Votes { get; private set; }

    public Ballot()
    {
      Id = Guid.NewGuid();
      Weight = 1d;
      Success = 0d;
      Votes = new Dictionary<Candidate, int>();
    }
  }
}
