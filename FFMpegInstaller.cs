// SPDX-License-Identifier: MIT

using System.IO;
using System.Reflection;

public static class FFMpegInstaller
{
    public static readonly string InstallationDirectory = 
        Path.GetFullPath(Path.Combine("ffmpeg", "bin"),
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

    public static readonly string FFMpegPath = Path.Combine(InstallationDirectory, "ffmpeg.exe");
    
    public static readonly string FFProbePath = Path.Combine(InstallationDirectory, "ffprobe.exe");
    
    public static readonly string FFPlayPath = Path.Combine(InstallationDirectory, "ffplay.exe");
}
