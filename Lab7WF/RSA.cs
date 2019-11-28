using System;
using System.Security.Cryptography;

namespace Lab7
{
    public enum Info
    {
        P, Q, N, D, EXPONENT
    }

    class RSA
    {

        private RSACryptoServiceProvider rsa;
        private readonly int keySize;
        private CspParameters cspParameters;

        public RSA() { }

        public RSA(int keySize, string _storageName)
        {
            this.keySize = keySize;
            cspParameters = new CspParameters()
            {
                Flags = CspProviderFlags.UseMachineKeyStore,
                KeyContainerName = _storageName
            };
            rsa = new RSACryptoServiceProvider(keySize, cspParameters);
        }

        public byte[] GetField(Info param)
        {
            byte[] field = null;
            RSAParameters rsaParameters;
            try
            {
                rsaParameters = rsa.ExportParameters(true);
            }
            catch (CryptographicException)
            {
                rsaParameters = rsa.ExportParameters(false);
            }
            switch (param)
            {
                case Info.D:
                    field = rsaParameters.D;
                    break;

                case Info.P:
                    field = rsaParameters.P;
                    break;

                case Info.Q:
                    field = rsaParameters.Q;
                    break;
                case Info.N:
                    field = rsaParameters.Modulus;
                    break;

                case Info.EXPONENT:
                    field = rsaParameters.Exponent;
                    break;
            }
            return field;
        }

        public KeySizes[] GetPossibleKeySizes()
        {
            return rsa.LegalKeySizes;
        }

        public byte[] Encrypt(byte[] data)
        {
            return rsa.Encrypt(data, fOAEP: true);
        }

        public byte[] Decrypt(byte[] data)
        {
            return rsa.Decrypt(data, fOAEP: true);
        }

        internal bool LoadFromStorage(string containerName)
        {
            bool result;
            try
            {
                cspParameters = new CspParameters
                {
                    KeyContainerName = containerName,
                    Flags = CspProviderFlags.UseMachineKeyStore
                };
                rsa = new RSACryptoServiceProvider(keySize, cspParameters);
                result = true;
            }
            catch (CryptographicException)
            {
                result = false;
            }
            return result;
        }
    }
}
