using System.IO;

namespace CpcLauncher
{
    public class Emulator
    {
        public string? Name { get; set; } = "";
        public FileInfo? EmulatorPath { get; set; }
        public EmulatorFeatures Features { get; set; } = new();
    }
}
