namespace stakx.WIC.Interop
{
    internal delegate void StringBufferMethod(int cchX, char[] wzX, out int pcchActual);

    internal static class StringBufferMethodExtensions
    {
        internal static string InvokeAndConvertBufferToString(this StringBufferMethod stringBufferFunc)
        {
            int length;
            stringBufferFunc(0, null, out length);
            if (length > 1)
            {
                var buffer = new char[length];
                stringBufferFunc(length, buffer, out length);
                // the returned characters includes a terminating null character,
                // which we don't want in the returned string (therefore the `- 1`):
                return new string(buffer, 0, length - 1);
            }
            else if (length == 1)
            {
                // since the returned buffers includes a terminating null character,
                // a length of 1 would mean the empty string:
                return string.Empty;
            }
            else
            {
                // if there is not even a terminating null character,
                // then we got back no string at all (not even an empty one):
                return null;
            }
        }
    }
}
