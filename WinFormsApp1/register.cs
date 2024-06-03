using Jurnal8_1302223025;

namespace WinFormsApp1
{
    public partial class register : Form
    {
        BankTransferConfig bankTransferConfig = new BankTransferConfig();
        Config config = new Config();
        public register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankTransferConfig.ReadConfigFile();
            config.username = textBox1.Text;
            config.password = textBox2.Text;
            bankTransferConfig.WriteNewConfigFile();
        }
    }
}
