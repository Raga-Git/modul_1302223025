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
        
    public class SimpleDataBase<DataBase>
    {
        private List<DataBase> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {

            this.storedData = new List<DataBase>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData(DataBase T)
        {
            storedData.Add(T);
            inputDates.Add(DateTime.UtcNow);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData.ElementAt(i)}, yang disimpan pada waktu UTC: {inputDates.ElementAt(i)}");

            }
        }
    }
    private static void Main(string[] args)
    {
        //NIM : 1302223025
        double nim1 = 13;
        double nim2 = 2;
        double nim3 = 22;
        penjumlahan.JumlahTigaAngka(nim1, nim2, nim3);

        SimpleDataBase<double> inp = new SimpleDataBase<double>();
        inp.AddNewData(13);
        inp.AddNewData(02);
        inp.AddNewData(22);

        inp.PrintAllData();

    }
}