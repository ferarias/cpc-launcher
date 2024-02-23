using System.IO;

namespace Emu.Common
{
    public class Emulator
    {
        public string? Name { get; set; } = "";
        public FileInfo? EmulatorPath { get; set; }
        public EmulatorFeatures Features { get; set; } = new();
    }
}
