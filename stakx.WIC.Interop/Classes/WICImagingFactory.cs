using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICImagingFactory)]
    [CoClass(typeof(WICImagingFactoryClass))]
    public interface WICImagingFactory : IWICImagingFactory { }

    [ComImport]
    [Guid(CLSID.WICImagingFactory)]
    [ComDefaultInterface(typeof(IWICImagingFactory))]
    public class WICImagingFactoryClass { }
}
