namespace Diceware.UI
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ()
    {
      this.delimiterLabel = new System.Windows.Forms.Label();
      this.delimiterTextBox = new System.Windows.Forms.TextBox();
      this.minimumSizeLabel = new System.Windows.Forms.Label();
      this.minimumSizeTextbox = new System.Windows.Forms.TextBox();
      this.dictionaryLocationLabel = new System.Windows.Forms.Label();
      this.dictionaryLocationTextBox = new System.Windows.Forms.TextBox();
      this.resultsLabel = new System.Windows.Forms.Label();
      this.getPasswordButton = new System.Windows.Forms.Button();
      this.copyToClipboardButton = new System.Windows.Forms.Button();
      this.saveSettingsButton = new System.Windows.Forms.Button();
      this.findFolderButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // delimiterLabel
      // 
      this.delimiterLabel.AutoSize = true;
      this.delimiterLabel.Location = new System.Drawing.Point(12, 13);
      this.delimiterLabel.Name = "delimiterLabel";
      this.delimiterLabel.Size = new System.Drawing.Size(71, 20);
      this.delimiterLabel.TabIndex = 0;
      this.delimiterLabel.Text = "Delimiter";
      // 
      // delimiterTextBox
      // 
      this.delimiterTextBox.Location = new System.Drawing.Point(157, 12);
      this.delimiterTextBox.Name = "delimiterTextBox";
      this.delimiterTextBox.Size = new System.Drawing.Size(100, 26);
      this.delimiterTextBox.TabIndex = 1;
      // 
      // minimumSizeLabel
      // 
      this.minimumSizeLabel.AutoSize = true;
      this.minimumSizeLabel.Location = new System.Drawing.Point(12, 52);
      this.minimumSizeLabel.Name = "minimumSizeLabel";
      this.minimumSizeLabel.Size = new System.Drawing.Size(120, 20);
      this.minimumSizeLabel.TabIndex = 2;
      this.minimumSizeLabel.Text = "Minimum length";
      // 
      // minimumSizeTextbox
      // 
      this.minimumSizeTextbox.Location = new System.Drawing.Point(157, 49);
      this.minimumSizeTextbox.Name = "minimumSizeTextbox";
      this.minimumSizeTextbox.Size = new System.Drawing.Size(100, 26);
      this.minimumSizeTextbox.TabIndex = 3;
      // 
      // dictionaryLocationLabel
      // 
      this.dictionaryLocationLabel.AutoSize = true;
      this.dictionaryLocationLabel.Location = new System.Drawing.Point(12, 83);
      this.dictionaryLocationLabel.Name = "dictionaryLocationLabel";
      this.dictionaryLocationLabel.Size = new System.Drawing.Size(138, 20);
      this.dictionaryLocationLabel.TabIndex = 4;
      this.dictionaryLocationLabel.Text = "Dictionary location";
      // 
      // dictionaryLocationTextBox
      // 
      this.dictionaryLocationTextBox.Location = new System.Drawing.Point(157, 85);
      this.dictionaryLocationTextBox.Name = "dictionaryLocationTextBox";
      this.dictionaryLocationTextBox.Size = new System.Drawing.Size(1331, 26);
      this.dictionaryLocationTextBox.TabIndex = 5;
      // 
      // resultsLabel
      // 
      this.resultsLabel.AutoSize = true;
      this.resultsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultsLabel.Location = new System.Drawing.Point(16, 157);
      this.resultsLabel.Name = "resultsLabel";
      this.resultsLabel.Size = new System.Drawing.Size(0, 57);
      this.resultsLabel.TabIndex = 6;
      this.resultsLabel.UseCompatibleTextRendering = true;
      // 
      // getPasswordButton
      // 
      this.getPasswordButton.Location = new System.Drawing.Point(1286, 498);
      this.getPasswordButton.Name = "getPasswordButton";
      this.getPasswordButton.Size = new System.Drawing.Size(201, 39);
      this.getPasswordButton.TabIndex = 7;
      this.getPasswordButton.Text = "Get password!";
      this.getPasswordButton.UseVisualStyleBackColor = true;
      this.getPasswordButton.Click += new System.EventHandler(this.getPasswordButton_Click);
      // 
      // copyToClipboardButton
      // 
      this.copyToClipboardButton.Location = new System.Drawing.Point(1088, 498);
      this.copyToClipboardButton.Name = "copyToClipboardButton";
      this.copyToClipboardButton.Size = new System.Drawing.Size(175, 39);
      this.copyToClipboardButton.TabIndex = 8;
      this.copyToClipboardButton.Text = "Copy to clipboard";
      this.copyToClipboardButton.UseVisualStyleBackColor = true;
      this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
      // 
      // saveSettingsButton
      // 
      this.saveSettingsButton.Location = new System.Drawing.Point(1234, 27);
      this.saveSettingsButton.Name = "saveSettingsButton";
      this.saveSettingsButton.Size = new System.Drawing.Size(253, 45);
      this.saveSettingsButton.TabIndex = 9;
      this.saveSettingsButton.Text = "Save these settings as default";
      this.saveSettingsButton.UseVisualStyleBackColor = true;
      this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
      // 
      // findFolderButton
      // 
      this.findFolderButton.Location = new System.Drawing.Point(1495, 83);
      this.findFolderButton.Name = "findFolderButton";
      this.findFolderButton.Size = new System.Drawing.Size(33, 34);
      this.findFolderButton.TabIndex = 10;
      this.findFolderButton.Text = "...";
      this.findFolderButton.UseVisualStyleBackColor = true;
      this.findFolderButton.Click += new System.EventHandler(this.findFolderButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1540, 565);
      this.Controls.Add(this.findFolderButton);
      this.Controls.Add(this.saveSettingsButton);
      this.Controls.Add(this.copyToClipboardButton);
      this.Controls.Add(this.getPasswordButton);
      this.Controls.Add(this.resultsLabel);
      this.Controls.Add(this.dictionaryLocationTextBox);
      this.Controls.Add(this.dictionaryLocationLabel);
      this.Controls.Add(this.minimumSizeTextbox);
      this.Controls.Add(this.minimumSizeLabel);
      this.Controls.Add(this.delimiterTextBox);
      this.Controls.Add(this.delimiterLabel);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label delimiterLabel;
    private System.Windows.Forms.TextBox delimiterTextBox;
    private System.Windows.Forms.Label minimumSizeLabel;
    private System.Windows.Forms.TextBox minimumSizeTextbox;
    private System.Windows.Forms.Label dictionaryLocationLabel;
    private System.Windows.Forms.TextBox dictionaryLocationTextBox;
    private System.Windows.Forms.Label resultsLabel;
    private System.Windows.Forms.Button getPasswordButton;
    private System.Windows.Forms.Button copyToClipboardButton;
    private System.Windows.Forms.Button saveSettingsButton;
    private System.Windows.Forms.Button findFolderButton;
  }
}

