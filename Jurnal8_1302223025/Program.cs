using Jurnal8_1302223025;

public class Program
{
    private static void Main(string[] args)
    {
        int inputMoney = 0;
        int fee = 0;
        BankTransferConfig bankTransferConfig = new BankTransferConfig();
        bankTransferConfig.ReadConfigFile();
    
        if (bankTransferConfig.config.lang == "en") 
        {
            Console.WriteLine($"Please Insert the amount of money to transfer : ");
            inputMoney = Convert.ToInt32(Console.ReadLine());
        } else if (bankTransferConfig.config.lang == "id")
        {
            Console.WriteLine($"Masukan Jumlah uang yang akan ditransfer : ");
            inputMoney = Convert.ToInt32(Console.ReadLine());
        }

        if (inputMoney <= bankTransferConfig.config.transfer.threshold) 
        {
            fee = bankTransferConfig.config.transfer.low_fee;
        } else 
        {
            fee = bankTransferConfig.config.transfer.high_fee;
        }

        if (bankTransferConfig.config.lang == "en")
        {
            Console.WriteLine($"Transfer fee = {fee} Total Amount = {inputMoney}");
        } else if (bankTransferConfig.config.lang == "id")
        {
            Console.WriteLine($"Biaya Transfer = {fee} Total Biaya = {inputMoney}");
        }

    }
}