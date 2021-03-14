
dotnet new sln
dotnet new classlib -o HelloDILibrary
dotnet sln add HelloDILibrary/HelloDILibrary.csproj
dotnet new console -o HelloDIApp
dotnet sln add HelloDIApp/HelloDIApp.csproj
dotnet add HelloDIApp/HelloDIApp.csproj reference HelloDILibrary/HelloDILibrary.csproj

dotnet build
dotnet run --project HelloDIApp/HelloDIApp.csproj

dotnet new mstest -o HelloDILibraryTest
dotnet sln add HelloDILibraryTest/HelloDILibraryTest.csproj
dotnet add HelloDILibraryTest/HelloDILibraryTest.csproj reference HelloDILibrary/HelloDILibrary.csproj

