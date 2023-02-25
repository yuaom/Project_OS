﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public unsafe struct EFI_IPv6_ADDRESS {
        public fixed byte Address[16];
    }
}
