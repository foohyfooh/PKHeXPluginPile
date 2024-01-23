# PKHeX Plugin Pile
This is meant to be a collections of all my random [PKHeX](https://github.com/kwsch/PKHeX) plugins. The idea of this single repo is to make it easier for batch updates, adding random one-off tools, or prototyping things before trying to get them into PKHeX.

There are also some plugins made by others in the [Unmaintained](/Unmaintained/) folder which don't appear to be actively updated so I have a copy of those to keep them compatible with the latest PKHeX.

## Setup Instructions
- Download the plugins from the latest release [here](https://github.com/foohyfooh/PKHeXPluginPile/releases/latest).
- Extract and unblock them in Windows' Properties Menu.
- Put them in the *plugins* folder that is in the same directory as the PKHeX binary.

*If you are confused on the setup then you can follow the instructions from PKHeX-Plugins [here](https://github.com/architdate/PKHeX-Plugins/wiki/Installing-PKHeX-Plugins).*

*While the individual plugins don't require each other to work, when updating please ensure all plugin pile plugins are the same version or there may be issues. This is because there is a common emdedded library that will only be loaded once by PKHeX.*

## Sorting Plugin
The purpose of this plugin is to provide sorting by different regional Pokédexes and other sorting features.
- *Sort Boxes By* should now be in the *Tools* menu of PKHeX.
- *Insert Slot* should be in the slot context menu

## Raid/Outbreak Importer Plugin
The purpose of this plugin is to provide a convient way to import the raid data from [Project Pokémon Event Gallery](https://github.com/projectpokemon/EventsGallery) into Sword/Shield and Scarlet/Violet.
- *Import Raid* and/or *Import Outbreak* should now be in the *Tools* menu of PKHeX.
- Once you click the button a folder select dialog will pop up.
- Select an appropriate folder from the Event Gallery for the game and it should be imported:
  - For Sword/Shield raids, this is the folder with the blocks.
  - For Scarlet/Violet raids and outbreaks, this is the folder with the Identifier.txt.

### Related Tools
- [Manu098vm](https://github.com/Manu098vm)'s [Tera-Finder](https://github.com/Manu098vm/Tera-Finder)
- [MewTracker](https://github.com/MewTracker)'s [RaidCalc](https://github.com/MewTracker/sv-research)

## Scarlet/Violet Vivillon Plugin
The purpose of this plugin is allow a user to edit which Vivillon Spawns in Scarlet and Violet overworld without requiring GO Connectivity.
- *Vivillon Form Changer* should now be in the *Tools* menu of PKHeX. Click on it to open the form.
- Select the form you want to appear in the game and click save.

### Note
The name was going to be one of the following SVVivillonPlugin, ScViVivillonPlugin, SVivillonPlugin, ScViVillonPlugin and I just went with SVivillonPlugin.

## Fashion Editor Plugin
The purpose of this plugin is to allow for editing the owned clothes in games. <br>
- *Fashion Editor* should now be in the *Tools* menu of PKHeX
  - Currently works with
    - Pokémon Sword / Shield
    - Pokémon Brilliant Diamond / Shining  Pearl
    - Pokémon Legends Arceus

### Pokémon Sword and Shield Note
Note that in Sword and Shield when unlocking Tops this unlocks it in the uniform tab even if the other parts of the uniform aren't unlocked since the game is expecting all of them to be unlocked at the same time.

## Scarlet/Violet Profile Picture Viewer Plugin
The purpose of this plugin is to view and save the Profile Picture and Icon in Pokémon Scarlet and Violet.
- *Profile Picture Viewer* should now be in the *Tools* menu of PKHeX.

This is a port of the script that [Pako96](https://projectpokemon.org/home/profile/129441-pako96/) provided [here](https://projectpokemon.org/home/forums/topic/63327-scarletviolet-trainer-pictureicon-visualizer/).

If you are looking for injecting images into the game then you should use [PizzaTimeJoshua](https://github.com/PizzaTimeJoshua)'s [SV-Image-Injector](https://github.com/PizzaTimeJoshua/SV-Image-Injector) since it uses the correct method for converting images to the DXT1 format that the game uses.

## TM Tool
The purpose of this plugin is to do miscellaneous TM edits on mons
- *TM Tool* should now be in the slot context menu and the box modifications context menu.

## Roamer Tool
The purpose of this tool is to edit the roaming Pokémon in the Gen 4 Games and Pokémon X and Y.
- *Edit Roamer* should now be in the *Tools* menu of PKHeX

## Battle and Rental Teams Viewer
The purpose of this plugin is to view the Battle and Rental Teams
- *View Battle Teams* should now be in the *Tools* menu of PKHeX
- *View Rental Teams* should now be in the *Tools* menu of PKHeX

Original idea based on [Eppin](https://github.com/Eppin)'s [PKHeX.RentalViewer](https://github.com/Eppin/PKHeX.RentalViewer) to display rental teams in window rather than just copying to box and extended to show both battle and rental teams.

## Special Pokémon Finder
The purpose of this plugin is to find Pokémon with special conditions to get specific forms or evolutions
- *Pokémon Finders* should now be in the *Tools* menu of PKHeX.

The original idea is from [suloku](https://github.com/suloku)'s [PKHeXThreeFinderPlugin](https://github.com/suloku/PKHeXThreeFinderPlugin) to find Dunsparce or Tandemaus which will give the Three-Segment or Family of Three forms respectively.

## Building
- Open PowerShell and Run `build.ps1`
- Individual Plugins should be located in `bin\Build\Individual`
- Combined Plugin should be located at `bin\Build\PluginPile.dll`
- Unmaintained Plugins should be located in `bin\Build\Unmaintained`

### Requirements
- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET](https://dotnet.microsoft.com/)

### Trouble Running PowerShell Script
- Open PowerShell As Administrator
- Run `Get-ExecutionPolicy` and note the value
- Run `Set-ExecutionPolicy Unrestricted`
- Follow the building step above
- Run `Set-ExecutionPolicy <previous execution policy value>` e.g. `Set-ExecutionPolicy AllSigned`

## Language Support
The default language for this project is English but there appears to be interest in localizing, so I have added a way to add to do multilingual support even if it is hacky. To add support for a language that PKHeX supports, go to the desired plugin and modify the switch cases in the `Language.cs` file using the following language codes that `PKHeX.Core.GameInfo.CurrentLanguage` returns
| Key | Language            | Supported | Contributors                                                                                                                                                       |
|-----|---------------------|-----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| de  | German              | Partial   | [BlackShark](https://github.com/Bl4ckSh4rk)                                                                                                                        |
| en  | English             | Yes       | Me                                                                                                                                                                 |
| es  | Spanish             | Partial   | [StevensND](https://github.com/StevensND)                                                                                                                          |
| fr  | French              | No        |                                                                                                                                                                    |
| it  | Italian             | Partial   | [Pasquale Nardiello](https://github.com/pasqualenardiello)                                                                                                         |
| ja  | Japanese            | No        |                                                                                                                                                                    |
| ko  | Korean              | No        |                                                                                                                                                                    |
| zh  | Simplified Chinese  | Partial   | [wubinwww](https://github.com/wubinwww), [ppllouf](https://github.com/ppllouf), [easyworld](https://github.com/easyworld), [ZiYuKing](https://github.com/ZiYuKing) |
| zh2 | Traditional Chinese | No        |                                                                                                                                                                    |
