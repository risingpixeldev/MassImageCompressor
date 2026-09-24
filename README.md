# Mass Image Compressor
_High Quality Batch Image Compression of JPEG, PNG and Raw formats. Originally created by: [yogee](http://icompressor.blogspot.com/2016/10/introduction-to-hassle-free-image.html)_

## Overview
Mass Image Compressor is easy to use - a point and shoot batch image compressor and converter tool for Web site optimization, photographers, HTML game creator and casual Windows users.

MassImageCompressor reduces considerable (>90%) image size by user selected dimensions and quality parameters. Reduce all images in a folder (and optionally sub-folders) with just single click. Mass Image Compression for webpages, email or storage on mobile device was never this easy! All image Metadata (EXIF Tags) are preserved.

## Features
- Mass Image Compressor reduces considerable (>90%) image size by compromising on Image dimensions and Quality.
- Reduce all images in a folder with just single click
- Can recursively resize/compress files in given folder and sub-folders.
- Preserves image Metadata (EXIF Tags)
- Super fast and high quality compression
- [New in V.3] Support RAW formats of most cameras
- [New in V.3] Filter based on Image Size
- [New in V.3] Improved Resizing and Compression Algorithms
- [New in V.3.1] Saves progressive JPEG for faster page load and higher page rank

## Original source code

This repository is a clone of the latest revision [r26 on SourceForge](https://sourceforge.net/p/icompress/code/HEAD/tree/), created by Yogendrasinh. It may contain in the future small adjustments to it's origin.

## Build on Windows

The application is a classic Windows Forms project targeting **.NET Framework 4.8**. To build it, install Visual Studio 2019 or later with the **.NET desktop development** workload and the **.NET Framework 4.8 targeting pack**.

1. Open `sources\WindowsAndCommon\NeoFoton.sln` in Visual Studio.
2. Select the `Release` configuration and `Any CPU` platform.
3. Build the `NeoFoton` project.

Visual Studio may report that `MICompressor` / `ImageCompressor.vdproj` is unsupported. This does not prevent building or running the `NeoFoton` application: it is a separate, optional legacy MSI-installer project. Dismiss the message and build `NeoFoton`, or open `NeoFoton\NeoFoton.csproj` directly to omit the installer project entirely.

The executable and its required image-processing tools are written to:

```
sources\WindowsAndCommon\NeoFoton\bin\Release\Image Compressor.exe
```

The same build can be run from a Visual Studio Developer PowerShell:

```powershell
msbuild sources\WindowsAndCommon\NeoFoton\NeoFoton.csproj /t:Build /p:Configuration=Release /p:Platform=AnyCPU
```

There are no package-restore steps: all managed references are framework assemblies, and the required native tools (`dcraw`, `jpegtran`, `optipng`, and `pngquant`) are copied from `NeoFoton\Exec` into the output directory during the build.

### Optional MSI installer

The solution also contains the legacy Visual Studio Setup Project at `sources\WindowsAndCommon\ImageCompressor\ImageCompressor.vdproj`. Building it is optional and requires the **Microsoft Visual Studio Installer Projects** extension. Its Release output is `ImageCompressor\Release\MassImageCompressor.msi`.
