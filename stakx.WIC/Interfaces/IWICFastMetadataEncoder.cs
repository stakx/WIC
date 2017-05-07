using System.Runtime.InteropServices;

namespace stakx.WIC
{
    [ComImport]
    [Guid(IID.IWICFastMetadataEncoder)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICFastMetadataEncoder
    {
        void Commit();

        IWICMetadataQueryWriter GetMetadataQueryWriter();
    }
}
