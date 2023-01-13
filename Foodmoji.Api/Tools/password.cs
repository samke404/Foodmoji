using System.Security.Cryptography;
using System.Text;


namespace Foodmoji.Api.Tools
{
   public class password { 
    
       public static string hashPassword(string password)
    {
        // to hash password and instantiate

        var sha = SHA256.Create();

        //Convert password to byte array
        var asByteArray = Encoding.Default.GetBytes(password);
        var hashedPassword = sha.ComputeHash(asByteArray);
        return Convert.ToBase64String(hashedPassword);
    }
    }
}
