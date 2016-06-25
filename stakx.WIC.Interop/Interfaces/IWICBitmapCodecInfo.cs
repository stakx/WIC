using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapCodecInfo)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapCodecInfo : IWICComponentInfo
    {
        #region Members inherited from `IWICComponentInfo`

        new void GetComponentType(
            [Out] out WICComponentType pType);

        new void GetCLSID(
            [Out] out Guid pclsid);

        new void GetSigningStatus(
            [Out] out WICComponentSigning pStatus);

        new void GetAuthor(
            [In] int cchAuthor,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzAuthor,
            [Out] out int pcchActual);

        new void GetVendorGUID(
            [Out] out Guid pguidVendor);

        new void GetVersion(
            [In] int cchVersion,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzVersion,
            [Out] out int pcchActual);

        new void GetSpecVersion(
            [In] int cchSpecVersion,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzSpecVersion,
            [Out] out int pcchActual);

        new void GetFriendlyName(
            [In] int cchFriendlyName,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzFriendlyName,
            [Out] out int pcchActual);

        #endregion

        void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        void GetPixelFormats(
            [In] int cFormats,
            [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pguidPixelFormats,
            [Out] out int pcActual);

        void GetColorManagementVersion(
            [In] int cchColorManagementVersion,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzColorManagementVersion,
            [Out] out int pcchActual);

        void GetDeviceManufacturer(
            [In] int cchDeviceManufacturer,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzDeviceManufacturer,
            [Out] out int pcchActual);

        void GetDeviceModels(
            [In] int cchDeviceModels,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzDeviceModels,
            [Out] out int pcchActual);

        void GetMimeTypes(
            [In] int cchMimeTypes,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzMimeTypes,
            [Out] out int pcchActual);

        void GetFileExtensions(
            [In] int cchFileExtensions,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzFileExtensions,
            [Out] out int pcchActual);

        void DoesSupportAnimation(
            [Out] out bool pfSupportAnimation);

        void DoesSupportChromakey(
            [Out] out bool pfSupportChromakey);

        void DoesSupportLossless(
            [Out] out bool pfSupportLossless);

        void DoesSupportMultiframe(
            [Out] out bool pfSupportMultiframe);

        void MatchesMimeType(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wzMimeType,
            [Out] out bool pfMatches);
    }
}
