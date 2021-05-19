cmake_minimum_required (VERSION 3.13)

set(CMAKE_INSTALL_PREFIX "${CMAKE_CURRENT_LIST_DIR}/..")

project ("CppEnvironment")

add_library (CppEnvironment  SHARED  "CppEnvironment.h" "Library.cpp" )
target_include_directories(CppEnvironment PUBLIC "${CMAKE_CURRENT_LIST_DIR}/../NativeAPI/include")

install(TARGETS CppEnvironment LIBRARY)
