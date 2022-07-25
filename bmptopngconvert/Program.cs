// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Drawing.Imaging;

Console.WriteLine("Hello, World!");
const string SOURCE_PATH = @"D:\Machine-learning\MachineLearning-Images\positive\Averages";
var files = Directory.GetFiles(SOURCE_PATH, "*.*", SearchOption.AllDirectories).ToList();

foreach (var filename in files)
{
    if (filename.Contains(".bmp"))
    {
        var indeoftxt = filename.IndexOf(".txt.");
        var startindex = indeoftxt - 17;
        var newPngName = filename.Substring(startindex, 21 - 4);
        //"D:\\Machine-learning\\MachineLearning-Images\\negative\\Averages\\mBvh____\\19-01-08-12-04-14.txt.bmp"

        //23 => 101

        string pathnew = filename.Substring(0, filename.Length - 25);
        var imaged = Image.FromFile(filename);
        imaged.Save(pathnew + newPngName + ".png", ImageFormat.Png);
        imaged.Dispose();
        System.IO.File.Delete(filename);

    }

    //using (var bitmap = new Bitmap(filename))
    //using (var stream = new MemoryStream())
    //{
    //    bitmap.Save(stream, ImageFormat.Png);
    //}

}