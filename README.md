# AvaloniaAOT

Avalonia Native AOT Templete. Smaller size, lower memory usage and faster startup speed. `~18MB size`

![image](https://user-images.githubusercontent.com/32838371/221381097-886b1a7b-4b77-42fe-8644-12fde7c48b9d.png)

You can disable UPX Compresse to get lower memory usage. `~20MB usage`

## Prerequisites

Windows

```bash
Visual Studio 2022, including .NET 8 & Desktop development with C++ workload.
```

Ubuntu (20.04+)

```bash
sudo apt-get install dotnet-sdk-8.0 libicu-dev cmake
```

## Publish with NativeAOT

```bash
dotnet publish -r <RID> -c Release

# Build for Windows example
dotnet publish -r win-x64 -c Release
```

## Builder the installer with NSIS

NSIS installer `~13MB size`

```bash
pwsh ./publish.ps1
```

> if you builder the installer with nsis, you can ignore upx compression, so you can get better startup performance.

## Screenshot

![screenshot](https://user-images.githubusercontent.com/32838371/206871289-5cc1bd68-3c97-437b-affc-2757e65204a4.png)
