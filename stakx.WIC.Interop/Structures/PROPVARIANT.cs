using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PROPVARIANT
    {
        [FieldOffset(0)]
        public VARTYPE vt;

        [FieldOffset(8)]
        public byte bVal;

        [FieldOffset(8)]
        public short iVal;

        [FieldOffset(8)]
        public int lVal;

        [FieldOffset(8)]
        public long hVal;

        [FieldOffset(8)]
        public float fltVal;

        [FieldOffset(8)]
        public double dblVal;

        [FieldOffset(8)]
        public IntPtr puuid; // Guid*

        [FieldOffset(8)]
        public IntPtr punkVal;

        [FieldOffset(8)]
        public IntPtr pwszVal; // char*

        [FieldOffset(8)]
        public PROPARRAY ca;

        #warning `PROPVARIANT` is incomplete.
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPARRAY
    {
        public int cElems;
        public IntPtr pElems;
    }
}
