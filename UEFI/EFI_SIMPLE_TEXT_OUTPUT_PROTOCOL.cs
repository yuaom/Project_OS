﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL {
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, bool, EFI_STATUS> _Reset;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, char*, EFI_STATUS> _OutputString;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, char*, EFI_STATUS> _TestString;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, int, UIntn*, UIntn*, EFI_STATUS> _QueryMode;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, int, EFI_STATUS> _SetMode;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, UIntn, EFI_STATUS> _SetAttribute;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, EFI_STATUS> _ClearScreen;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, UIntn, UIntn, EFI_STATUS> _SetCursorPosition;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, bool, EFI_STATUS> _EnableCursor;
        public readonly SIMPLE_TEXT_OUTPUT_MODE* Mode;

        public unsafe EFI_STATUS Reset(bool verify = false) {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _Reset(s, verify);
            }
        }

        public unsafe EFI_STATUS OutputString(string msg) {
            if (msg == null || msg.Length < 1) return EFI_STATUS.ABORTED;
            fixed (char* str = msg) {
                return OutputString(str);
            }
        }

        public unsafe EFI_STATUS OutputString(char* msg) {
            if (msg == null) return EFI_STATUS.ABORTED;
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _OutputString(s, msg);
            }
        }

        public unsafe EFI_STATUS TestString(string msg) {
            if (msg == null || msg.Length < 1) return EFI_STATUS.ABORTED;
            fixed (char* str = msg) {
                return TestString(str);
            }
        }

        public unsafe EFI_STATUS TestString(char* msg) {
            if (msg == null) return EFI_STATUS.ABORTED;
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _TestString(s, msg);
            }
        }
        public unsafe EFI_STATUS QueryMode(int modeNumber, UIntn* columns, UIntn* rows) {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _QueryMode(s, modeNumber, columns, rows);
            }
        }

        public unsafe EFI_STATUS SetMode(int modeNumber) {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _SetMode(s, modeNumber);
            }
        }
        public unsafe EFI_STATUS SetAttribute(EFI_TEXT_COLOR text, EFI_BACKGROUND_COLOR bg) {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _SetAttribute(s, ((ulong)bg | (ulong)text));
            }
        }
        public unsafe EFI_STATUS SetAttribute(UIntn value) {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _SetAttribute(s, value);
            }
        }
        public unsafe EFI_STATUS ClearScreen() {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _ClearScreen(s);
            }
        }

        public unsafe EFI_STATUS SetCursorPosition(UIntn x, UIntn y) {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _SetCursorPosition(s, x, y);
            }
        }
        public unsafe EFI_STATUS EnableCursor(bool a) {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this) {
                return _EnableCursor(s, a);
            }
        }
    };
}
