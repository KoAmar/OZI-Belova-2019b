using System.Security.Cryptography;
using System.IO;
using System;

namespace Lab5
{
    public class RC2Implemention
    {
        private const int SALT_SIZE = 16;
        private const int KEY_SIZE = 16;

        private RC2CryptoServiceProvider CryptoServiceProvider { get; set; }

        public RC2Implemention(CipherMode cipherMode, PaddingMode paddingMode, string password)
        {
            CryptoServiceProvider = new RC2CryptoServiceProvider
            {
                Mode = cipherMode,
                Padding = paddingMode
            };
            byte[] salt = new byte[SALT_SIZE];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt);
            }

            CryptoServiceProvider.Key = new Rfc2898DeriveBytes(password, salt)
                .GetBytes(KEY_SIZE);
        }

        public string Info()
        {
            var result = "";
            result += $"Mode: {CryptoServiceProvider.Mode}\n";
            result += $"Padding: {CryptoServiceProvider.Padding}\n";
            result += $"BlockSize: {CryptoServiceProvider.BlockSize}\n";
            result += $"KeySize: {CryptoServiceProvider.KeySize}\n";
            result += $"Key MinSize: {CryptoServiceProvider.LegalKeySizes[0].MinSize}\n";
            result += $"Key MaxSize: {CryptoServiceProvider.LegalKeySizes[0].MaxSize}\n";
            result += $"Key: {string.Join(":", CryptoServiceProvider.Key)}\n";
            return result;
        }

        public byte[] Encrypt(string message)
        {
            byte[] encryptedTextBytes = null;

            using (RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider
            {
                Mode = CryptoServiceProvider.Mode,
                Padding = CryptoServiceProvider.Padding,
                KeySize = CryptoServiceProvider.KeySize,
                Key = CryptoServiceProvider.Key,
                IV = CryptoServiceProvider.IV
            })
            {
                ICryptoTransform transform = rC2CryptoServiceProvider
                    .CreateEncryptor(rC2CryptoServiceProvider.Key, rC2CryptoServiceProvider.IV);

                using MemoryStream memoryStream = new MemoryStream();
                using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                {
                    streamWriter.Write(message);
                }
                encryptedTextBytes = memoryStream.ToArray();
            }
            return encryptedTextBytes;
        }

        public string Decrypt(byte[] encryptedText)
        {
            string decryptedText = null;
            using (RC2CryptoServiceProvider bufaes = new RC2CryptoServiceProvider()
            {
                Mode = CryptoServiceProvider.Mode,
                Padding = CryptoServiceProvider.Padding,
                KeySize = CryptoServiceProvider.KeySize,
                Key = CryptoServiceProvider.Key,
                IV = CryptoServiceProvider.IV
            })
            {
                ICryptoTransform transform = CryptoServiceProvider
                    .CreateDecryptor(CryptoServiceProvider.Key, CryptoServiceProvider.IV);

                using MemoryStream memoryStream = new MemoryStream(encryptedText);
                using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
                using StreamReader streamReader = new StreamReader(cryptoStream);
                decryptedText = streamReader.ReadToEnd();
            }
            return decryptedText;
        }
    }
}
