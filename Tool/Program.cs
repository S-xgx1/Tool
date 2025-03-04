using System.Text;

var directoryPath = args[0]+"122";
var re            = $"{directoryPath}1123";

Console.WriteLine(re);
var files = Directory.GetFiles(directoryPath, "", SearchOption.AllDirectories);
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
foreach (var filePath in files)
{
    var content = File.ReadAllText(filePath, Encoding.GetEncoding("gbk"));
    File.WriteAllText(filePath, content, Encoding.UTF8);
}