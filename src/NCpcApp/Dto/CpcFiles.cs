namespace CpcLauncher.Dto
{
    public class CpcFiles : List<FileInfo>
    {
        public void ReadFromFile(string path)
        {
            Clear();
            if (!Directory.Exists(path))
            {
                return;
            }

            var di = new DirectoryInfo(path);
            foreach (var fi in (di.GetFiles("*.dsk").Union(di.GetFiles("*.zip"))).OrderBy(fi => fi.Name))
            {
                if(fi.Extension.Equals(".dsk", StringComparison.InvariantCultureIgnoreCase))
                {
                    Add(fi);
                }
                if (fi.Extension.Equals(".zip", StringComparison.InvariantCultureIgnoreCase))
                {
                    using var zip = System.IO.Compression.ZipFile.OpenRead(fi.FullName);
                    if(zip.Entries.Any(z => z.Name.EndsWith(".dsk", StringComparison.InvariantCultureIgnoreCase)))
                    {
                        Add(fi);
                    }
                }
            }
        }
    }
}