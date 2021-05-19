# Antilatency.Alt.Unity.CustomCppEnvironment
This example demonstrates how to create a custom C++ Environment implementation for the Antilatency's Alt tracker from scratch and use it in a C# application.

## Building CppEnvironment library
Start "x64 Native Tools Command Prompt for VS xxxx"
Inside command prompt window CD to CppEnvironment directory, then:

```
mkdir build
cd build
cmake ..
cmake --build . --config Release
cmake --install . --prefix "../.."
```

## Launching CSharpHostApplication
Open command prompt in CSharpHostApplication directory, then:

```
dotnet run
```
You should now see the CSharpHostApplication output in the console!
