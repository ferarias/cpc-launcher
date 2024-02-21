namespace CpcLauncher
{
    public static class CpcFilesReader
    {
        public static List<FileInfo> ReadFromDirectory(string path)
        {
            var list = new List<FileInfo>();
            if (Directory.Exists(path))
            {
                var di = new DirectoryInfo(path);
                foreach (var fi in di.GetFiles())
                {
                    if (fi.Extension.Equals(".dsk", StringComparison.InvariantCultureIgnoreCase))
                    {
                        list.Add(fi);
                    }
                    if (fi.Extension.Equals(".zip", StringComparison.InvariantCultureIgnoreCase))
                    {
                        using var zip = System.IO.Compression.ZipFile.OpenRead(fi.FullName);
                        if (zip.Entries.Any(z => z.Name.EndsWith(".dsk", StringComparison.InvariantCultureIgnoreCase)))
                        {
                            list.Add(fi);
                        }
                    }
                }
            }
            return list;
        }
    }
}