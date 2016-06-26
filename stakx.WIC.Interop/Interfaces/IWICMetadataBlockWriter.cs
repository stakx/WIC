using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICMetadataBlockWriter)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataBlockWriter : IWICMetadataBlockReader
    {
        #region Members inherited from `IWICMetadataBlockReader`

        new void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        new void GetCount(
            [Out] out int pcCount);

        new void GetReaderByIndex(
            [In] int nIndex,
            [Out] out IWICMetadataReader ppIMetadataReader);

        new void GetEnumerator(
            [Out] out IEnumUnknown ppIEnumMetadata);

        #endregion

        void InitializeFromBlockReader(
            [In] IWICMetadataBlockReader pIMDBlockReader);

        void GetWriterByIndex(
            [In] int nIndex,
            [Out] out IWICMetadataWriter ppIMetadataWriter);

        void AddWriter(
            [In] IWICMetadataWriter pIMetadataWriter);

        void SetWriterByIndex(
            [In] int nIndex,
            [In] IWICMetadataWriter pIMetadataWriter);

        void RemoveWriterByIndex(
            [In] int nIndex);
    }
}
