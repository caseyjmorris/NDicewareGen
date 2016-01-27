using System.Text;

namespace Diceware.Behaviors
{
  public class PasswordProvider
  {
    private readonly WordProvider wordProvider;

    public PasswordProvider(WordProvider wordProvider)
    {
      this.wordProvider = wordProvider;
    }

    public string GetPassword(int minimumLength, string delimiter)
    {
      var sb = new StringBuilder();

      while (sb.Length < minimumLength)
      {
        if (sb.Length > 0)
        {
          sb.Append(delimiter);
        }

        sb.Append(this.wordProvider.GetWord());
      }

      return sb.ToString();
    }
  }
}