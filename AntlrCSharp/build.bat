dotnet publish -r win-x64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -c Release --self-contained true
dotnet publish -r linux-x64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -c Release --self-contained true
dotnet publish -r osx-x64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -c Release --self-contained true
echo Publish completed!
pause