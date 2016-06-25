using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICComponentInfo)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICComponentInfo
    {
        void GetComponentType(
            [Out] out WICComponentType pType);

        void GetCLSID(
            [Out] out Guid pclsid);

        void GetSigningStatus(
            [Out] out WICComponentSigning pStatus);

        void GetAuthor(
            [In] int cchAuthor,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzAuthor,
            [Out] out int pcchActual);

        void GetVendorGUID(
            [Out] out Guid pguidVendor);

        void GetVersion(
            [In] int cchVersion,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzVersion,
            [Out] out int pcchActual);

        void GetSpecVersion(
            [In] int cchSpecVersion,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzSpecVersion,
            [Out] out int pcchActual);

        void GetFriendlyName(
            [In] int cchFriendlyName,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzFriendlyName,
            [Out] out int pcchActual);
    }
}
