using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICMetadataWriter)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataWriter : IWICMetadataReader
    {
        #region Members inherited from `IWICMetadataReader`

        new void GetMetadataFormat(
            [Out] out Guid pguidMetadataFormat);

        new void GetMetadataHandlerInfo(
            [Out] out IWICMetadataHandlerInfo ppIHandler);

        new void GetCount(
            [Out] out int pcCount);

        new void GetValueByIndex(
            [In] int nIndex,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarSchema,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarId,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarValue);

        new void GetValue(
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarSchema,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarId,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarValue);

        new void GetEnumerator(
            [Out] out IWICEnumMetadataItem ppIEnumMetadata);

        #endregion

        void SetValue(
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarSchema,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarId,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarValue);

        void SetValueByIndex(
            [In] int nIndex,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarSchema,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarId,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarValue);

        void RemoveValue(
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarSchema,
            [In, MarshalAs(UnmanagedType.Struct)] PROPVARIANT pvarId);

        void RemoveValueByIndex(
            [In] int nIndex);
    }
}
