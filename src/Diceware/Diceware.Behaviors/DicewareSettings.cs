using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceware.Behaviors
{
  public class DicewareSettings
  {
    public string DictionaryLocation { get; set; }

    public int MinimumPasswordLength { get; set; }

    public string Delimiter { get; set; }
  }
}