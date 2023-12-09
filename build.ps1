dotnet publish -c release
if (Test-Path "bin\Build\") {
  Remove-Item -Path "bin\Build\" -Recurse
}
if (Test-Path "bin\PKHeXPluginPile.zip") {
  Remove-Item -Path "bin\PKHeXPluginPile.zip"
}
New-Item -Path "bin\" -Name "Build" -ItemType "directory"
New-Item -Path "bin\" -Name "Build\Individual" -ItemType "directory"
Copy-Item -Path "bin\x64\Release\net8.0-windows\publish\PluginPile.*.dll" -Destination "bin\Build\Individual" -Exclude "PluginPile.Common.dll","PluginPile.Unmaintained.*.dll"
Copy-Item -Path "bin\x64\Release\net8.0-windows\publish\PluginPile.dll" -Destination "bin\Build"
New-Item -Path "bin\" -Name "Build\Unmaintained" -ItemType "directory"
Copy-Item -Path "bin\x64\Release\net8.0-windows\publish\PluginPile.Unmaintained.*.dll" -Destination "bin\Build\Unmaintained"
Copy-Item -Path "bin\x64\Release\net8.0-windows\publish\*z3.dll" -Destination "bin\Build\Unmaintained"
Compress-Archive -Path "bin\Build\*" -DestinationPath "bin\PKHeXPluginPile.zip"
