using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICFastMetadataEncoder)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICFastMetadataEncoder
    {
        void Commit();

        void GetMetadataQueryWriter(
            [Out] out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}
