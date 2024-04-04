SET DEST_PATH=X:\Software\ImageRatioTool\ImageJ Ratio Tool
rmdir /s /q "..\src\RatioIJ2OL\bin"
rmdir /s /q "%DEST_PATH%"
dotnet publish --configuration Release ..\src\RatioIJ2OL
robocopy "..\src\RatioIJ2OL\bin\Release\net8.0-windows\publish" "%DEST_PATH%" /E /NJH /NFL /NDL
explorer "%DEST_PATH%"
pause