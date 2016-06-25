﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public unsafe struct STATSTG
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsName;
        public STGTY type;
        public long cbSize;
        public long mtime;
        public long ctime;
        public long atime;
        public StreamAccessMode grfMode;
        public LOCKTYPE grfLocksSupported;
        public Guid clsid;
        public int grfStateBits;
    }
}