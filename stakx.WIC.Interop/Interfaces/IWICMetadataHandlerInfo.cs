using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICMetadataHandlerInfo)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataHandlerInfo : IWICComponentInfo
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

        void GetMetadataFormat(
            [Out] out Guid pguidMetadataFormat);

        void GetContainerFormats(
             [In] int cContainerFormats,
             [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pguidContainerFormats,
             [Out] out int pcchActual);

        void GetDeviceManufacturer(
            [In] int cchDeviceManufacturer,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzDeviceManufacturer,
            [Out] out int pcchActual);

        void GetDeviceModels(
            [In] int cchDeviceModels,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzDeviceModels,
            [Out] out int pcchActual);

        void DoesRequireFullStream(
            [Out] out bool pfRequiresFullStream);

        void DoesSupportPadding(
            [Out] out bool pfSupportsPadding);

        void DoesRequireFixedSize(
            [Out] out bool pfFixedSize);
    }
}
