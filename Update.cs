using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace Spotifly
{
    public partial class Form1
    {
        // Freq * timer.Interval for ms
        private int timesUpdated = 1;

        private readonly int slowUpdateFreq = 27, midUpdateFreq = 5;
        private readonly Timer timer = new Timer();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Timer will dispose onFormClosing but this doesn't detect it XD")]
        private void UpdatesStart()
        {
            timer.Interval = 100;
            timer.Tick += Update;
            timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            timesUpdated++;
            FastUpdate();
            switch (UpdateTier())
            {
                case 2:
                    MidUpdate();
                    break;

                case 3:
                    MidUpdate();
                    SlowUpdate();
                    break;
            }
            timesUpdated *= Convert.ToInt32(timesUpdated < slowUpdateFreq);

            int UpdateTier()
            {//higher tiers means they repeat less often
                bool tier3 = timesUpdated % (slowUpdateFreq + 0.0) == 0;
                bool tier2 = timesUpdated % (midUpdateFreq + 0.0) == 0;

                int tier = Convert.ToInt32(tier3) * 3
                         + Convert.ToInt32(tier2 && !tier3) * 2
                         + Convert.ToInt32(!tier3 && !tier2);
                return tier;
            }
        }

        private void FastUpdate()
        {
            try
            {
                SetProgressBarValueForCurrentMediaPos();
            }
            catch
            { }
        }

        private void MidUpdate()
        {
            if (axWindowsMediaPlayer.playState == WMPPlayState.wmppsPlaying)
                isPlaying = true;
            else
                isPlaying = false;

            if (axWindowsMediaPlayer.uiMode != "none" && !axWindowsMediaPlayer.fullScreen)
                axWindowsMediaPlayer.uiMode = "none";
            try
            {
                if (MinimumSize.Width == verticalModeMinWidth && ResizeForMediaCheckBox.Checked && panels[0].Visible)
                {
                    MinimumSize = new Size(normalMinWidth, MinimumSize.Height);
                    SetFormSizeForCurrentMedia();
                }

                string elapsedTime = showRemainingTimeInElapsed ? GetRemainingTimeString() : axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
                ElapsedTimeLabel.Text = string.IsNullOrWhiteSpace(elapsedTime) || string.IsNullOrWhiteSpace(axWindowsMediaPlayer.URL) ? "00:00" : elapsedTime;
                VolumeTrackBar.Value = axWindowsMediaPlayer.settings.volume;
                MediaLengthLabel.Location = new Point(Width - (initialMediaLengthLabelDistanceToFormEnd + MediaLengthLabel.Width), MediaLengthLabel.Location.Y);

                string currentName = GetCurrentMediaName();
                CurrentMediaTxtBox.Text = currentName;

                GetColorsForTheme(currentTheme, out _, out _, out _, out Color ButtonColor, out _);
                if (axWindowsMediaPlayer.playState == WMPPlayState.wmppsReady || axWindowsMediaPlayer.playState == WMPPlayState.wmppsPaused || axWindowsMediaPlayer.playState == WMPPlayState.wmppsStopped ||
                    axWindowsMediaPlayer.playState == WMPPlayState.wmppsUndefined)
                    PlayBttn.Image = SubstituteNotBlankFromImage(Properties.Resources.Playy, ButtonColor);
                else if (axWindowsMediaPlayer.playState != WMPPlayState.wmppsScanForward && axWindowsMediaPlayer.playState != WMPPlayState.wmppsScanReverse)
                    PlayBttn.Image = SubstituteNotBlankFromImage(Properties.Resources.Pause, ButtonColor);

                MediaLengthLabel.Text = axWindowsMediaPlayer.currentMedia.durationString;
            }
            catch
            { }
        }

        private void SlowUpdate()
        {
            MediaListView_DrawMedia();
        }
    }
}