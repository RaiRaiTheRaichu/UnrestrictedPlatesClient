# Unrestricted Plates - Client

An SPT-AKI module mod that must be installed alongside the Unrestricted Plates mod. This is to patch a bug where plates with unlocked soft armor slots can not be turned in for quests.

### How to install

1. Download the latest release here: [link](https://github.com/RaiRaiTheRaichu/UnrestrictedPlatesClient/releases) -OR- build from source (instructions below)
2. Simply extract the zip file contents into your root SPT-AKI folder (where EscapeFromTarkov.exe is).
3. Your `BepInEx/plugins` folder should now contain a `RaiRai.UnrestrictedPlates.dll` file inside.

Please note this is meant to be installed alongside the server module, so make sure you have downloaded Unrestricted Plates from the SPT-AKI hub webpage as well. It will come with this client mod included in the zip.

### Known issues

None at the moment.

### How to build from source

1. Download/clone this repository.
2. Open your current SPT directory and copy all files required under the "Reference list" section to their respective folders.
3. Rebuild the project in the Release configuration.
4. Grab the `RaiRai.UnrestrictedPlates.dll` file from the `build/plugins/` folder and use it wherever. Refer to the "How to install" section if you need help here.

### Reference list

Copy to this project's folder (create if it does not exist) `references/EFT/Managed`:
- Aki.Reflection.dll
- Assembly-CSharp.dll
- UnityEngine.dll
- UnityEngine.CoreModule.dll
These can be found in your SPT install's `EscapeFromTarkov_Data/Managed/` folder.

Copy to this project's folder (create if it does not exist) `references/Bepinex`:
- 0Harmony.dll
- BepInEx.dll
These can be found in your SPT install's `BepInEx/core/` folder.

### Credits
RaiRaiTheRaichu
Terkoiz
