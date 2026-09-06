dotnet publish -r win-x64 -c Release
Remove-Item AvaloniaAOT\bin\Release\net10.0\win-x64\publish\*.pdb
makensis installer.nsi