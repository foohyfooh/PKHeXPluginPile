dotnet publish -c release
if (Test-Path "bin\Build\") {
  Remove-Item -Path "bin\Build\" -Recurse
}
if (Test-Path "bin\PluginPile.dll") {
  Remove-Item -Path "bin\PluginPile.dll"
}
if (Test-Path "bin\PKHeXPluginPile.zip") {
  Remove-Item -Path "bin\PKHeXPluginPile.zip"
}
New-Item -Path "bin\" -Name "Build" -ItemType "directory"
Copy-Item -Path "bin\Release\net7.0-windows\publish\*.dll" -Destination "bin\Build" -Exclude "PKHeX.Core.dll","PluginPile.dll","PluginPile.Common.dll","PluginPile.Unmaintained.*.dll"
Copy-Item -Path "bin\Release\net7.0-windows\publish\PluginPile.dll" -Destination "bin"
Compress-Archive -Path "bin\Build\*" -DestinationPath "bin\PKHeXPluginPile.zip"
