FFMpegInstaller
===============
FFMpegInstaller is a set of NuGet packages to provide everyone with a convenient way to use FFmpeg command line programs from .NET-based projects. The following platform-specific packages are available at the moment:

* [FFMpegInstaller.Windows.x64](https://www.nuget.org/packages/FFMpegInstaller.Windows.x64/)

Usage
-----
Install the NuGet package corresponding to your target platform as a dependency to your project. This will configure the project's build process to copy the `ffmpeg` and `ffprobe` binaries (and all their libraries) into some place inside the build output directory. Your program can discover their exact location in runtime using `FFMpegInstaller.Discover.InstallationDirectory` property.

Upstream distributions
----------------------
The FFMpegInstaller packages rebundle archives downloaded from https://github.com/BtbN/FFmpeg-Builds/releases (as suggested by the FFmpeg official website). To save users some internet traffic and disk space we only ship executables, libraries, LICENSE, and README.txt files from these archives. More specifically:

* FFMpegInstaller.Windows.x64 rebundles [`ffmpeg-6.0-full_build-shared.7z`](https://github.com/BtbN/FFmpeg-Builds/releases/download/autobuild-2023-06-26-12-53/ffmpeg-n6.0-26-g3f345ebf21-win64-gpl-shared-6.0.zip)

Licenses & Legal matters
------------------------
The immediate code of FFMpegInstaller (`Discover.cs` et al.) is provided under the terms of the [MIT license][mit]. However, this license does not cover the bundled FFmpeg binaries which remain governed by GPL-3 (see the LICENSE file of the ffmpeg/ directory for more information).

The authors of FFMpegInstaller packages are not affiliated with, associated with, authorized by, endorsed by, sponsored by, or in any way officially connected with the FFmpeg project. The packages are provided as-is, with no warranties as to performance, merchantability, fitness for a particular purpose, or any other warranties whether expressed or implied.

FFmpeg official website: https://ffmpeg.org/.
FFmpeg is a trademark of Fabrice Bellard, the originator of the FFmpeg project.
FFmpeg might contain patented algorithms as mentioned on [the FFmpeg legal page][legal].

GPL is not viral here
---------------------
According to the [GPL FAQ][gplffaq-1], merely calling GPL'd executable from your program does not force you to adopt GPL for your code. Moreover, software installers [are not required][gplffaq-2] to do so either. This package is ultimately meant to be a NuGet-friendly installer for the FFmpeg.

[mit]: https://opensource.org/license/mit/
[legal]: https://ffmpeg.org/legal.html
[gplffaq-1]: https://www.gnu.org/licenses/gpl-faq.en.html#MereAggregation
[gplffaq-2]: https://www.gnu.org/licenses/gpl-faq.en.html#GPLCompatInstaller