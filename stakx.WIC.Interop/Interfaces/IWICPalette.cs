using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICPalette)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICPalette
    {
        void InitializePredefined(
            [In] WICBitmapPaletteType ePaletteType,
            [In] bool fAddTransparentColor);

        void InitializeCustom(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 1)] int[] pColors,
            [In] int cCount);

        void InitializeFromBitmap(
            [In] IWICBitmapSource pISurface,
            [In] int cCount,
            [In] bool fAddTransparentColor);

        void InitializeFromPalette(
            [In] IWICPalette pIPalette);

        void GetType(
            [Out] out WICBitmapPaletteType pePaletteType);

        void GetColorCount(
            [Out] int pcCount);

        void GetColors(
            [In] int cCount,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 0)] int[] pColors,
            [Out] out int pcActualColors);

        void IsBlackWhite(
            [Out] out bool pfIsBlackWhite);

        void IsGrayscale(
            [Out] out bool pfIsGrayscale);

        void HasAlpha(
            [Out] out bool pfHasAlpha);
    }
}
