using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICMetadataReader)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataReader
    {
        void GetMetadataFormat(
            [Out] out Guid pguidMetadataFormat);

        void GetMetadataHandlerInfo(
            [Out] out IWICMetadataHandlerInfo ppIHandler);

        void GetCount(
            [Out] out int pcCount);

        void GetValueByIndex(
            [In] int nIndex,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarSchema,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarId,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarValue);

        void GetValue(
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarSchema,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarId,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarValue);

        void GetEnumerator(
            [Out] out IWICEnumMetadataItem ppIEnumMetadata);
    }
}
