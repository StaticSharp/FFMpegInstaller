FFMpegInstaller
========================
FFMpegInstaller is a set of NuGet packages (FFMpegInstaller.*) for convenient usage of FFmpeg with C# based projects.

Usage
-----
Install a NuGet package, corresponding to a target platform (currently only FFMpegInstaller.Windows.x64 is abailable). When your project is built FFmpeg binaries will be copied to output folder. Absolute path for ffmpeg/ffprobe binaries can be read in runtime with `FFMpegInstaller.Discover.InstallationDirectory`

Versioning
---------------
FFMpegInstaller.Windows.x64 contains `ffmpeg-6.0-full_build-shared.7z` build binaries.

Licenses & Acknowledgements
---------------------------
The immediate code of FFMpegInstaller (`Discover.cs` et al.) is provided under the terms of the [MIT license][mit]. However, this license does not cover the bundled FFmpeg binaries which remain governed by GPL-3 (see the LICENSE file of the ffmpeg/ directory for more information).

We (FFMpegInstaller authors) are not affiliated, associated, authorized, endorsed by, maintained, or sponsored or in any way officially connected with FFmpeg and only provide FFmpeg binary files as-is. 

FFmpeg is a trademark of Fabrice Bellard, originator of the FFmpeg project.

FFmpeg official web site: https://ffmpeg.org/

FFmpeg binaries provided had been downloaded from [gyan.dev][downloadpage] (as suggested on the FFmpeg official web site). Files provided by FFMpegInstaller contains only binaries, LICENSE, and README.txt out of FFmpeg build.

FFmpeg might contain patented algorithms as mentioned on [FFmpeg legal page][legal]

FFMpegInstaller packages provided as-is, we make no warranties as to performance, merchantability, fitness for a particular purpose, or any other warranties whether expressed or implied.

GPL is not viral here
---------------------
According to the [GPL FAQ][gplffaq-1], merely calling GPL'd executable from your program does not force you to adopt GPL for your code. Moreover, software installers [are not required][gplffaq-2] to do so either. This package is ultimately meant to be a NuGet-friendly installer for the ffmpeg.

[mit]: https://opensource.org/license/mit/
[gplffaq-1]: https://www.gnu.org/licenses/gpl-faq.en.html#MereAggregation
[gplffaq-2]: https://www.gnu.org/licenses/gpl-faq.en.html#GPLCompatInstaller
[downloadpage]: https://www.gyan.dev/ffmpeg/builds/#release-builds
[legal]: https://ffmpeg.org/legal.html