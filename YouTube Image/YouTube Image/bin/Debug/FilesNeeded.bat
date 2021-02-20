@ECHO OFF

set zip=FilesNeeded.7z
set needed=FilesNeeded.ini
set log=FilesNeeded.output.txt

REM Unless updating code do not edit below here.
set version=1.1
TITLE=FilesNeeded v%version%

IF NOT EXIST %needed% goto createNeeded
goto main
:main
ECHO. >%log%

FOR /F "delims=" %%i in (%needed%) DO (
 REM echo %%i
 7z a %zip% "%%i"
 )>>%log%
goto eof

:createNeeded
dir /b >>%needed%
ECHO You will need to edit the file %needed%
ECHO to represent what is needed in the final product.
ECHO.
ECHO. Once you have done this re-run this batch file to create
ECHO. a zip file titled %zip%
pause
goto eof

:eof