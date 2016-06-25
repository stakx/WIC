using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapDecoderInfo)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICBitmapDecoderInfo : IWICBitmapCodecInfo
    {
        #region Members inherited from `IWICBitmapCodecInfo`

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

        new void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        new void GetPixelFormats(
            [In] int cFormats,
            [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pguidPixelFormats,
            [Out] out int pcActual);

        new void GetColorManagementVersion(
            [In] int cchColorManagementVersion,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzColorManagementVersion,
            [Out] out int pcchActual);

        new void GetDeviceManufacturer(
            [In] int cchDeviceManufacturer,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzDeviceManufacturer,
            [Out] out int pcchActual);

        new void GetDeviceModels(
            [In] int cchDeviceModels,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzDeviceModels,
            [Out] out int pcchActual);

        new void GetMimeTypes(
            [In] int cchMimeTypes,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzMimeTypes,
            [Out] out int pcchActual);

        new void GetFileExtensions(
            [In] int cchFileExtensions,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzFileExtensions,
            [Out] out int pcchActual);

        new void DoesSupportAnimation(
            [Out] out bool pfSupportAnimation);

        new void DoesSupportChromakey(
            [Out] out bool pfSupportChromakey);

        new void DoesSupportLossless(
            [Out] out bool pfSupportLossless);

        new void DoesSupportMultiframe(
            [Out] out bool pfSupportMultiframe);

        new void MatchesMimeType(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wzMimeType,
            [Out] out bool pfMatches);

#endregion

        #warning `IWICBitmapDecoderInfo.GetPatterns` is incomplete.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void GetPatterns();

        void MatchesPattern(
            [In] IStream pIStream,
            [Out] out bool pfMatches);

        void CreateInstance(
            [Out] out IWICBitmapDecoder ppIBitmapDecoder);
    }
}
