using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
		string pageName = args[0];

		pageName = pageName.Substring(pageName.LastIndexOf(@"/") + 1);

		ProcessStartInfo ProcessInfo = new ProcessStartInfo();
		Process Process = new Process();

		//ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + string.Format(@"facebook-scraper --filename C:\FacebookScraper\{0}.json -v --pages 2 --format json --comments {1}", pageName + "_" + DateTime.Now.ToString("ddMMMMyyyyHHmmss"), pageName));
		//ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + @"facebook-scraper --help");
		ProcessInfo = new ProcessStartInfo(@"cmd.exe", "/c " + string.Format(@"facebook-scraper --filename C:\ScraperOutputPost\{0}.json -v --pages 2 --format json -c C:\Users\Administrator\Downloads\facebook.com_cookies.txt --comments {1}", pageName + "_" + DateTime.Now.ToString("ddMMMMyyyyHHmmss"), pageName));
		ProcessInfo.CreateNoWindow = false;
		ProcessInfo.UseShellExecute = true;
		ProcessInfo.Verb = "runas";

		Process = Process.Start(ProcessInfo);
		Process.WaitForExit();
	}
}