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

        #warning `PROPVARIANT.pwszVal` probably doesn't work as expected.
        [FieldOffset(8)]
        public char* pwszVal;

        #warning `PROPVARIANT` is incomplete.
    }
}
