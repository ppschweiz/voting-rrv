using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Pirate.Voting.RRV
{
  public class Log : IDisposable
  {
    private TextWriter _writer;
    private FileStream _file;

    public Log(string path)
    { 
      _file = File.OpenWrite(path);
      _writer = new StreamWriter(_file);
    }

    public void Write(string text, params object[] data)
    {
      _writer.WriteLine(text, data);
      _writer.Flush();
    }

    public void Dispose()
    {
      _writer.Close();
    }
  }
}
