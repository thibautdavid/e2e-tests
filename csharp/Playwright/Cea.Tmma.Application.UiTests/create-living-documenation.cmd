@ECHO OFF

for %%I in (.) do set CurrDirName=%%~nxI
REM echo %CurrDirName%

livingdoc test-assembly .\bin\Debug\*\%CurrDirName%.dll -t .\bin\Debug\*\TestExecution.json