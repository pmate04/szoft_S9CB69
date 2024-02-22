namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Faktori�lis(int n)
        {
            int eredm�ny = 1;
            for (int i = 1; i <= n; i++) eredm�ny *= i;
            return eredm�ny;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++) 
            {

                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    Button button = new Button();
                    button.Top = sor * 40;
                    button.Left = oszlop * 40-sor*20+300;
                    button.Height = 40;
                    button.Width = 40;
                    Controls.Add(button);
                    int x = Faktori�lis(sor) / (Faktori�lis(oszlop) * Faktori�lis(sor-oszlop));
                    button.Text = x.ToString();
                }
            }
        }
    }
}