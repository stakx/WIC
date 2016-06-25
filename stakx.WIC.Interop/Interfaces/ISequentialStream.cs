using System.ComponentModel;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.ISequentialStream)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface ISequentialStream
    {
        unsafe void Read(
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] void* pv,
            [In] int cb,
            [Out] out int pcbRead);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        unsafe void RemoteRead(
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte* pv,
            [In] int cb,
            [Out] out int pcbRead);

        unsafe void Write(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] void* pv,
            [In] int cb,
            [Out] out int pcbWritten);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        unsafe void RemoteWrite(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte* pv,
            [In] int cb,
            [Out] out int pcbWritten);
    }
}
