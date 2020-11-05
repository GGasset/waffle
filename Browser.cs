using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Spotifly
{
    public partial class Form1
    {
        private readonly YoutubeClient client = new YoutubeClient();

        private void LinkTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Detects if enter is pressed
            if (Convert.ToInt32(e.KeyChar) == 13)
                LoadVideo();
        }

        private async void LoadVideo()
        {
            if (downloading)
            {
                MessageBox.Show((string)table["wait"], (string)table["er"]);
                return;
            }
            DwnldSttsLabel.Text = string.Empty;
            try
            {
                video = await client.Videos.GetAsync(LinkTextBox.Text).ConfigureAwait(true);
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show(ex.Message + " Please check your internet connection", (string)table["er"]);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + " Please enter a valid link or ID", (string)table["er"]);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (string)table["er"]);
                return;
            }
            currentLink = LinkTextBox.Text;

            #region setPageInfo

            ThumbnailPicture.Load(video.Thumbnails.HighResUrl);
            Point point = new Point(0, 45);
            Size usefullThumnailSize = new Size(480, 270);
            Bitmap source = new Bitmap(ThumbnailPicture.Image);
            ThumbnailPicture.Image = new Bitmap(source.Clone(new Rectangle(point.X, point.Y, usefullThumnailSize.Width, usefullThumnailSize.Height), source.PixelFormat), ThumbnailPicture.Size);
            source.Dispose();

            TitleTextBox.Text = video.Title;
            ViewsLabel.Text = video.Engagement.ViewCount + " views";
            UploadDateLabel.Text = video.UploadDate.DateTime.ToShortDateString();
            DescriptionTextBox.Text = video.Description;

            DescriptionTextBox.Visible = true;
            DownloadLabel.Visible = true;
            VideoDwnldBttn.Visible = true;
            AudioDwnldBttn.Visible = true;

            #endregion setPageInfo

        }

        private void LinkTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void LinkTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!loading)
            {
                LinkTextBox.Text = e.Data.GetData(DataFormats.Text).ToString();
                LoadVideo();
            }
        }

        private async void VideoDwnldBttn_Click(object sender, EventArgs e)
        {
            if (downloading)
            {
                MessageBox.Show((string)table["wait"], (string)table["er"]);
                return;
            }
            try
            {
                downloading = true;
                DwnldSttsLabel.Text = (string)table["preparing"];
                var streamManifest = await client.Videos.Streams.GetManifestAsync(currentLink.Remove(0, currentLink.IndexOf('=') + 1)).ConfigureAwait(true);
                var streamInfo = streamManifest.GetMuxed().WithHighestVideoQuality();
                string videoName = video.Title.Replace("\"", " ").Replace("<", " ").Replace(">", " ").Replace("|", " ").Replace("...", " ").Replace("*", " ");
                for (int i = 0; true; i++)
                {
                    if (File.Exists($@"{folderPath}\{videoName}.{streamInfo.Container}"))
                        videoName = video.Title + i;
                    else
                        break;
                }
                if (streamInfo != null)
                {
                    DwnldSttsLabel.Text = (string)table["download"];
                    await client.Videos.Streams.DownloadAsync(streamInfo, $@"{folderPath}\{videoName}.{streamInfo.Container}").ConfigureAwait(true);
                    DwnldSttsLabel.Text = (string)table["finished"];
                }
                else
                {
                    MessageBox.Show((string)table["getEr"], (string)table["er"]);
                    downloading = false;
                    return;
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show((string)table["path"], (string)table["er"]);
            }
            catch (System.Net.Http.HttpRequestException)
            {
                MessageBox.Show((string)table["internet"], (string)table["er"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (string)table["er"]);
            }
            finally
            {
                downloading = false;
            }
        }

        private async void AudioDwnldBttn_Click(object sender, EventArgs e)
        {
            if (downloading)
            {
                MessageBox.Show((string)table["wait"], (string)table["er"]);
                return;
            }
            try
            {
                downloading = true;
                DwnldSttsLabel.Text = (string)table["preparing"];
                string audioName = video.Title + " audio";
                audioName = audioName.Replace("\"", " ").Replace("<", " ").Replace(">", " ").Replace("|", " ").Replace("...", " ").Replace("*", " ");
                var streamManifest = await client.Videos.Streams.GetManifestAsync(currentLink.Remove(0, currentLink.IndexOf('=') + 1)).ConfigureAwait(true);
                var streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();
                for (int i = 0; true; i++)
                {
                    if (File.Exists($@"{folderPath}\{audioName}.{streamInfo.Container}"))
                        audioName = video.Title + i;
                    else
                        break;
                }
                if (streamInfo != null)
                {
                    DwnldSttsLabel.Text = (string)table["download"];
                    await client.Videos.Streams.DownloadAsync(streamInfo, $@"{folderPath}\{audioName}.{streamInfo.Container}").ConfigureAwait(true);
                    DwnldSttsLabel.Text = (string)table["finished"];
                }
                else
                {
                    MessageBox.Show((string)table["getEr"], (string)table["er"]);
                    downloading = false;
                    return;
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show((string)table["path"], (string)table["er"]);
            }
            catch (System.Net.Http.HttpRequestException)
            {
                MessageBox.Show((string)table["internet"], (string)table["er"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (string)table["er"]);
            }
            finally
            {
                downloading = false;
            }
        }
    }
}