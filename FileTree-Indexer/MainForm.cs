using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FileTree_Indexer.Properties;
using FileTree_Indexer.lib;

namespace FileTree_Indexer
{
    public partial class MainForm : Form
    {
        private static readonly string NewLine = Environment.NewLine;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSubmitClick(object sender, EventArgs e)
        {
            try
            {
                var delimiter = delimiterSelector.SelectedItem;
                var folder = folderSelectorTextbox.Text;
                var fileList = Utils.DirSearch(folder);
                var saveFile = saveFileTextbox.Text;
                var writer = new StreamWriter(saveFile);
                foreach (var file in fileList)
                {
                    writer.Write(Utils.IndexFilePath(file, folder, delimiter.ToString()));
                }
                writer.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private static string PromptBaseFolder()
        {
            var folderDialog = new FolderBrowserDialog();
            folderDialog.ShowDialog();
            return folderDialog.SelectedPath;
        }

        private static string PromptSaveFile()
        {
            var saveFileDialog = new SaveFileDialog { Title = Resources.SaveFileDialogTitle, AddExtension = true, DefaultExt = "txt", Filter = Resources.PromptSaveFileDialogFilterText }; 
            saveFileDialog.ShowDialog();
            return saveFileDialog.FileName;
        }

        private void FolderSelectorBrowseButtonClick(object sender, EventArgs e)
        {
            var baseFolder = PromptBaseFolder();
            folderSelectorTextbox.Text = baseFolder.Equals("") ? folderSelectorTextbox.Text : baseFolder;
        }

        private void SaveFileBrowseButtonClick(object sender, EventArgs e)
        {
            var saveFile = PromptSaveFile();
            saveFileTextbox.Text = saveFile.Equals("") ? saveFileTextbox.Text : saveFile;
        }
    }
}