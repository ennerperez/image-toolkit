using System;
using System.Runtime.InteropServices;

internal static class ExternDll
{
    internal const string Kernel32 = "kernel32.dll";
    internal const string Shell32 = "shell32.dll";
}

internal static class NativeMethods
{
    [DllImport(ExternDll.Kernel32, CharSet = CharSet.Unicode, EntryPoint = "CopyMemory")]
    internal extern static void CopyMemory(IntPtr dest, IntPtr src, uint length);

    [DllImport(ExternDll.Shell32, EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    internal extern static int ExtractIconEx(string sFile, int iIndex, out IntPtr piLargeVersion, out IntPtr piSmallVersion, int amountIcons);
}