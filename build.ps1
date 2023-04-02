dotnet publish -c release
if (Test-Path "bin\Build\") {
  Remove-Item -Path "bin\Build\" -Recurse
}
New-Item -Path "bin\" -Name "Build" -ItemType "directory"
Copy-Item -Path "bin\Release\net7.0-windows\publish\*.dll" -Destination "bin\Build" -Exclude "PKHeX.Core.dll","Common.dll"
if (Test-Path "bin\PKHeXPluginPile.zip") {
  Remove-Item -Path "bin\PKHeXPluginPile.zip"
}
Compress-Archive -Path "bin\Build\*" -DestinationPath "bin\PKHeXPluginPile.zip"
