using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Diceware.Behaviors
{
  public class WordProvider
  {
    private readonly RandomNumberGenerator rng = new RNGCryptoServiceProvider();

    private readonly IEnumerable<string> orderedWords;

    private Queue<string> scrambledWords;

    public WordProvider(IEnumerable<string> input)
    {
      if (input == null)
      {
        throw new ArgumentNullException(nameof(input));
      }
      this.orderedWords = input.ToList();

      if (!this.orderedWords.Any())
      {
        throw new ArgumentException("Word list cannot be empty", nameof(input));
      }
    }

    public string GetWord()
    {
      if (this.scrambledWords == null || this.scrambledWords.Count == 0)
      {
        this.Initialize();
      }

      return this.scrambledWords.Dequeue();
    }

    private void Initialize()
    {
      var scrambled = this.orderedWords.OrderBy(r => this.GetRandomNumber());
      this.scrambledWords = new Queue<string>(scrambled);
    }

    private int GetRandomNumber()
    {
      var buffer = new byte[4];

      this.rng.GetBytes(buffer);

      return BitConverter.ToInt32(buffer, 0);
    }
  }
}