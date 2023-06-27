// SPDX-License-Identifier: MIT

using System.IO;
using System.Reflection;

public static class FFMpegInstaller
{
    public static readonly string InstallationDirectory = 
        Path.GetFullPath(Path.Combine("ffmpeg", "bin"),
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
}
