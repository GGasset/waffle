using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Spotifly
{
    public partial class Form1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "This will not work if I listen")]
        private void MediaListView_DrawMedia()
        {
            string[] supportedExtensions = ".WEBM .MPG .MP2 .MPEG .MPE .MPV .OGG .MP4 .M4P .M4V .AVI .WMV .WAV".ToLower(System.Globalization.CultureInfo.InvariantCulture).Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] files = Directory.GetFiles(folderPath), folders = Directory.GetDirectories(folderPath), filteredFiles;
            bool[] compatibleFilesIndex = new bool[files.Length];
            int compatibleFIles = 0;
            bool modifyNeed = false;
            folderLabel.Text = $"Looking to media files in {folderPath}";
            for (int i = 0; i < files.Length; i++)
            {
                bool compatible = false;
                for (int ii = 0; ii < supportedExtensions.Length && !compatible; ii++)
                    if (files[i].Contains(supportedExtensions[ii]))
                    {
                        compatible = true;
                        compatibleFilesIndex[i] = true;
                        compatibleFIles++;
                    }
            }
            filteredFiles = new string[compatibleFIles];
            for (int i = 0; i < compatibleFIles; i++)
                if (compatibleFilesIndex[i])
                    filteredFiles[i] = files[i];

            modifyNeed = filteredFiles.Length != filteredFilesMemory.Length;
            modifyNeed = folders.Length != foldersMemory.Length || modifyNeed;

            if (!modifyNeed)
                foreach (string url in filteredFiles)//detect if any element of filtered files doesnt exist in memory (any file was added)
                {
                    int numberOfConcurrences = 0;
                    foreach (string urlMemoryUrl in filteredFilesMemory)
                        numberOfConcurrences += 1 * Convert.ToInt32(url == urlMemoryUrl);
                    modifyNeed = numberOfConcurrences == 0;
                    if (modifyNeed)
                        break;
                }
            if (!modifyNeed)
                foreach (string urlMemoryUrl in filteredFilesMemory)//detect if any element of memory doesnt exist in filtered files (any file was deleted)
                {
                    int numberOfConcurrences = 0;
                    foreach (string url in filteredFiles)
                        numberOfConcurrences += 1 * Convert.ToInt32(url == urlMemoryUrl);
                    modifyNeed = numberOfConcurrences == 0;
                    if (modifyNeed)
                        break;
                }

            if (!modifyNeed)
                for (int i = 0; i < folders.Length; i++)
                    if (folders[i] != foldersMemory[i])
                    {
                        modifyNeed = true;
                        break;
                    }

            if (!shuffle && !modifyNeed)//Unshuffle Playlist
            {
                urlPlaylist = filteredFiles;
                CheckPlaylistIndex();
            }

            if (modifyNeed)
            {
                urlPlaylist = filteredFiles;
                if (shuffle)
                    ShufflePlaylist();
                ImageList icons = new ImageList();
                MediaListView.Clear();
                for (int i = 0; i < folders.Length; i++)
                {
                    icons.Images.Add(Properties.Resources.FolderImage);
                    MediaListView.Items.Add(folders[i].Remove(0, folders[i].LastIndexOf('\\') + 1), i);
                }
                for (int i = 0; i < filteredFiles.Length; i++)
                {
                    icons.Images.Add(Icon.ExtractAssociatedIcon(filteredFiles[i]));
                    MediaListView.Items.Add(filteredFiles[i].Remove(filteredFiles[i].LastIndexOf(".", StringComparison.InvariantCulture)).Remove(0, filteredFiles[i].LastIndexOf('\\') + 1), i + folders.Length);
                }

                MediaListView.SmallImageList = icons;
                filteredFilesMemory = filteredFiles;
                foldersMemory = folders;
            }
        }

        private void MediaListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
                if (Directory.Exists($@"{folderPath}\{e.Item.Text}"))
                {
                    folderPath = $@"{folderPath}\{e.Item.Text}";
                    BackBttn.Visible = folderPath != initialFolderPath;
                    MediaListView_DrawMedia();
                }
                else
                {
                    if (shuffle)
                    {
                        shuffle = false;
                        MediaListView_DrawMedia();
                        shuffle = true;
                        PlayFile(e.ItemIndex - playlistIndex - 1, true);
                        ShufflePlaylist();
                    }
                    else
                        PlayFile(e.ItemIndex - playlistIndex - 1, true);

                    if (ResizeForMediaCheckBox.Checked)
                    {
                        SetFormSizeForCurrentMedia();
                        FormBorderStyle = FormBorderStyle.FixedSingle;
                    }
                    SetActivePanel(0);
                    GetColorsForTheme(currentTheme, out _, out _, out _, out Color buttonColor, out _);
                    PlayBttn.Image = SubstituteNotBlankFromImage(Properties.Resources.Pause, buttonColor);
                }
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            folderPath = folderPath.Remove(folderPath.LastIndexOf(@"\", StringComparison.InvariantCulture));
            BackBttn.Visible = folderPath != initialFolderPath;
            MediaListView_DrawMedia();
        }

        private void DownloadedMediaPanel_VisibleChanged(object sender, EventArgs e)
        {
            MediaListView.Size = new Size(DownloadedMediaPanel.Width, DownloadedMediaPanel.Height - 25);
        }

        private void DownloadedMediaPanel_Resize(object sender, EventArgs e)
        {
            MediaListView.Size = new Size(DownloadedMediaPanel.Width, DownloadedMediaPanel.Height - 25);
        }
    }
}