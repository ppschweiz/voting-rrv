using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pirate.Voting.RRV
{
  public class Candidate
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Candidate(string name)
    {
      Id = Guid.NewGuid();
      Name = name;
    }
  }
}
