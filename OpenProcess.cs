using System.Diagnostics;
using System.Text;

public class OpenProcess
{
	public void mailToProcess(string addrs, string subj, string body, string attach)
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("mailto:" + addrs);
		sb.Append("&subject=" + subj);
		sb.Append("&body=" + body);
		sb.Append("&attachment='" + attach + "'");
		Process process = new Process();
		process.StartInfo.FileName = sb.ToString();
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.RedirectStandardOutput = false;
		process.Start();
		process.Dispose();
	}
}