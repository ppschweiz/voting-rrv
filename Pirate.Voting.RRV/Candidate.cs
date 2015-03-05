using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Pirate.Voting.RRV
{
  public class Candidate
  {
    public const string CandidateTag = "Candidate";
    public const string IdAttribute = "Id";
    public const string NameTag = "Name";

    public int Id { get; set; }

    public string Name { get; set; }

    public Candidate(int id, string name)
    {
      Id = id;
      Name = name;
    }

    public XElement ToXml()
    {
      var candidateElement = new XElement(CandidateTag);
      candidateElement.Add(new XAttribute(IdAttribute, Id));
      candidateElement.Add(new XElement(NameTag, Name));
      return candidateElement;
    }

    public static Candidate FromXml(XElement candidateElement)
    {
      var id = Convert.ToInt32(candidateElement.Attribute(IdAttribute).Value);
      var name = candidateElement.Element(NameTag).Value;
      return new Candidate(id, name);
    }
  }
}
