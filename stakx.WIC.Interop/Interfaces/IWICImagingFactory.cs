using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICImagingFactory)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICImagingFactory { }
}
