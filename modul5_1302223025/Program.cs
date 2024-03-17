public class Program
{
    public class penjumlahan
    {
        public static void JumlahTigaAngka<T>(T input1, T input2, T input3) 
        {
            dynamic angka1 = input1;
            dynamic angka2 = input2;
            dynamic angka3 = input3;
            Console.Write("Hasil : ");
            Console.WriteLine(angka1 + angka2 + angka3);
        }
    }
    private static void Main(string[] args)
    {
        //1302223025
        double nim1 = 13;
        double nim2 = 2;
        double nim3 = 22;
        penjumlahan.JumlahTigaAngka(nim1, nim2, nim3);
    }
}