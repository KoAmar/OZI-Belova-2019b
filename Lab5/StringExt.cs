namespace Lab5
{
    public static class StringExt
    {
        public static byte[] ToByteArray(this string text)
        {
            string[] parts = text.Split(':');
            byte[] array = new byte[parts.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = byte.Parse(parts[i]);
            }
            return array;
        }
    }
}
