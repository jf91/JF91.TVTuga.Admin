using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security;
using System.Runtime.InteropServices;

namespace Windows.TVTuga.Admin.CLASSES
{
    class CLS_ENCRYPT
    {
        static byte[] entropy;

        // Default Constructor
        public CLS_ENCRYPT()
        {
        }

        public CLS_ENCRYPT(string Password)
        {
            entropy = Encoding.Unicode.GetBytes(Password);
        }

        public static string EncryptString(SecureString input)
        {
            byte[] encryptedData = ProtectedData.Protect(Encoding.Unicode.GetBytes(ToInsecureString(input)),entropy,DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData),entropy,DataProtectionScope.CurrentUser);
                return ToSecureString(Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }

        public static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }

        public string ENCRYPT(string AUX_Password)
        {
            return EncryptString(ToSecureString(AUX_Password));
        }

        public SecureString DECRYPT(string AUX_Password)
        {
            SecureString Password = DecryptString(AUX_Password);

            return Password;
        }
    }
}
