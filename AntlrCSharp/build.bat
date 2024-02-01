dotnet publish -r win-x64 -p:IncludeNativeLibrariesForSelfExtract=true -c Release 
echo Skipping old Builders Make sure to port to other os                                 
REM dotnet publish -r win-x64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -c Release --self-contained true
REM dotnet publish -r linux-x64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -c Release --self-contained true
REM dotnet publish -r osx-x64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -c Release --self-contained true
echo Publish completed!
pause