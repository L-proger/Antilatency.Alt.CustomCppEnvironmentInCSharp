# Antilatency.Alt.Unity.CustomCppEnvironment
This example demonstrates how to create a custom C++ Environment implementation for the Antilatency's Alt tracker from scratch and use it in a C# application.

The CppEnvironment is implemented in a separate shared library and used from a C# application. You can find out how interface pointers can be passed from C# to C++ and from C++ to C# (if you don't have AntilatencyApiGenerator). Notice the createEnvironment and useEnvironment methods on both sides, you can also learn how to create "Interfaced Object" and how they can implement interfaces (IEnvironment in current example). 

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
