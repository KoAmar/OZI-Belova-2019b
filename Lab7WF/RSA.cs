﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Lab7
{
    enum Storage
    {
        USER_CONTAINER
    }

    enum Info
    {
        P, Q, N, D, EXPONENT
    }

    enum TypeKey
    {
        PUBLIC_KEY, PRIVATE_KEY
    }

    class RSA
    {
        private RSACryptoServiceProvider rsa;
        private Int32 keySize;
        private CspParameters cspParameters;

        public RSA() { }

        public RSA(Int32 size, Storage typeStorage, String _storageName)
        {
            keySize = size;
            switch (typeStorage)
            {
                case Storage.USER_CONTAINER:
                    cspParameters = new CspParameters()
                    {
                        Flags = CspProviderFlags.UseDefaultKeyContainer,
                        KeyContainerName = _storageName
                    };
                    rsa = new RSACryptoServiceProvider(size, cspParameters);
                    break;
            }
        }

        public Byte[] GetField(Info param)
        {
            Byte[] field = null;
            RSAParameters rsaParameters;
            try
            {
                rsaParameters = rsa.ExportParameters(true);
            }
            catch (CryptographicException e)
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
                    Console.WriteLine(rsaParameters.Exponent.Length);
                    break;

            }
            return field;
        }

        public KeySizes[] GetPossibleKeySizes()
        {
            return rsa.LegalKeySizes;
        }

        public Byte[] Encrypt(Byte[] data)
        {
            return rsa.Encrypt(data, false);
        }

        public Byte[] Decrypt(Byte[] data)
        {
            return rsa.Decrypt(data, false);
        }

        public Boolean SaveInfo(Storage typeStorage, String storageName)
        {
            Boolean result = false;
            switch (typeStorage)
            {
                case Storage.USER_CONTAINER:
                    result = true;
                    break;
            }
            return result;
        }


        public Boolean LoadInfo(Storage typeStorage, TypeKey typeKey, String storageName)
        {
            Boolean result = false;
            switch (typeStorage)
            {
                case Storage.USER_CONTAINER:
                    result = LoadFromUserContainer(storageName);
                    break;
            }
            return result;
        }


        private Boolean LoadFromUserContainer(String containerName)
        {
            Boolean result;
            try
            {
                cspParameters = new CspParameters
                {
                    KeyContainerName = containerName,
                    Flags = CspProviderFlags.UseDefaultKeyContainer
                };
                rsa = new RSACryptoServiceProvider(keySize, cspParameters);
                /* rsa.PersistKeyInCsp = false;
                 rsa.Clear();*/
                result = true;
            }
            catch (CryptographicException e)
            {
                result = false;
            }
            return result;
        }
    }
}
