using System;
using Antilatency.DeviceNetwork;

namespace CSharpHostApplication {
    class Program {
        static void Main(string[] args) {
            var environment = CppEnvironmentLibrary.CreateEnvironment();

            //Use C++ environment from C# side
            Console.WriteLine($"C#: IsMutable environment = {environment.isMutable()}");

            //Use C++ environment from C++ side
            CppEnvironmentLibrary.UseEnvironment(environment);

            //Release interface reference. Since there is only one reference to the interfaced object, here it will be destroyed ... 
            Antilatency.Utils.SafeDispose(ref environment);

            //Remember to Dispose() or "Antilatency.Utils.SafeDispose" the interface references so that this leads to deterministic destruction of objects.
            //Leaving unused interface references for GC garbage collection is NOT recommended.
        }
    }
}