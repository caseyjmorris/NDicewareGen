using System;
using System.IO;
using System.Windows.Forms;
using Diceware.Behaviors;

namespace Diceware.UI
{
  public partial class Form1 : Form
  {
    private readonly DicewareSettingsReader settingsReader = new DicewareSettingsReader();

    private WordProvider wordProvider;

    private bool VerifySettings()
    {
      var err = false;
      int res;
      if (!int.TryParse(this.minimumSizeTextbox.Text, out res))
      {
        MessageBox.Show("Minimum length must be a number", "Invalid setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
        err = true;
      }
      if (!File.Exists(this.dictionaryLocationTextBox.Text))
      {
        MessageBox.Show($"No file could be found at {this.dictionaryLocationTextBox.Text}", "Invalid setting",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        err = true;
      }

      return !err;
    }

    public Form1()
    {
      InitializeComponent();

      var settings = this.settingsReader.GetSettings();

      this.delimiterTextBox.Text = settings.Delimiter;

      this.dictionaryLocationTextBox.Text = settings.DictionaryLocation;

      this.minimumSizeTextbox.Text = settings.MinimumPasswordLength.ToString("D");
    }

    private void saveSettingsButton_Click(object sender, EventArgs e)
    {
      if (!this.VerifySettings())
      {
        return;
      }
      var settings = new DicewareSettings
      {
        Delimiter = this.delimiterTextBox.Text,
        DictionaryLocation = this.dictionaryLocationTextBox.Text,
        MinimumPasswordLength = int.Parse(this.minimumSizeTextbox.Text),
      };

      this.settingsReader.SaveSettings(settings);
    }

    private void getPasswordButton_Click(object sender, EventArgs e)
    {
      if (!this.VerifySettings())
      {
        return;
      }

      if (this.wordProvider == null)
      {
        var strings = InputReader.ReadWordsFromText(this.dictionaryLocationTextBox.Text);

        this.wordProvider = new WordProvider(strings);
      }

      var passwordProvider = new PasswordProvider(this.wordProvider);

      this.resultsLabel.Text = passwordProvider.GetPassword(int.Parse(this.minimumSizeTextbox.Text),
        this.delimiterTextBox.Text);
    }

    private void copyToClipboardButton_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(this.resultsLabel.Text);
    }

    private void findFolderButton_Click(object sender, EventArgs e)
    {
      var path = Path.GetDirectoryName(this.dictionaryLocationTextBox.Text);

      var fd = new OpenFileDialog
      {
        CheckFileExists = true,
        Multiselect = false,
        Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
        InitialDirectory = path,
      };

      var result = fd.ShowDialog();

      if (result == DialogResult.OK)
      {
        this.dictionaryLocationTextBox.Text = fd.FileName;
      }
    }
  }
}