using System;
using System.IO;
using Newtonsoft.Json;

namespace Diceware.Behaviors
{
  public class DicewareSettingsReader
  {
    private static readonly string DicewareFolderLocation =
      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "Diceware");

    private static readonly string SettingsLocation = Path.Combine(DicewareFolderLocation, "settings.json");

    private DicewareSettings GetDefault()
    {
      return new DicewareSettings
      {
        Delimiter = " ",
        MinimumPasswordLength = 40,
        DictionaryLocation = Path.Combine(DicewareFolderLocation, "diceware8k.txt"),
      };
    }

    public DicewareSettings GetSettings()
    {
      Directory.CreateDirectory(DicewareFolderLocation);

      if (File.Exists(SettingsLocation))
      {
        var text = File.ReadAllText(SettingsLocation);

        return JsonConvert.DeserializeObject<DicewareSettings>(text);
      }
      var def = this.GetDefault();

      this.SaveSettings(def);

      return def;
    }

    public void SaveSettings(DicewareSettings settings)
    {
      File.WriteAllText(SettingsLocation, JsonConvert.SerializeObject(settings));
    }
  }
}