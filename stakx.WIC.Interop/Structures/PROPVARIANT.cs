using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct PROPVARIANT
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
        public Guid* puuid;

        [FieldOffset(8)]
        public IntPtr punkVal;

        [FieldOffset(8)]
        public char* pwszVal;

        [FieldOffset(8)]
        public PROPARRAY ca;

        #warning `PROPVARIANT` is incomplete.
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PROPARRAY
    {
        public int cElems;
        public IntPtr pElems;
    }
}
