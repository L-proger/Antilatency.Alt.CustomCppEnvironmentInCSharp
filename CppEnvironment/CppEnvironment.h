#pragma once

#include <Antilatency.Api.h>
#include <iostream>

class CppEnvironment : public Antilatency::InterfaceContract::InterfacedObject {
    IMPLEMENT_INTERFACE(CppEnvironment, Antilatency::Alt::Tracking::IEnvironment)
public:
    ~CppEnvironment() {
        std::cout << "CppEnvironment::~CppEnvironment" << std::endl;
    }
    Antilatency::InterfaceContract::LongBool isMutable() {
        std::cout << "CppEnvironment::isMutable call" << std::endl;
        return false;
    }
    std::vector<Antilatency::Math::float3> getMarkers() {
        std::cout << "CppEnvironment::getMarkers call" << std::endl;
        return { {0,0,0}, {1,1,1} };
    }
    Antilatency::InterfaceContract::LongBool filterRay(Antilatency::Math::float3 up, Antilatency::Math::float3 ray) {
        std::cout << "CppEnvironment::filterRay call" << std::endl;
        return false;
    }
    Antilatency::InterfaceContract::LongBool match(const std::vector<Antilatency::Math::float3>& raysUpSpace, std::vector<Antilatency::Alt::Tracking::MarkerIndex>& markersIndices, Antilatency::Math::floatP3Q& poseOfUpSpace) {
        std::cout << "CppEnvironment::match call" << std::endl;
        return false;
    }
    std::vector<Antilatency::Alt::Tracking::MarkerIndex> matchByPosition(const std::vector<Antilatency::Math::float3>& rays, Antilatency::Math::float3 origin) {
        std::cout << "CppEnvironment::matchByPosition call" << std::endl;
        return {};
    }
};
