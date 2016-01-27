using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Diceware.Behaviors
{
  public static class InputReader
  {
    public static IEnumerable<string> ReadWordsFromText(string fileLocation)
    {
      if (fileLocation == null)
      {
        throw new ArgumentNullException(nameof(fileLocation));
      }
      var text = File.ReadAllText(fileLocation);

      return text.Split('\n').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s));
    }
  }
}