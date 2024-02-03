dotnet publish -r win-x64 -p:IncludeNativeLibrariesForSelfExtract=true -c Release 
dotnet publish -r linux-x64 -p:IncludeNativeLibrariesForSelfExtract=true -c Release 
dotnet publish -r osx-x64 -p:IncludeNativeLibrariesForSelfExtract=true -c Release 
echo Publish completed!
pause