using Emu.Common;

namespace Emu.LauncherApp
{
    internal static class Defaults
    {
        public static readonly Dictionary<Platform, GameSystem> DefaultSystems = new()
        {
            {
                Platform.AmstradCpc, new GameSystem
                {
                    Name = "Amstrad Cpc",
                    Emulators =
                    [
                        new Emulator
                        {
                            Name = "CPCEC",
                            EmulatorPath = new FileInfo(Properties.Settings.Default.CpcecPath),
                            Features = new EmulatorFeatures { AllowedExtensions = [".dsk"] },
                        }
                    ],
                    GamesPath = new DirectoryInfo(Properties.Settings.Default.CpcGames),
                    ScreenshotsPath = new DirectoryInfo(Properties.Settings.Default.CpcScreenshots),
                    MarqueesPath = new DirectoryInfo(Properties.Settings.Default.CpcMarquees)
                }
            },
            {
                Platform.ZxSpectrum, new GameSystem
                {
                    Name = "Zx Spectrum",
                    Emulators =
                    [
                        new Emulator
                        {
                            Name = "Speccy",
                            EmulatorPath = new FileInfo(Properties.Settings.Default.SpeccyPath),
                            Features = new EmulatorFeatures { AllowedExtensions = [".Z80", ".SNA", ".TAP", ".TZX", ".FDI", ".TRD", ".SCL"] },
                        }
                    ],
                    GamesPath = new DirectoryInfo(Properties.Settings.Default.ZxGames),
                    ScreenshotsPath = new DirectoryInfo(Properties.Settings.Default.ZxScreenshots),
                    MarqueesPath = new DirectoryInfo(Properties.Settings.Default.ZxMarquees)
                }
            }
        };
    }
}
