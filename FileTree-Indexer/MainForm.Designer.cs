namespace FileTree_Indexer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.delimiterSelector = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.delimiterSelectorLabel = new System.Windows.Forms.Label();
            this.saveFileTextbox = new System.Windows.Forms.TextBox();
            this.saveFileLabel = new System.Windows.Forms.Label();
            this.folderSelectorLabel = new System.Windows.Forms.Label();
            this.folderSelectorTextbox = new System.Windows.Forms.TextBox();
            this.folderSelectorBrowseButton = new System.Windows.Forms.Button();
            this.saveFileBrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delimiterSelector
            // 
            this.delimiterSelector.FormattingEnabled = true;
            this.delimiterSelector.Items.AddRange(new object[] {
            "|",
            ":",
            "*",
            "?",
            "<",
            ">",
            ",",
            "~",
            "{",
            "}"});
            this.delimiterSelector.Location = new System.Drawing.Point(144, 16);
            this.delimiterSelector.Name = "delimiterSelector";
            this.delimiterSelector.Size = new System.Drawing.Size(64, 21);
            this.delimiterSelector.TabIndex = 1;
            this.delimiterSelector.Text = "|";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(380, 150);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(112, 40);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmitClick);
            // 
            // delimiterSelectorLabel
            // 
            this.delimiterSelectorLabel.AutoSize = true;
            this.delimiterSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delimiterSelectorLabel.Location = new System.Drawing.Point(67, 14);
            this.delimiterSelectorLabel.Name = "delimiterSelectorLabel";
            this.delimiterSelectorLabel.Size = new System.Drawing.Size(71, 20);
            this.delimiterSelectorLabel.TabIndex = 3;
            this.delimiterSelectorLabel.Text = "Delimiter";
            // 
            // saveFileTextbox
            // 
            this.saveFileTextbox.Location = new System.Drawing.Point(144, 99);
            this.saveFileTextbox.Name = "saveFileTextbox";
            this.saveFileTextbox.Size = new System.Drawing.Size(322, 20);
            this.saveFileTextbox.TabIndex = 5;
            this.saveFileTextbox.Text = "C:\\Users\\nickiterry\\filetree.txt";
            // 
            // saveFileLabel
            // 
            this.saveFileLabel.AutoSize = true;
            this.saveFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileLabel.Location = new System.Drawing.Point(49, 99);
            this.saveFileLabel.Name = "saveFileLabel";
            this.saveFileLabel.Size = new System.Drawing.Size(87, 20);
            this.saveFileLabel.TabIndex = 7;
            this.saveFileLabel.Text = "Output File";
            // 
            // folderSelectorLabel
            // 
            this.folderSelectorLabel.AutoSize = true;
            this.folderSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderSelectorLabel.Location = new System.Drawing.Point(27, 57);
            this.folderSelectorLabel.Name = "folderSelectorLabel";
            this.folderSelectorLabel.Size = new System.Drawing.Size(109, 20);
            this.folderSelectorLabel.TabIndex = 6;
            this.folderSelectorLabel.Text = "Search Folder";
            // 
            // folderSelectorTextbox
            // 
            this.folderSelectorTextbox.Location = new System.Drawing.Point(144, 57);
            this.folderSelectorTextbox.Name = "folderSelectorTextbox";
            this.folderSelectorTextbox.Size = new System.Drawing.Size(322, 20);
            this.folderSelectorTextbox.TabIndex = 4;
            this.folderSelectorTextbox.Text = "C:\\Users\\nickiterry";
            // 
            // folderSelectorBrowseButton
            // 
            this.folderSelectorBrowseButton.Location = new System.Drawing.Point(467, 56);
            this.folderSelectorBrowseButton.Name = "folderSelectorBrowseButton";
            this.folderSelectorBrowseButton.Size = new System.Drawing.Size(25, 20);
            this.folderSelectorBrowseButton.TabIndex = 8;
            this.folderSelectorBrowseButton.Text = "...";
            this.folderSelectorBrowseButton.UseVisualStyleBackColor = true;
            this.folderSelectorBrowseButton.Click += new System.EventHandler(this.FolderSelectorBrowseButtonClick);
            // 
            // saveFileBrowseButton
            // 
            this.saveFileBrowseButton.Location = new System.Drawing.Point(467, 98);
            this.saveFileBrowseButton.Name = "saveFileBrowseButton";
            this.saveFileBrowseButton.Size = new System.Drawing.Size(25, 20);
            this.saveFileBrowseButton.TabIndex = 9;
            this.saveFileBrowseButton.Text = "...";
            this.saveFileBrowseButton.UseVisualStyleBackColor = true;
            this.saveFileBrowseButton.Click += new System.EventHandler(this.SaveFileBrowseButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 202);
            this.Controls.Add(this.saveFileBrowseButton);
            this.Controls.Add(this.folderSelectorBrowseButton);
            this.Controls.Add(this.saveFileLabel);
            this.Controls.Add(this.folderSelectorLabel);
            this.Controls.Add(this.saveFileTextbox);
            this.Controls.Add(this.folderSelectorTextbox);
            this.Controls.Add(this.delimiterSelectorLabel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.delimiterSelector);
            this.Name = "MainForm";
            this.Text = "FileTree Indexer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delimiterSelector;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label delimiterSelectorLabel;
        private System.Windows.Forms.TextBox saveFileTextbox;
        private System.Windows.Forms.Label saveFileLabel;
        private System.Windows.Forms.Label folderSelectorLabel;
        private System.Windows.Forms.TextBox folderSelectorTextbox;
        private System.Windows.Forms.Button folderSelectorBrowseButton;
        private System.Windows.Forms.Button saveFileBrowseButton;
    }
}

