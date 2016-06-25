using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IEnumString)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IEnumString
    {
        void Next(
            [In] int celt,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 0)] string[] rgelt,
            [Out] out int pceltFetched);

        void Skip(
            [In] int celt);

        void Reset();

        void Clone(
            [Out] out IEnumString ppenum);
    }
}
