// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace FFMpegInstaller
{
    public static class Discover
    {
        public static readonly string InstallationDirectory = 
            Path.GetFullPath(Path.Combine("ffmpeg", "bin"),
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
    }
}
