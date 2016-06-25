using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICMetadataBlockReader)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataBlockReader
    {
        void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        void GetCount(
            [Out] out int pcCount);

        void GetReaderByIndex(
            [In] int nIndex,
            [Out] out IWICMetadataReader ppIMetadataReader);

        void GetEnumerator(
            [Out] out IEnumUnknown ppIEnumMetadata);
    }
}
