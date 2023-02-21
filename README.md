# AvaloniaAOT

Avalonia Native AOT Templete. `~20MB size`

![image](https://user-images.githubusercontent.com/32838371/206870017-f7354f1f-797d-4c5f-981b-8b57f5529b61.png)

You can disable UPX Compresse to get lower memory usage. `~20MB usage`

## Prerequisites

Windows

```bash
Visual Studio 2022, including Desktop development with C++ workload.
```

Ubuntu (20.04+)

```bash
sudo apt-get install libicu-dev cmake
```

## Publish with NativeAOT

```bash
dotnet publish -r <RID> -c Release

# Build for Windows example
dotnet publish -r win-x64 -c Release
```

## Builder the installer with NSIS

NSIS installer `~20MB usage`

```bash
pwsh ./publish.ps1
```

> if you builder the installer with nsis, you can ignore upx compression, so you can get better startup performance.

## Screenshot

![screenshot](https://user-images.githubusercontent.com/32838371/206871289-5cc1bd68-3c97-437b-affc-2757e65204a4.png)
