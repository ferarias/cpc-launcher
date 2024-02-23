using System.Collections.Generic;
using System.IO;

namespace Emu.Common
{
    public class GameSystem
    {
        public string Name { get; set; } = string.Empty;
        public DirectoryInfo? GamesPath { get; set; }
        public DirectoryInfo? ScreenshotsPath { get; set; }
        public DirectoryInfo? MarqueesPath { get; set; }

        public IEnumerable<Emulator> Emulators { get; set; } = [];
    }
}
