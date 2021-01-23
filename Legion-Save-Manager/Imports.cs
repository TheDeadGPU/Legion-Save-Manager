//https://github.com/alessiocentorrino/hihutex-memory-class/blob/master/Memory.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Legion_Save_Manager
{
    public class Imports
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("ntdll")]
        public static extern bool NtReadVirtualMemory(
            IntPtr ProcessHandle,
            IntPtr BaseAddress,
            byte[] Buffer,
            int NumberOfBytesToRead,
            int NumberOfBytesRead);

        [DllImport("ntdll")]
        public static extern bool NtWriteVirtualMemory(
            IntPtr ProcessHandle,
            IntPtr BaseAddress,
            byte[] Buffer,
            int NumberOfBytesToWrite,
            int NumberOfBytesWritten);
    }
}
