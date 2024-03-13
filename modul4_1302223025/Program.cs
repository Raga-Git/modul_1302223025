using System;
using static Program.KodeBuah;
public class Program
{
    public class KodeBuah
    {
        public enum namaBuah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        public static string getKodeBuah(namaBuah nama)
        {
            string[] kodeBuah = { "A00","B00","C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
            return kodeBuah[(int)nama]; 
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Buah " + namaBuah.Kurma + " Memiliki kode buah " + getKodeBuah(namaBuah.Kurma));
    }
}