# SAOMD5

A simple WinForms app that can be added to the Explorer context menu to instantly get hashes of any file.

## Files

`SAOMD5.exe` is the main program that runs. It can be run on its own with no arguments and a dialog will prompt to select a file to hash. If the program is run with a filename as an argument it will launch the winform and calculates the MD5 checksum of the file. SHA256 and SHA512 can be obtained by clicking on the form appropriately. Clicking a hash (or the filename) will copy it to the clipboard.

`SAOMD5.bat` will add the .exe to the Windows registry, adding it to the context menu of every file in Explorer. Selecting "Get File Hashes" from the context menu will run SAOMD5.exe with the selected file's filename as its argument.
