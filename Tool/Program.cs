using System.Text;

string directoryPath = args[0];
string[] files = Directory.GetFiles(directoryPath,"", SearchOption.AllDirectories);
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
foreach (string filePath in files)
{
    string content = File.ReadAllText(filePath, Encoding.GetEncoding("gbk"));
    File.WriteAllText(filePath, content, Encoding.UTF8);
}