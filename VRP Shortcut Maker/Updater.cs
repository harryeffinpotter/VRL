using System;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;


namespace VRL
{
    class Updater
    {

        public static void Melt()
        {
            Process.Start(new ProcessStartInfo()
            {
                Arguments = "/C choice /C Y /N /D Y /T 5 & Del \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            });
        }

        public static string AppName { get; set; }
        public static string Repostory { get; set; }
        private static string RawGitHubUrl;
        private static string GitHubUrl;

        static readonly public string LocalVersion = "1.3.1";
        public static string currentVersion = string.Empty;
        public static string changelog = string.Empty;

        private static bool IsUpdateAvailable()
        {
            HttpClient client = new HttpClient();
            try
            {
                currentVersion = client.GetStringAsync($"{RawGitHubUrl}/master/version").Result;
                currentVersion = currentVersion.Remove(currentVersion.Length - 1);
                changelog = client.GetStringAsync($"{RawGitHubUrl}/master/changelog.txt").Result;
            }
            catch { return false; }
            return LocalVersion != currentVersion;
        }
        public static void Update()
        {
            RawGitHubUrl = $"https://raw.githubusercontent.com/{Repostory}";
            GitHubUrl = $"https://github.com/{Repostory}";
            if (IsUpdateAvailable())
                doUpdate();
        }
        private static void doUpdate()
        {
            DialogResult dialogResult = MessageBox.Show($"There is a new update you have version {LocalVersion}, do you want to update?\nCHANGELOG\n{changelog}", $"Version {currentVersion} is available", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            try
            {
                using (var fileClient = new WebClient())
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    fileClient.DownloadFile($"{GitHubUrl}/releases/download/v{currentVersion}/{AppName}.exe", $"{AppName} v{currentVersion}.exe");
                }
                Melt();
                Process.Start($"{AppName} v{currentVersion}.exe");
            }
            catch { }

            Environment.Exit(0);


        }
    }
}


