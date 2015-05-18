using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pirate.Voting.RRV
{
  public class StringTable
  {
    private readonly List<int> columns;
    private readonly List<List<string>> data;
    private bool hasHeader = true;

    public StringTable()
    {
      columns = new List<int>();
      data = new List<List<string>> { new List<string>() };
    }

    public void AddColumn(string header)
    {
      columns.Add(header.Length + 1);
      data[0].Add(header);
    }

    public void AddRow(params string[] text)
    {
      data.Add(new List<string>(text));

      for (int index = 0; index < text.Length; index++)
      {
        columns[index] = Math.Max(columns[index], text[index].Length + 1);
      }
    }

    public string Render()
    {
      var builder = new StringBuilder();

      for (int rowIndex = 0; rowIndex < data.Count; rowIndex++)
      {
        var row = data[rowIndex];

        for (int columnIndex = 0; columnIndex < row.Count; columnIndex++)
        {
          builder.Append(Fixed(row[columnIndex], columns[columnIndex]));
        }

        if (rowIndex == 0 && hasHeader)
        {
          builder.AppendLine();

          for (int columnIndex = 0; columnIndex < row.Count; columnIndex++)
          {
            builder.Append(Line(columns[columnIndex]));
          }
        }

        builder.AppendLine();
      }

      return builder.ToString();
    }

    private static string Line(int length)
    {
      string text = string.Empty;

      while (text.Length < length)
      {
        text += "-";
      }

      return text;
    }

    private static string Fixed(string input, int length)
    {
      string text = input.Length > length - 1 ? input.Substring(0, length - 1) : input;

      while (text.Length < length)
      {
        text += " ";
      }

      return text;
    }
  }
}
