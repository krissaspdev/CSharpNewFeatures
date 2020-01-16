using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static NewFeatures._7_0.DemoDirectorySize;

namespace NewFeatures._7_0
{
    public static class DemoDirectorySize
    {
        public static async Task<long> GetDirSize(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
                return 0; // directory is empty, but we still generate fully fledged task

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
                .Sum(x => new FileInfo(x).Length));
        }
        
        public static async ValueTask<long> GetDirSize2(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
                return 0; // directory is empty, but we still generate fully fledged task

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
                .Sum(x => new FileInfo(x).Length));
        }

    }
    public class NewAsyncReturnType
    {
        public static void Run()
        {
            Console.WriteLine(GetDirSize2(@"c:\\temp"));
        }
    }
}