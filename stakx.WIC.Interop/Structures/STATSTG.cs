using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public unsafe struct STATSTG
    {
        public unsafe char* pwcsName;
        STGTY type;
        long cbSize;
        long mtime;
        long ctime;
        long atime;
        StreamAccessMode grfMode;
        LOCKTYPE grfLocksSupported;
        Guid clsid;
        int grfStateBits;
    }
}
