using static ThreadTest2024.Program;

namespace ThreadTest2024
{
    public partial class Form1 : Form
    {
        Thread thread;

        public Form1()
        {
            InitializeComponent();
            thread = new Thread(Tellen);
            thread.IsBackground = true;
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("je hebt op de drukknop geklikt...");
        }

        private void Tellen()
        {
            int i = 0;
            while (true)
            {
                Thread.Sleep(1000);
                i++;
                if (i == 60) i = 0;

            }
        }
    }
}
