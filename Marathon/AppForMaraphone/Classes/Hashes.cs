using System;
using System.Security.Cryptography;
using System.Text;

namespace AppForMaraphone.Classes
{
    public class Hashes
    {
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            byte[] saltedHashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Buffer.BlockCopy(saltedHashBytes, 0, salt, 0, salt.Length);
            string newHash = HashPassword(enteredPassword, salt);
            return storedHash == newHash;
        }

        public static string HashPassword(string password, byte[] salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[salt.Length + passwordBytes.Length];
            Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
            Buffer.BlockCopy(passwordBytes, 0, saltedPassword, salt.Length, passwordBytes.Length);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(saltedPassword);
                byte[] saltedHash = new byte[salt.Length + hash.Length];
                Buffer.BlockCopy(salt, 0, saltedHash, 0, salt.Length);
                Buffer.BlockCopy(hash, 0, saltedHash, salt.Length, hash.Length);
                return Convert.ToBase64String(saltedHash);
            }
        }
    }
}
