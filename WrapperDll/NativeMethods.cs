using System;
using System.Runtime.InteropServices;

internal static class NativeMethods
{
  [DllImport("NativeDll", CallingConvention = CallingConvention.Cdecl)]
  internal static extern void HelloWorld();
}
