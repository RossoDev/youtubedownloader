using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VideoLibrary;
using System.Net;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Diagnostics;
using YoutubeExplode;
using YoutubeExplode.Common;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
using System.Threading;
using System.Net.Http;

namespace youtubedownloader
{
    public partial class main : Form
    {
        private static readonly string versionUrl = "https://sharibble.com/ytver";
        private string version = "v.1.0";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private BackgroundWorker downloadWorker = new BackgroundWorker();

        internal static Form form1;

        public main()
        {
            InitializeComponent();
            InitializeForm();
            CheckForUpdates();
            lblversion.Text = $"Version: {version}"; //don't touch

            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Size = new System.Drawing.Size(794, 450);

                        downloadWorker.WorkerReportsProgress = true;
            downloadWorker.DoWork += new DoWorkEventHandler(DownloadWorker_DoWork);
            downloadWorker.ProgressChanged += new ProgressChangedEventHandler(DownloadWorker_ProgressChanged);
            downloadWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DownloadWorker_RunWorkerCompleted);
        }

        private void InitializeForm()
        {
            openFileDialog1.Filter = "Video Files|*.mp4|All Files|*.*";
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private async void CheckForUpdates()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string latestVersion = await client.GetStringAsync(versionUrl).ConfigureAwait(false);

                    if (latestVersion.Trim() != version)
                    {
                        string updateUrl = $"https://sharibble.com/youtubedownloader-setup-{latestVersion}.exe";
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show($"Available update: {latestVersion}\nDownload now: {updateUrl}\n\nYour version: {version}", $"{latestVersion} Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Process.Start($"https://sharibble.com/youtubedownloader-setup-{latestVersion}.exe");
                            Application.Exit();
                        }));
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            Console.WriteLine("Your app is updated.");
                        }));
                    }
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show($"Not possible to check updates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }));
                }
            }
        }

        private void panelmover_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panelresult.Visible = false;

                if (textboxsearch.Text.StartsWith("http://www.youtube.com/"))
                {
                    downloadvid();
                }
                else if (textboxsearch.Text.StartsWith("https://www.youtube.com/"))
                {
                    downloadvid();
                }
                else if (textboxsearch.Text.StartsWith("http://youtube.com/"))
                {
                    downloadvid();
                }
                else if (textboxsearch.Text.StartsWith("https://youtube.com/"))
                {

                    downloadvid();
                } else {
                    MessageBox.Show("Please put a youtube LINK");
                    return;
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void downloadvid()
        {
            try
            {

                string link = textboxsearch.Text.ToString();
                var youTube = YouTube.Default;
                var video = youTube.GetVideo(link);

                if (video == null)
                {
                    MessageBox.Show("The video is not available.");
                    return;
                }

                textboxnamer.Text = video.Title.ToString();

                string videoId = GetVideoIdFromUrl(link);

                if (!string.IsNullOrEmpty(videoId))
                {
                    string videoDescription = GetVideoDescription(videoId);

                    textboxdescriptionr.Text = videoDescription;
                }

                if (!string.IsNullOrEmpty(videoId))
                {
                    string thumbnailUrl = GetThumbnailUrl(videoId);

                    picthumb.Image = LoadImageFromUrl(thumbnailUrl);
                }

                panelresult.Visible = true;

            } catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        int keyd = 1;
        private void btndownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (keyd == 1)
                {
                    keyd = 2;
                    this.Size = new System.Drawing.Size(794, 512);
                }

                string link = textboxsearch.Text;
                progressBar.Value = 0;
                downloadWorker.RunWorkerAsync(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DownloadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string link = e.Argument as string;
            Invoke((Action)(async () =>
            {
                await DownloadVideo(link, (progress) =>
                {
                    
                });
            }));
        }

        private async Task DownloadVideo(string link, Action<double> progressCallback)
        {
            var youTube = new YoutubeClient();
            var video = await youTube.Videos.GetAsync(link);
            var streamInfoSet = await youTube.Videos.Streams.GetManifestAsync(link);
            var streamInfo = streamInfoSet.GetMuxedStreams().OrderByDescending(s => s.VideoQuality).First();

            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string videoTitle = video.Title + "_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".mp4";

            string CleanFilePath(string filePath)
            {
                char[] invalidChars = Path.GetInvalidFileNameChars();
                return new string(filePath.Where(c => !invalidChars.Contains(c)).ToArray());
            }

            string savePath = Path.Combine(downloadsPath, CleanFilePath(videoTitle));

            // Rinomina il file se esiste già
            if (File.Exists(savePath))
            {
                savePath = Path.Combine(downloadsPath, Path.GetFileNameWithoutExtension(savePath) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(savePath));
            }

            try
            {
                var progress = new Progress<double>(p =>
                {
                    progressCallback(p);
                });

                await youTube.Videos.Streams.DownloadAsync(streamInfo, savePath, progress, CancellationToken.None);

                MessageBox.Show("Video saved in " + savePath);
                Process.Start("explorer.exe", "/select," + savePath);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("File in use. Please close any application using the file and try again. Error: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void DownloadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void DownloadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (keyd == 2)
            {
                keyd = 1;
                this.Size = new System.Drawing.Size(794, 450);
            }
        }

        static string GetVideoIdFromUrl(string videoUrl)
        {
                string pattern = @"v=([^&]+)";
                Match match = Regex.Match(videoUrl, pattern);
                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                return null;
            
        }

        static string GetThumbnailUrl(string videoId)
        {
            return "https://img.youtube.com/vi/" + videoId + "/default.jpg";
        }

        static Image LoadImageFromUrl(string url)
        {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(url);
                    using (System.IO.MemoryStream stream = new System.IO.MemoryStream(data))
                    {
                        return Image.FromStream(stream);
                    }
                }
        }

        static string GetVideoDescription(string videoId)
        {
            string videoPageUrl = "https://www.youtube.com/watch?v=" + videoId;

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(videoPageUrl);

            var descriptionNode = doc.DocumentNode.SelectSingleNode("//meta[@name='description']");
            if (descriptionNode != null)
            {
                string description = descriptionNode.GetAttributeValue("content", "");
                return description;
            }

            return string.Empty;
        }


        int key = 1;
        private void picurl_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 1)
                {
                    key = 2;

                    panelsearch.Visible = false;
                    panelurl.Visible = true;
                }
                else if (key == 2)
                {
                    key = 1;

                    panelurl.Visible = false;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        int keyset = 1;
        private void picsettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (keyset == 1)
                {
                    keyset = 2;

                    this.Size = new System.Drawing.Size(988, 450);
                }
                else if (keyset == 2)
                {
                    keyset = 1;

                    this.Size = new System.Drawing.Size(794, 450);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkboxtheme_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Reset();

                if (checkboxtheme.Checked)
                {

                    panel1.BackColor = Properties.Settings.Default.paneldark;
                    panelurl.BackColor = Properties.Settings.Default.paneldark;
                    label1.BackColor = Properties.Settings.Default.paneldark;
                    labelname.BackColor = Properties.Settings.Default.paneldark;
                    textboxnamer.BackColor = Properties.Settings.Default.paneldark;
                    labeldescription.BackColor = Properties.Settings.Default.paneldark;
                    textboxdescriptionr.BackColor = Properties.Settings.Default.paneldark;

                    label1.ForeColor = Properties.Settings.Default.darktext;
                    labeldescription.ForeColor = Properties.Settings.Default.darktext;
                    labelname.ForeColor = Properties.Settings.Default.darktext;
                    labeltheme.ForeColor = Properties.Settings.Default.darktext;
                    textboxnamer.ForeColor = Properties.Settings.Default.darktext;
                    textboxdescriptionr.ForeColor = Properties.Settings.Default.darktext;

                    button1.ForeColor = Properties.Settings.Default.darktext;
                    button1.BackColor = Properties.Settings.Default.paneldark;
                    btndownload.ForeColor = Properties.Settings.Default.darktext;
                    btndownload.BackColor = Properties.Settings.Default.paneldark;

                    panelmover.BackColor = Properties.Settings.Default.panelmoverdark;

                    this.BackColor = Properties.Settings.Default.darkform;
                    panelsettings.BackColor = Properties.Settings.Default.darkform;

                }
                else if (!checkboxtheme.Checked)
                {

                    panel1.BackColor = Properties.Settings.Default.lightpanel;
                    panelurl.BackColor = Properties.Settings.Default.lightpanel;
                    label1.BackColor = Properties.Settings.Default.lightpanel;
                    labelname.BackColor = Properties.Settings.Default.lightpanel;
                    textboxnamer.BackColor = Properties.Settings.Default.lightpanel;
                    labeldescription.BackColor = Properties.Settings.Default.lightpanel;
                    textboxdescriptionr.BackColor = Properties.Settings.Default.lightpanel;

                    label1.ForeColor = Properties.Settings.Default.lighttext;
                    labeldescription.ForeColor = Properties.Settings.Default.lighttext;
                    labelname.ForeColor = Properties.Settings.Default.lighttext;
                    labeltheme.ForeColor = Properties.Settings.Default.lighttext;
                    textboxnamer.ForeColor = Properties.Settings.Default.lighttext;
                    textboxdescriptionr.ForeColor = Properties.Settings.Default.lighttext;

                    button1.ForeColor = Properties.Settings.Default.lighttext;
                    button1.BackColor = Properties.Settings.Default.lightpanel;
                    btndownload.ForeColor = Properties.Settings.Default.lighttext;
                    btndownload.BackColor = Properties.Settings.Default.lightpanel;

                    panelmover.BackColor = Properties.Settings.Default.panelmoverlight;

                    this.BackColor = Properties.Settings.Default.lightform;
                    panelsettings.BackColor = Properties.Settings.Default.lightform;

                }

                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void picgithub_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/RossoDev/");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        int keysearch = 1;
        private void picsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (keysearch == 1)
                {
                    keysearch = 2;

                    panelurl.Visible = false;
                    panelsearch.Visible = true;
                }
                else if (keysearch == 2)
                {
                    keysearch = 1;

                    panelsearch.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pickofi_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Thanks for supporting our project.");
                Process.Start("https://ko-fi.com/deviro");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void piclinktree_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://linktr.ee/favdev");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = tboxsearch.Text;
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("Please enter a search query.");
                    return;
                }

                Process.Start("https://www.youtube.com/results?search_query=" + query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
