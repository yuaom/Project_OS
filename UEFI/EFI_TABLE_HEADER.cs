﻿using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct EFI_TABLE_HEADER {
        public readonly ulong Signature;
        public readonly uint Revision;
        public readonly uint HeaderSize;
        public readonly uint CRC32;
        public readonly uint Reserved;
    };
}
