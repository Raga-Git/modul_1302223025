using Jurnal8_1302223025;
using System.Security.Cryptography;
using System.Text;
using System;

public class PasswordHashing
{
    public static byte[] GenerateSalt()
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] salt = new byte[32];
            rng.GetBytes(salt);
            return salt;
        }
    }

    public static string HashPassword(string password)
    {
        byte[] salt = GenerateSalt();
        byte[] passByte = Encoding.UTF8.GetBytes(password);
        using(var SHA256 = new HMACSHA256(salt))
        {
            byte[] HashBytes = SHA256.ComputeHash(passByte);
            string hash = Convert.ToBase64String(HashBytes);
            string saltString = Convert.ToBase64String(salt);
            return $"{saltString};{hash}";
        }
    }



    static void Main(string[] args)
    {
        BankTransferConfig bt = new BankTransferConfig();
        Config config = new Config();
        string username = "";
        string password = "";
      //Console.WriteLine($" Hash Password : {HashedPassword}");
        bool check = true;
        Console.WriteLine("Register");
        Console.WriteLine("Masukan Username : ");
        username = Console.ReadLine();
   

        if (username.Length > 8 && username.Length < 20)
        {
            Console.WriteLine("Masukan Password : ");
            password = Console.ReadLine();
            string HashedPassword = HashPassword(password);
            //check = true;
        }
        else
        {
            Console.WriteLine("Masukan Username : ");
            username = Console.ReadLine();
        }

        Console.WriteLine("Login");
        Console.WriteLine("Masukan Username : ");
        string LoginUser = Console.ReadLine();
        Console.WriteLine("Masukan Password : ");
        string PassUser = Console.ReadLine();

        if (LoginUser == username && PassUser == password)
        {
            Console.WriteLine("Login Berhasil");
        }

    }
}