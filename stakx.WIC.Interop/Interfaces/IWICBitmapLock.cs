using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapLock)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICBitmapLock
    {
        void GetSize(
            [Out] out int puiWidth,
            [Out] out int puiHeight);

        void GetStride(
            [Out] out int pcbStride);

        unsafe void GetDataPointer(
            [Out] out int pcbBufferSize,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 0)] out byte* ppbData);

        void GetPixelFormat(
            [Out] out Guid pPixelFormat);
    }
}
