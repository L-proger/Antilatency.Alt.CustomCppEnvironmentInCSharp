#include "CppEnvironment.h"

#if defined(__CYGWIN32__) || defined(WIN32) || defined(_WIN32) || defined(__WIN32__) || defined(_WIN64) || defined(WINAPI_FAMILY)
	#define LIBRARY_API_CALL __stdcall
	#define LIBRARY_API_EXPORT __declspec(dllexport)
#elif defined(__linux__) || defined(__ANDROID__)
	#define LIBRARY_API_CALL
	#define LIBRARY_API_EXPORT __attribute__ ((visibility ("default")))
#else
	#define LIBRARY_API_CALL
	#define LIBRARY_API_EXPORT
#endif


extern "C" LIBRARY_API_EXPORT void* LIBRARY_API_CALL createEnvironment() {
	auto environment = Antilatency::Alt::Tracking::IEnvironment::create<CppEnvironment>(/*some CppEnvironment constructor arguments*/);
	//Get a raw pointer from Antilatency::Alt::Tracking::IEnvironment 
	//so that its reference count doesn't decrement in IEnvironment's destructor
	return environment.detach(); 
}

extern "C" LIBRARY_API_EXPORT void LIBRARY_API_CALL useEnvironment(Antilatency::Alt::Tracking::IEnvironment::VMT* ienvironmentRawPtr) {
	Antilatency::Alt::Tracking::IEnvironment environment;
	//Attach the IEnvironment smart pointer to ienvironmentRawPtr 
	//so that it does NOT increment the ienvironmentRawPtr reference count 
	//because it MUST be incremented at the caller's site.
	environment.attach(ienvironmentRawPtr); 
	
	auto markers = environment.getMarkers();
	std::cout << "C++: useEnvironment: markers count = " << markers.size() << std::endl;
}