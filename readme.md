# PKHeX Plugin Pile
This is meant to be a single repo to contain all my [PKHeX](https://github.com/kwsch/PKHeX) plugins rather than having many separate repos.

## Setup Instructions
- Download the plugins from the latest release [here](https://github.com/foohyfooh/PKHeXPluginPile/releases/latest).
- Extract and unblock them in Windows' Properties Menu.
- Put them in the *plugins* folder that is in the same directory as the PKHeX binary.

*If you are confused on the setup then you can follow the instructions from PKHeX-Plugins [here](https://github.com/architdate/PKHeX-Plugins/wiki/Installing-PKHeX-Plugins).*

*While the individual plugins don't require each other to work, when updating please ensure all plugin pile plugins are the same version or there may be issues. This is because there is a common emdedded library that will only be loaded once by PKHeX.*

## Sorting Plugin
The purpose of this plugin is to provide sorting by different regional Pokédexes.
- *Sort Boxes By* should now be in the *Tools* menu of PKHeX.

## Insertion Plugin
The purpose of this plugin is to insert an empty slot in your save file.
- *Insertion Plugin* should now be in the *Tools* menu of PKHeX. Click on it to open the form.
- Input the Box Number and Slot Number and all the Pokémon from that spot will be moved down a single slot.

## Raid Importing Plugin
The purpose of this plugin is to provide a convient way to import the raid data from [Project Pokémon Event Gallery](https://github.com/projectpokemon/EventsGallery) into Sword/Shield and Scarlet/Violet.
- *Import Raid* should now be in the *Tools* menu of PKHeX.
- Once you click the button a folder select dialog will pop up.
- Select an appropriate raid folder from the Event Gallery for the game and it should be imported.
  - For Sword/Shield, this is the folder with the blocks
  - For Scarlet/Violet, this is the folder with the Identifier.txt

## Scarlet/Violet Vivillon Plugin
The purpose of this plugin is allow a user to edit which Vivillon Spawns in Scarlet and Violet overworld without requiring GO Connectivity.
- *Vivillon Form Changer* should now be in the *Tools* menu of PKHeX. Click on it to open the form.
- Select the form you want to appear in the game and click save.

### Note
The name was going to be one of the following SVVivillonPlugin, ScViVivillonPlugin, SVivillonPlugin, ScViVillonPlugin and I just went with SVivillonPlugin.

## Start Date Editor Plugin
The purpose of this plugin is allow for editing the start date on Switch games.
- *Start Date Editor* should now be in the *Tools* menu of PKHeX.
- Clicking it will open a form to change the start date of the game.

Thanks to [Lusamine](https://github.com/Lusamine) for the logic to get the date from the Scarlet and Violet Block.

## Fashion Editor Plugin
The purpose of this plugin is to allow for editing the owned clothes in games. <br>
- *Fashion Editor* should now be in the *Tools* menu of PKHeX
  - Currently works with
    - Pokémon Sword / Shield
    - Pokémon Brilliant Diamond / Shining  Pearl
    - Pokémon Legends Arceus

### Pokémon Sword and Shield Note
Note that in Sword and Shield when unlocking Tops this unlocks it in the uniform tab even if the other parts of the uniform aren't unlocked since the game is expecting all of them to be unlocked at the same time.

## Scarlet/Violet Profile Picture Viewer/Injector Plugin
The purpose of this plugin is to view and save the Profile Picture and Icon in Pokémon Scarlet and Violet.
- *Profile Picture Viewer* should now be in the *Tools* menu of PKHeX.

This is a port of the script that [Pako96](https://projectpokemon.org/home/profile/129441-pako96/) provided [here](https://projectpokemon.org/home/forums/topic/63327-scarletviolet-trainer-pictureicon-visualizer/).

### Note
While this plugin does allow for injecting custom profile picture and icon, it is recommended that you don't go online with an injected image as this a clear indicator of hacking and could result in a ban.

## Building
- Open PowerShell and Run `build.ps1`
- Plugin should be located in `bin\Build` and `bin\PKHeXPluginPile.zip`

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
| es  | Spanish             | No        |                                                                                                                                                                    |
| fr  | French              | No        |                                                                                                                                                                    |
| it  | Italian             | Partial   | [Pasquale Nardiello](https://github.com/pasqualenardiello)                                                                                                         |
| ja  | Japanese            | No        |                                                                                                                                                                    |
| ko  | Korean              | No        |                                                                                                                                                                    |
| zh  | Simplified Chinese  | Yes       | [wubinwww](https://github.com/wubinwww), [ppllouf](https://github.com/ppllouf), [easyworld](https://github.com/easyworld), [ZiYuKing](https://github.com/ZiYuKing) |
| zh2 | Traditional Chinese | No        |                                                                                                                                                                    |
