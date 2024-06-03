using Aspose.Zip;
using System.IO.Compression;

namespace AutoArchiver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\PMG.DESKTOP-E9QQU0V\Desktop\Test";

                using (FileStream zipFile = File.Open(path, FileMode.Create))
                {
                    using (var archive = new Archive())
                    {
                        foreach (var entry in archive.Entries)
                        {
                            archive.CreateEntry(entry.Name, zipFile);
                        }
                        archive.Save(zipFile);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Oops. I don't have acces to this file.");
            }
            catch (Exception)
            {
            
            }

            
            
        }
    }
}
