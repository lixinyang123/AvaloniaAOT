dotnet publish -r win-x64 -c Release
Remove-Item AvaloniaAOT\bin\Release\net8.0\win-x64\publish\AvaloniaAOT.pdb
makensis installer.nsi