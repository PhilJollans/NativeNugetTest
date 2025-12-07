# NativeNugetTest

Demo solution to bind a native C++ DLL into a NuGet package which can be used in .NET Core 8.0 or .NET Framework 4.8.

This solution contains 4 projects:

| Project | Description |
|-|-|
| NativeDll | This is a C++ windows native DLL, which can be built as 32 or 64 bit code.<br/>The DLL contains a single method which writes *Hello from the native DLL!* to the console. |
| WrapperDll | This is a C# DLL which targets **.NET Core 8.0** and **.NET Framework 4.8**.<br/>This project creates a **NuGet** package containing **WrapperDll.dll** and **NativeDll.dll**. |
| Core8ConsoleTest | C# console app targeting .NET Core 8.0 and using the Nuget package. |
| Framework48ConsoleTest | C# console app targeting .NET Framework 4.8 and using the NuGet package. |

The solution contains a `NuGet.Config` file which references the output directory `WrapperDll\bin\Debug`. The demo will o nly work with the Debug configuration. :wink:

The Native DLL is packed into the DLL in the directory structure:  
 - runtimes
   - win-x64
     - native
       - `nativeDll.dll`
   - win-x86
     - native
       - `nativeDll.dll`

This structure works automatically with .NET Core 8.0.

To work with .NET Framework 4.8, there is also a file `WrapperDll.targets` in the directory structure:
 - build
   - net48
     - `WrapperDll.targets`

This `.targets` file ensures that `NativeDll.dll` is copied to the output directory.

This only works if the .NET Framework application targets **x86** or **x64**.  
<u>It does not work if the application targets **AnyCPU**</u>

So far as I can tell, this is a limitation of .NET Framework.

This solution was created with Visual Studio 2022.
