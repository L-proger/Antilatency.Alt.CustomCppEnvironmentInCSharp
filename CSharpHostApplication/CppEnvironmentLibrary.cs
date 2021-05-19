using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHostApplication {
    public static class CppEnvironmentLibrary {
        //Native imports
        [DllImport("CppEnvironment", EntryPoint = "createEnvironment")]
        private static extern IntPtr _CreateEnvironment();

        [DllImport("CppEnvironment", EntryPoint = "useEnvironment")]
        private static extern IntPtr _UseEnvironment(IntPtr environment);

        //Fancy wrappers
        public static Antilatency.Alt.Tracking.IEnvironment CreateEnvironment() {
            var rawInterfacePtr = _CreateEnvironment();
            return new Antilatency.Alt.Tracking.Details.IEnvironmentWrapper(rawInterfacePtr);
        }

        public static void UseEnvironment(Antilatency.Alt.Tracking.IEnvironment environment) {
            var rawInterfacePtr = Antilatency.InterfaceContract.Details.InterfaceMarshaler.ManagedToNative(environment);
            _UseEnvironment(rawInterfacePtr);
        }
    }
}