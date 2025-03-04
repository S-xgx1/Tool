using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

public class ImageConversion
{
    public static void ConvertJpgToPng(string sourceDirectory)
    {
        // 获取所有文件
        var files = Directory.GetFiles(sourceDirectory, "*.jpg", SearchOption.AllDirectories);

        foreach (var file in files)
        {
            // 获取文件名（不包括扩展名）
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);

            // 构建新的文件路径（PNG格式）
            var newFilePath = Path.ChangeExtension(file, ".png");

            // 使用ImageSharp加载JPG图片
            using (var image = Image.Load<Rgba32>(file))
                // 保存为PNG格式
                image.SaveAsPng(newFilePath);

            // 删除原始的JPG文件
            File.Delete(file);
        }
    }
}