reg add "HKEY_CLASSES_ROOT\*\shell\Get File Hashes" /v "Icon" /t REG_SZ /d "%~dp0SAOMD5.exe" /f
reg add "HKEY_CLASSES_ROOT\*\shell\Get File Hashes\command" /t REG_SZ /d "%~dp0SAOMD5.exe \"%%1\"" /f