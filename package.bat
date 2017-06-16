msbuild src\AutoMapper.Runtime.Extensions.sln /t:Rebuild /p:Configuration=Release /p:Platform="Any CPU"
nuget pack AutoMapper.Runtime.Extensions.nuspec

#https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package