@echo off

REM Copy ../Art/icon.png to the current directory
copy /y ..\Art\icon.png .
REM Copy ../Art/manifest.json to the current directory
copy /y ..\Art\manifest.json .
REM Copy ../README.md to the current directory
copy /y ..\README.md .
REM Copy ../CHANGELOG.md to the current directory
copy /y ..\CHANGELOG.md .
REM Copy all files from ../Coroner/build/bin/Debug to the current directory
xcopy /s /y /q ..\CleanerLogs\build\bin\Debug\* .\BepInEx\plugins\

REM Create a zip file named Coroner.zip containing all files (except build.bat and Strings_test.xml) in the current directory
"C:\Program Files\7-Zip\7z.exe" a -r CleanerLogs.zip * -x!build.bat -x!CleanerLogs.zip

for %%I in (*) do if not "%%I"=="CleanerLogs.zip" if not "%%I"=="build.bat" del /q "%%I"
for /d %%D in (*) do if not "%%D"=="CleanerLogs.zip" if not "%%D"=="build.bat" rd /s /q "%%D"