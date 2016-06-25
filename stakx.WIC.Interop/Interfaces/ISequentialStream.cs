using System.ComponentModel;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.ISequentialStream)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISequentialStream
    {
        void Read(
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte[] pv,
            [In] int cb,
            [Out] out int pcbRead);

        void Write(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte[] pv,
            [In] int cb,
            [Out] out int pcbWritten);
    }
}
