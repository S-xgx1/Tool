// var filePath1 = @"C:\Users\Public\Project\SG2\Assets\_Scripts\ScriptableObjects\Editor\ConfigTables";
// var filePath2 = @"C:\Users\S_xgx\Documents\WeChat Files\wxid_81roiitln2ne22\FileStorage\File\2024-10\CSV(2)\CSV";
//
// // get filepath1 .csv file names and remove pix
// var fileNames1 = Directory.GetFiles(filePath1, "*.csv.asset", SearchOption.TopDirectoryOnly).Select(Path.GetFileNameWithoutExtension).Select(Path.GetFileNameWithoutExtension);
//
// // get filepath2 .csv file names
// var fileNames2 = Directory.GetFiles(filePath2, "*.csv", SearchOption.TopDirectoryOnly).Select(Path.GetFileNameWithoutExtension);
//
// // 查找fileNames1中不存在于fileNames2中的文件
// var missingFiles = fileNames1.Except(fileNames2);
//
// // 输出结果
// foreach (var file in missingFiles)
// {
//     Console.Write($"{file}\t");
// }


const string sourceDirectory = @"C:\Users\S_xgx\AppData\LocalLow\PunctualSolutions\VR智能运动身心调节系统\单车心理放松\心理图片"; // 替换为你的源目录路径
ImageConversion.ConvertJpgToPng(sourceDirectory);