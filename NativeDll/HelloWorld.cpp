#include "pch.h"

extern "C" __declspec(dllexport) void HelloWorld()
{
  std::cout << "Hello from the native DLL!" << std::endl;
}
