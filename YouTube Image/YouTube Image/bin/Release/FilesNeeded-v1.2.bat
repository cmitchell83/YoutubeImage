@ECHO OFF
Set "zipapp=C:\Program Files\7-Zip\7z.exe"

set zip=FilesNeeded.7z
set needed=FilesNeeded.ini
set log=FilesNeeded.output.txt

REM Unless updating code do not edit below here.

:: Version 1.2 code
REM Output the exe's name to a temp file
DIR /b *.exe >exename.tmp
REM Set %exeName% equil to the text stored in the temp file
set /p exeName=<exename.tmp
REM Remove .exe from the variable
set exeName=%exeName:.exe=%
REM if there's a version.ini file get the version number
IF EXIST version.ini (
set /p exeversion=<version.ini
)

set version=1.2
TITLE=FilesNeeded v%version%

IF NOT EXIST %needed% goto createNeeded
goto main
:main
ECHO. >%log%

FOR /F "delims=" %%i in (%needed%) DO (
 REM echo %%i
 "%zipapp%" a %zip% "%%i"
 )>>%log%
goto rena

:createNeeded
dir /b >>%needed%
ECHO You will need to edit the file %needed%
ECHO to represent what is needed in the final product.
ECHO.
ECHO. Once you have done this re-run this batch file to create
ECHO. a zip file titled %zip%
pause
goto eof

:rena
IF EXIST version.ini (
 ren "%zip%" "%exeName%_v-%exeversion%.7z"
)
IF NOT EXIST version.ini (
 ren "%zip%" "%exeName%.7z"
)
goto cleanup

:cleanup
IF EXIST exename.tmp (
 DEL exename.tmp
)
goto eof
:eof