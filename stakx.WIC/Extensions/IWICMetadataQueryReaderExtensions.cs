using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    public static class IWICMetadataQueryReaderExtensions
    {
        public static bool GetMetadataByName(this IWICMetadataQueryReader metadataQueryReader, string wzName, out object value)
        {
            var propVariant = new PROPVARIANT();
            try
            {
                metadataQueryReader.GetMetadataByName(wzName, ref propVariant);
                switch (propVariant.Type)
                {
                    case VARTYPE.VT_I1:
                        value = propVariant.Value.I1;
                        return true;
                    case VARTYPE.VT_I2:
                        value = propVariant.Value.I2;
                        return true;
                    case VARTYPE.VT_I4:
                        value = propVariant.Value.I4;
                        return true;
                    case VARTYPE.VT_I8:
                        value = propVariant.Value.I8;
                        return true;

                    case VARTYPE.VT_UI1:
                        value = propVariant.Value.UI1;
                        return true;
                    case VARTYPE.VT_UI2:
                        value = propVariant.Value.UI2;
                        return true;
                    case VARTYPE.VT_UI4:
                        value = propVariant.Value.UI4;
                        return true;
                    case VARTYPE.VT_UI8:
                        value = propVariant.Value.UI8;
                        return true;

                    case VARTYPE.VT_LPSTR:
                        value = Marshal.PtrToStringAnsi(propVariant.Value.P);
                        Marshal.FreeCoTaskMem(propVariant.Value.P);
                        return true;
                    case VARTYPE.VT_LPWSTR:
                        value = Marshal.PtrToStringUni(propVariant.Value.P);
                        Marshal.FreeCoTaskMem(propVariant.Value.P);
                        return true;

                    case VARTYPE.VT_UNKNOWN:
                        value = Marshal.GetObjectForIUnknown(propVariant.Value.P) as IWICMetadataQueryReader;
                        if (value == null)
                        {
                            throw new System.NotImplementedException();
                        }
                        return true;

                    default:
                        throw new System.NotImplementedException();
                }
            }
            catch (COMException ex) when (ex.ErrorCode == unchecked((int)0x88982F40))
            {
                value = null;
                return false;
            }
        }
    }
}
