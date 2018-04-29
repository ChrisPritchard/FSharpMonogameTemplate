# F# .NET Core MonoGame template with CoreRT

A very basic, running MonoGame starter, using F#, .NET Core and CoreRT. These three things are not standard for MonoGame, so combining them requires a bit of effort. This template has that done already.

Tested on windows 10 only. In order to run you need, obviously, the .NET Core SDK (2.0+). To compile the CoreRT executable, you need the C++ linker on windows at least, which can be obtained at least one way by installing VS Community and specifying C++ dev and/or the Win 10 SDK. The command to build the exe is 'dotnet publish -r win-x64'; Note the win-x64 as opposed to win10-x64: the latter at time of writing causes CoreRT to fail with an unfixable message.