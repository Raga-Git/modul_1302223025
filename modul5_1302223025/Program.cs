public class Program
{
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
        SimpleDataBase<double> inp = new SimpleDataBase<double>();
        inp.AddNewData(13);
        inp.AddNewData(02);
        inp.AddNewData(22);

        inp.PrintAllData();
    }
}